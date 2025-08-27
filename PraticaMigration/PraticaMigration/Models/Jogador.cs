using System.ComponentModel.DataAnnotations;

namespace PraticaMigration.Models;

public class Jogador
{
    [Key]
    public int JogadorId { get; set; }  
    public int NumeroCamisa { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public string? Descricao { get; set; }
    public int Idade { get; set; }
    public string? Foto { get; set; }
    public int PosicaoId { get; set; }
    public Posicao Posicao { get; set; } = null!;
}
