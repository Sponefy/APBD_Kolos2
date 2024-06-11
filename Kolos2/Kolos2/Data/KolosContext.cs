using Kolos2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Data;

public class KolosContext : DbContext
{
    public KolosContext(DbContextOptions<KolosContext> options) : base(options)
    {
    }
    
    // Przykład:
    // public DbSet<Prescription> Presciptions { get; set; }
    public DbSet<titles> Titles { get; set; }
    public DbSet<character_titles> CharacterTitles { get; set; }
    public DbSet<characters> Characters { get; set; }
    public DbSet<backpacks> Backpacks { get; set; }
    public DbSet<itmes> Items { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Przykład dwóch primary key
        // modelBuilder.Entity<Prescription_Medicament>()
        //     .HasKey(pm => new { pm.IdMedicament, pm.IdPrescription });

        modelBuilder.Entity<backpacks>()
            .HasKey(pm => new { pm.CharacterId, pm.ItemId });

        modelBuilder.Entity<character_titles>()
            .HasKey(pm => new { pm.CharacterId, pm.TitleId });

        // Przykład
        // modelBuilder.Entity<Prescription>()
        //     .HasOne(p => p.Doctor)
        //     .WithMany(d => d.Presciption)
        //     .HasForeignKey(p => p.IdDoctor);

        modelBuilder.Entity<backpacks>()
            .HasOne(i => i.Item)
            .WithMany(b => b.Backpacks)
            .HasForeignKey(i => i.ItemId);
        
        modelBuilder.Entity<backpacks>()
            .HasOne(i => i.Character)
            .WithMany(b => b.Backpacks)
            .HasForeignKey(i => i.CharacterId);
        
        modelBuilder.Entity<character_titles>()
            .HasOne(i => i.Character)
            .WithMany(c => c.CharacterTitles)
            .HasForeignKey(i => i.CharacterId);
        
        modelBuilder.Entity<character_titles>()
            .HasOne(i => i.Title)
            .WithMany(c => c.CharacterTitles)
            .HasForeignKey(i => i.TitleId);

    }
}