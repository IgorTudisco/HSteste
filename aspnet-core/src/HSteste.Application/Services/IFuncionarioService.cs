using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HSteste.Application.Services.Dto;

namespace HSteste.Application.Services
{
  /// <summary>
  /// Extends the IApplicationService interface to provide CRUD operations for the Funcionario entity.
  /// </summary>
  public interface IFuncionarioService : IApplicationService
  {
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<List<GetFuncionarioDto>> GetFuncionarios();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<GetFuncionarioDto> GetFuncionarioById(int id);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<GetFuncionarioDto> CreateFuncionario(CreateFuncionarioDto input);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<GetFuncionarioDto> UpdateFuncionario(UpdateFuncionarioDto input);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteFuncionario(int id);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task CreateAsync(CreateFuncionarioDto input);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task UpdateAsync(UpdateFuncionarioDto input);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task DeleteAsync(DeleteFuncionarioDto input);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<GetFuncionarioDto> GetAsync(GetFuncionarioDto input);
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<ListResultDto<GetFuncionarioDto>> GetAllAsync();
  }
}