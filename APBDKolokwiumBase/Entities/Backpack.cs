using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBDKolokwiumBase.Entities;

[Table("Backpack")]
[PrimaryKey(nameof(CharacterId), nameof(ItemId))]

public class Backpack
{
    [ForeignKey(nameof(Character))]
    public int CharacterId { get; set; }
    [ForeignKey(nameof(Item))]
    public int ItemId { get; set; }

    public Item Item { get; set; } = null!; 
    
    public Character  Character { get; set; } = null!;
    
    public int Amount { get; set; }
}