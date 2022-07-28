using AutoMapper;
using MovisisTecnologia.Domain.Dtos.Cidade;
using MovisisTecnologia.Domain.Interfaces.Repository;
using MovisisTecnologia.Domain.Interfaces.Services;
using MovisisTecnologia.Domain.Models;
using MovisisTecnologia.Domain.ViewModels;

namespace MovisisTecnologia.Service.Services;
public class CidadeService : ICidadeService
{
    private ICidadeRepository _repository;
    private IMapper _mapper;
    public CidadeService(ICidadeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<bool> Delete(int id)
    {
        var cidadeDb = await this.GetById(id);
        if(cidadeDb == null)
            return false;

        if(cidadeDb.Clientes.Count > 0){
            throw new Exception("Não é possivel deletar cidade com Clientes");
        }

        await _repository.DeleteAsync(id);
        return true;
    }

    public async Task<Cidade> GetById(int id)
    {
        return await _repository.SelectByIdAsync(id);
    }

    public async Task<List<CidadeViewModel>> GetByName(string name)
    {
        var result = await _repository.SelectByNameAsync(name);
        return _mapper.Map<List<CidadeViewModel>>(result);
    }

    public async Task<bool> Post(PostCidadeDto item)
    {
        var cidade = _mapper.Map<Cidade>(item);
        cidade.UF = cidade.UF.ToUpper();
        var result = await _repository.InsertAsync(cidade);

        if(result == null)
            return false;
            
        return true;
    }

    public async Task<bool> Put(PutCidadeDto item)
    {
        var cidade = _mapper.Map<Cidade>(item);
        if(cidade.Id == 0)
            return false;

        var result = await this.GetById(cidade.Id);
        if(!string.IsNullOrEmpty(cidade.Nome))
            result.Nome = cidade.Nome;

        var resultUpdate = await _repository.UpdateAsync(result);

        if(resultUpdate == null)
            return false;

        return true;
    }
}