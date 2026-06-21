using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBDKolokwiumBase.Entities;

[Table("Title")]
public class Title
{
    [Key]
    public int TitleId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    

    public ICollection<CharacterTitle> CharacterTitle { get; set; } = null!;
}