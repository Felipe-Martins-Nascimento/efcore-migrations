using Microsoft.EntityFrameworkCore;
using PraticaMigration.Models;

namespace PraticaMigration.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Posicao> Posicoes { get; set; }
    public DbSet<Jogador> Jogadores { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Posicao>()
            .HasKey(p => p.PosicaoId);

        mb.Entity<Posicao>()
            .Property(p => p.PosicaoNome)
            .HasMaxLength(100)
            .IsRequired();

        mb.Entity<Posicao>()
            .HasMany(p => p.Jogadores)
            .WithOne(j => j.Posicao)
            .HasForeignKey(j => j.PosicaoId)
            .OnDelete(DeleteBehavior.Cascade);

        mb.Entity<Jogador>()
            .Property(j => j.Nome)
            .HasMaxLength(100)
            .IsRequired();

        mb.Entity<Jogador>()
            .Property(j => j.Descricao)
            .HasMaxLength(255);

        mb.Entity<Jogador>()
            .Property(j => j.Foto)
            .HasMaxLength(255);

        mb.Entity<Jogador>()
            .Property(j => j.Valor)
            .HasPrecision(12, 2);

        mb.Entity<Posicao>().HasData(
           new Posicao { PosicaoId = 1, PosicaoNome = "Atacante" },
           new Posicao { PosicaoId = 2, PosicaoNome = "Meia" },
           new Posicao { PosicaoId = 3, PosicaoNome = "Zagueiro" },
           new Posicao { PosicaoId = 4, PosicaoNome = "Goleiro" }
       );
    }
}
