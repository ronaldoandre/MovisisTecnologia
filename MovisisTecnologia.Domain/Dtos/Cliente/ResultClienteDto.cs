using MovisisTecnologia.Domain.Dtos.Cidade;

namespace MovisisTecnologia.Domain.Dtos.Cliente;
public class ResultClienteDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }

}