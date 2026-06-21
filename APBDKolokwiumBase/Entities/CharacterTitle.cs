using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBDKolokwiumBase.Entities;

[Table("CharacterTitle")]
[PrimaryKey(nameof(CharacterId), nameof(TitleId))]

public class CharacterTitle
{
    [ForeignKey(nameof(Character))]
    public int CharacterId { get; set; }
    [ForeignKey(nameof(Title))]
    public int TitleId { get; set; }

    public Title Title{ get; set; } = null!; 
    
    public Character  Character { get; set; } = null!;
    
    public DateTime AcquiredAt { get; set; }
}