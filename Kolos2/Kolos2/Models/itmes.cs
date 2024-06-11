using System.ComponentModel.DataAnnotations;

namespace Kolos2.Models;

public class itmes
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Wieght { get; set; }
    
    public ICollection<backpacks> Backpacks { get; set; }
}