using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBDKolokwiumBase.Entities;

[Table("Character")]
public class Character
{
    [Key]
    public int CharacterId { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;
    [MaxLength(120)]
    public string LastName { get; set; } = null!;
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public ICollection<Backpack> Backpack { get; set; } = null!;
    public ICollection<CharacterTitle> CharacterTitle { get; set; } = null!;
}