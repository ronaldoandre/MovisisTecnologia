using MovisisTecnologia.Domain.Dtos.Cliente;
using MovisisTecnologia.Domain.Models;
using MovisisTecnologia.Domain.ViewModels;

namespace MovisisTecnologia.Domain.Interfaces.Services;

public interface IClienteService
{
    Task<bool> Delete(int id);
    Task<Cliente> GetById(int id);
    Task<List<ClienteViewModel>> GetByName(string cliente);
    Task<bool> Post(PostClienteDto item);
    Task<bool> Put(PutClienteDto item);
}