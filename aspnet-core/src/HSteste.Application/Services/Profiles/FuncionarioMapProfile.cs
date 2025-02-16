using AutoMapper;
using HSteste.Application.Services.Dto;
using HSteste.Core.Models;

namespace HSteste.Application.Service.Profiles
{
  public class FuncionarioMapProfile : Profile
  {
    public FuncionarioMapProfile()
    {
      CreateMap<Funcionario, GetFuncionarioDto>();
      CreateMap<CreateFuncionarioDto, Funcionario>();
      CreateMap<UpdateFuncionarioDto, Funcionario>();
      CreateMap<DeleteFuncionarioDto, Funcionario>();
    }
  }
}