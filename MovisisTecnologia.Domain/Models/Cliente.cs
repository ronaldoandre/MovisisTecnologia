namespace MovisisTecnologia.Domain.Models;
public class Cliente : BaseModel
{
    public string Apelido { get; set; }
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
    public int? CidadeId { get; set; }
    public Cidade Cidade { get; set; }

}