namespace Kolos2.Dtos;

public class TitleDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    
    public ICollection<CharacterTitleDto> CharacterTitles { get; set; }
}