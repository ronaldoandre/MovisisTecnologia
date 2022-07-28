using System.ComponentModel.DataAnnotations;

namespace MovisisTecnologia.Domain.Dtos.Cidade;
public class PutCidadeDto
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }
}