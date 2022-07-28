namespace MovisisTecnologia.Domain.Models;
public class Cidade : BaseModel
{
    public string UF { get; set; }
    public List<Cliente> Clientes { get; set; }

}