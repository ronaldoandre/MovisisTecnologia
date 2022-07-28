using MovisisTecnologia.Domain.Dtos.Cidade;
using MovisisTecnologia.Domain.Models;
using MovisisTecnologia.Domain.ViewModels;

namespace MovisisTecnologia.Domain.Interfaces.Services;
public interface ICidadeService
{
    Task<bool> Post (PostCidadeDto item);
    Task<bool> Delete (int id);
    Task<Cidade> GetById (int id);
    Task<List<CidadeViewModel>> GetByName (string name);
    Task<bool> Put (PutCidadeDto item);
}