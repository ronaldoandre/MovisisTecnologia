using System.ComponentModel.DataAnnotations;

namespace MovisisTecnologia.Domain.Models;
public class BaseModel
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
}