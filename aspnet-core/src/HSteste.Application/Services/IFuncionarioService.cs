using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using HSteste.Application.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    /// <param name="createFuncionarioDto"></param>
    /// <returns></returns>
    [HttpPost]
    public Task<IResult> PostFuncionarioAsync([FromBody] CreateFuncionarioDto createFuncionarioDto);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public Task<IResult> GetFuncionarioByIdAsync([FromRoute] int? id);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public Task<IResult> GetAllFuncionariosAsync();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="updateFuncionarioDto"></param>
    /// <returns></returns>
    [HttpPut]
    public Task<IResult> PutFuncionarioAsync([FromBody] UpdateFuncionarioDto updateFuncionarioDto);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public Task<IResult> DeleteFuncionarioAsync([FromRoute] int? id);

  }
}