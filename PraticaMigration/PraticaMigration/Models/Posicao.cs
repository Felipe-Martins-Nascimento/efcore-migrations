namespace PraticaMigration.Models;

public class Posicao
{
    public int PosicaoId { get; set; }
    public string PosicaoNome { get; set; } = string.Empty;
    public ICollection<Jogador>? Jogadores { get; set; } 
}
