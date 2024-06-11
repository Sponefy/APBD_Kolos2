using Kolos2.Data;
using Kolos2.Dtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Kolos2.Models;
namespace Kolos2.Services;

public class CharacterService : ICharacterService
{
    private readonly KolosContext _context;

    public CharacterService(KolosContext context)
    {
        _context = context;
    }

    public async Task<CharacterDto?> GetCharacter(int id)
    {
        var character = await _context.characters
            .Where(x => x.Id == id)
            .Select(x => new CharacterDto
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                CurrentWei = x.CurrentWei,
                MaxWeight = x.MaxWeight
            }).SingleOrDefaultAsync();

        if (character == null)
        {
            return null;
        }

        character.Backpacks = await _context.backpacks
            .Where(x => x.CharacterId == id)
            .Select(x => new BackpackDto()
            {
                Amount = x.Amount
            }).ToListAsync();


        character.CharacterTitles = await _context.characterTitles
            .Where(x => x.CharacterId == id)
            .Select(x => new CharacterTitleDto()
            {
                AcquiredAt = x.AcquiredAt
            }).ToListAsync();
        
        return character;
    }
}