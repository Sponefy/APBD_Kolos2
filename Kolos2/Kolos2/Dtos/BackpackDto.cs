namespace Kolos2.Dtos;

public class BackpackDto
{
    public int CharacterId { get; set; }
    public int ItemId { get; set; }
    public int Amount { get; set; }
    
    public ItemDto Item { get; set; }
    public CharacterDto Character { get; set; }
}