using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HSteste.Application.Services.Dto;

namespace HSteste.Application.Services
{
  public interface IFuncionarioService : IApplicationService
  {
    Task<List<GetFuncionarioDto>> GetFuncionarios();
    Task<GetFuncionarioDto> GetFuncionarioById(int id);
    Task<GetFuncionarioDto> CreateFuncionario(CreateFuncionarioDto input);
    Task<GetFuncionarioDto> UpdateFuncionario(UpdateFuncionarioDto input);
    Task DeleteFuncionario(int id);
    Task CreateAsync(CreateFuncionarioDto input);
    Task UpdateAsync(UpdateFuncionarioDto input);
    Task DeleteAsync(DeleteFuncionarioDto input);
    Task<GetFuncionarioDto> GetAsync(GetFuncionarioDto input);
    Task<ListResultDto<GetFuncionarioDto>> GetAllAsync();
  }
}