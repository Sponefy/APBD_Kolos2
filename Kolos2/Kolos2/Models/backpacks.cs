namespace Kolos2.Models;

public class backpacks
{
    public int CharacterId { get; set; }
    public int ItemId { get; set; }
    public int Amount { get; set; }
    
    public itmes Item { get; set; }
    public characters Character { get; set; }
}