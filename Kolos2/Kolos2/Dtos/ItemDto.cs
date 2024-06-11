namespace Kolos2.Dtos;

public class ItemDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Wieght { get; set; }
    
    public ICollection<BackpackDto> Backpacks { get; set; }
}