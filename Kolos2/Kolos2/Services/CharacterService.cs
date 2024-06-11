using Kolos2.Data;
using Kolos2.Dtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

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
        var character = await _context.Characters
            .Where(x => x.Id == id)
            .Select(x => new CharacterDto
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                CurrentWei = x.CurrentWei,
                MaxWeight = x.MaxWeight
            }).SingleOrDefaultAsync();

        return character;
    }
}