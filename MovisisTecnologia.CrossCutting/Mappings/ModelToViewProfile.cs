using AutoMapper;
using MovisisTecnologia.Domain.Dtos.Cidade;
using MovisisTecnologia.Domain.Dtos.Cliente;
using MovisisTecnologia.Domain.Models;
using MovisisTecnologia.Domain.ViewModels;

namespace MovisisTecnologia.CrossCutting.Mappings;
public class ModelToViewProfile : Profile
{
    public ModelToViewProfile()
    {
        CreateMap<Cliente, ClienteViewModel>()
            .ReverseMap();
        CreateMap<Cliente, PostClienteDto>()
            .ReverseMap();
        CreateMap<Cliente, PutClienteDto>()
            .ReverseMap();
        CreateMap<Cliente, ResultClienteDto>()
            .ReverseMap();

        CreateMap<Cidade, CidadeViewModel>()
            .ReverseMap();
        CreateMap<Cidade, PostCidadeDto>()
            .ReverseMap();
        CreateMap<Cidade, PutCidadeDto>()
            .ReverseMap();
        CreateMap<Cidade, ResultCidadeDto>()
            .ReverseMap();
    }
}