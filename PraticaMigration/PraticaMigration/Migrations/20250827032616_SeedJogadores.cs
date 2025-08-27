using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraticaMigration.Migrations
{
    /// <inheritdoc />
    public partial class SeedJogadores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql(@"
                INSERT INTO Jogadores(JogadorId, Nome, NumeroCamisa, Valor, Idade, Descricao, PosicaoId) VALUES
                (1, 'Neymar', 10, 120000000, 31, 'Craque', 1),
                (2, 'Casemiro', 5, 70000000, 31, 'Meia defensivo', 2),
                (3, 'Thiago Silva', 3, 20000000, 38, 'Zagueiro Forte', 3),
                (4, 'Alisson', 1, 80000000, 30, 'Goleiro titular', 4);
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Jogadores");
        }
    }
}
