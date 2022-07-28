using Microsoft.AspNetCore.Mvc;
using MovisisTecnologia.Domain.Dtos.Cliente;
using MovisisTecnologia.Domain.Interfaces.Services;
using MovisisTecnologia.Domain.Models;
using MovisisTecnologia.Domain.ViewModels;

namespace MovisisTecnologia.Api.Controllers;

[Route ("api/[controller]")]
[ApiController]
public class ClientesController : ControllerBase
{
    private readonly IClienteService _clienteService;
    public ClientesController(IClienteService cliente)
    {
        _clienteService = cliente;
    }

    [HttpDelete("{ClienteId}")]
    [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ResponseViewModel>> Delete([FromRoute] int ClienteId)
    {
        try
        {
            var result = await _clienteService.Delete(ClienteId);
            if(result == true){
                return Ok(
                    new ResponseViewModel(
                        1,
                        "Registros deletado com sucesso!",
                        null
                    )
                );
            }
            return BadRequest(
                new ResponseViewModel(0, "Não foi possivel deletar os registros!", null)
            );
        }
        catch (Exception ex) 
        {
            return BadRequest(
                new ResponseViewModel(0, "Ocorreu um erro ao obter os registros!", ex.Message)
            );
        }
    }

    [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status400BadRequest)]
    [HttpPut]
    public async Task<ActionResult<ResponseViewModel>> Put([FromBody] PutClienteDto cliente)
    {
        try
        {
            var result = await _clienteService.Put(cliente);
            if(result == true){
                return Ok(
                    new ResponseViewModel(
                        1,
                        "Registros atualizados com sucesso!",
                        ""
                    )
                );
            }else{
                return BadRequest(
                new ResponseViewModel(0, "Não foi possivel atualizar!", "")
            );
            }

        }
        catch (Exception ex)
        {
            return BadRequest(
                new ResponseViewModel(0, "Ocorreu um erro ao atualizar os registros!", ex.Message)
            );
        }
    }

    [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status400BadRequest)]
    [HttpPost]
    public async Task<ActionResult<ResponseViewModel>> Post([FromBody] PostClienteDto cliente)
    {
        try
        {
            var result = await _clienteService.Post(cliente);
            if(result == true){
                return Ok(
                    new ResponseViewModel(
                        1,
                        "Registro Inserido com sucesso!",
                        ""
                    )
                );
            }else{
                return BadRequest(
                new ResponseViewModel(0, "Não foi inserir registro!", "")
            );
            }

        }
        catch (Exception ex)
        {
            return BadRequest(
                new ResponseViewModel(0, "Ocorreu um erro ao inserir o registro!", ex.Message)
            );
        }
    }
    
    [ProducesResponseType(typeof(ResponseViewModel<List<ClienteViewModel>>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status400BadRequest)]
    [HttpGet("Nome/{nome}")]
    public async Task<ActionResult<ResponseViewModel>> GetNome([FromRoute]string nome)
    {
        try
        {
            if(nome == null)
                return BadRequest(
                new ResponseViewModel(
                    0,
                    "Preencha o campo Nome",
                    null)
                 );

            return Ok(
                new ResponseViewModel<List<ClienteViewModel>>(
                    1,
                    "Dados obtidos",
                    await _clienteService.GetByName(nome))
            );
        }
        catch (Exception ex)
        {
            return BadRequest(
                new ResponseViewModel(
                    0,
                    "Ocorreu um erro ao obter os dados",
                    ex.Message)
            );
        }
    }
}