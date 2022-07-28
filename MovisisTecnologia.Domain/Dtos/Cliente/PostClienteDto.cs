using System.ComponentModel.DataAnnotations;
using MovisisTecnologia.Domain.Dtos.Cidade;

namespace MovisisTecnologia.Domain.Dtos.Cliente;
public class PostClienteDto
{
    [Required]
    public string Nome { get; set; }
    [Required]
    public string Apelido { get; set; }
    [Required]
    [RegularExpression(@"^\([0-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$")]
    public string Telefone { get; set; }
    [Required]
    public DateTime DataNascimento { get; set; }
    public int? CidadeId { get; set; }
}