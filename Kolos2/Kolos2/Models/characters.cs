using System.ComponentModel.DataAnnotations;

namespace Kolos2.Models;

public class characters
{
    [Key]
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int CurrentWei { get; set; }
    public int MaxWeight { get; set; }
    
    public ICollection<backpacks> Backpacks { get; set; }
    public ICollection<character_titles> CharacterTitles { get; set; }
}