using AutoMapper;
using MovisisTecnologia.Domain.Dtos.Cliente;
using MovisisTecnologia.Domain.Interfaces.Repository;
using MovisisTecnologia.Domain.Interfaces.Services;
using MovisisTecnologia.Domain.Models;
using MovisisTecnologia.Domain.ViewModels;

namespace MovisisTecnologia.Service.Services;
public class ClienteService : IClienteService
{
    private IClienteRepository _repository;
    private IMapper _mapper;
    public ClienteService(IClienteRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<bool> Delete(int id)
    {
        var clienteDb = await this.GetById(id);
        if(clienteDb == null)
            return false;

        await _repository.DeleteAsync(id);
        return true;

    }

    public async Task<Cliente> GetById(int id)
    {
        return await _repository.SelectByIdAsync(id);
    }

    public async Task<List<ClienteViewModel>> GetByName(string cliente)
    {
        var result = await _repository.SelectByNameAsync(cliente);
        return _mapper.Map<List<ClienteViewModel>>(result);
    }

    public async Task<bool> Post(PostClienteDto item)
    {
        var cliente = _mapper.Map<Cliente>(item);
        var result = await _repository.InsertAsync(cliente);

        if(result == null)
            return false;

        return true;
    }

    public async Task<bool> Put(PutClienteDto item)
    {
        var cliente = _mapper.Map<Cliente>(item);
        if(cliente.Id == 0)
            return false;

        var result = await this.GetById(cliente.Id);
        if(!string.IsNullOrEmpty(cliente.Nome)){
            result.Nome = cliente.Nome;
        }

        if(!string.IsNullOrEmpty(cliente.Telefone)){
            result.Telefone = cliente.Telefone;
        }

        if(cliente.CidadeId != null && cliente.CidadeId > 0){
            result.CidadeId = cliente.CidadeId;
        }

        var resultUpdate = await _repository.UpdateAsync(result);

        if(resultUpdate == null)
            return false;

        return true;

    }
}