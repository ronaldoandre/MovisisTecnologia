using System.ComponentModel.DataAnnotations;

namespace MovisisTecnologia.Domain.Dtos.Cidade;
public class PostCidadeDto
{
    [Required]
    public string Nome { get; set; }
    [Required]
    [StringLength(2)]
    public string UF { get; set; }

}