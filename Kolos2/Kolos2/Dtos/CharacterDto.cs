using Kolos2.Models;

namespace Kolos2.Dtos;

public class CharacterDto
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int CurrentWei { get; set; }
    public int MaxWeight { get; set; }
    
    public List<BackpackDto> Backpacks { get; set; }
    public ICollection<CharacterTitleDto> CharacterTitles { get; set; }
}