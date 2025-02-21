using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using HSteste.Application.Services.Dto;
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
    public Task<CreateFuncionarioDto> PostFuncionario([FromBody] CreateFuncionarioDto createFuncionarioDto);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public Task<IActionResult> GetAllFuncionarios();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public Task<IActionResult> GetFuncionarioById([FromQuery] int id);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="updateFuncionarioDto"></param>
    /// <returns></returns>
    [HttpPut]
    public Task<IActionResult> PutFuncionario([FromBody] UpdateFuncionarioDto updateFuncionarioDto);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public Task<IActionResult> DeleteFuncionario([FromQuery] int id);

  }
}