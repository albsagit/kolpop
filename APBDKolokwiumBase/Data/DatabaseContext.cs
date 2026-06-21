using APBDKolokwiumBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace APBDKolokwiumBase.Data;

public class DatabaseContext : DbContext
{   
    public DbSet<Backpack> Backpacks { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<CharacterTitle> CharacterTitles { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Title> Titles { get; set; } 
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
