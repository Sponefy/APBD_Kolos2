namespace Kolos2.Models;

public class character_titles
{
    public int CharacterId { get; set; }
    public int TitleId { get; set; }
    public DateTime AcquiredAt { get; set; }
    
    public characters Character { get; set; }
    public titles Title { get; set; }
}