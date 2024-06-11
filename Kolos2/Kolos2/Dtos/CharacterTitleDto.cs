namespace Kolos2.Dtos;

public class CharacterTitleDto
{
    public int CharacterId { get; set; }
    public int TitleId { get; set; }
    public DateTime AcquiredAt { get; set; }
    
    public CharacterDto Character { get; set; }
    public TitleDto Title { get; set; }
}