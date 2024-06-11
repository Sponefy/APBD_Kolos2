using System.ComponentModel.DataAnnotations;

namespace Kolos2.Models;

public class titles
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    
    public ICollection<character_titles> CharacterTitles { get; set; }
}