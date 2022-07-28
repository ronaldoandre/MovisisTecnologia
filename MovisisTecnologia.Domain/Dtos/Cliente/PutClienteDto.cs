using System.ComponentModel.DataAnnotations;
using MovisisTecnologia.Domain.Dtos.Cidade;

namespace MovisisTecnologia.Domain.Dtos.Cliente;
public class PutClienteDto
{
    [Required]
    public int Id { get; set; }
    public string Nome { get; set; } = null;
    [RegularExpression(@"^\([0-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$")]
    public string Telefone { get; set; } = null;
    public int? CidadeId { get; set; }
}