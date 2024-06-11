using Kolos2.Dtos;

namespace Kolos2.Services;

public interface ICharacterService
{
    Task<CharacterDto?> GetCharacter(int id);
}