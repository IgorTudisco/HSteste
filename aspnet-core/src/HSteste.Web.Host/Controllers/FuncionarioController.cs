using HSteste.Controllers;
using HSteste.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HSteste.Application.Services.Dto;
using Abp.Application.Services.Dto;

namespace HSteste.Web.Host.Controllers
{
  /// <summary>
  /// Extends the HStesteControllerBase class to provide CRUD operations for the Funcionario entity.
  /// </summary>
  public class FuncionarioController : HStesteControllerBase
  {
    private readonly IFuncionarioService _funcionarioAppService;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="funcionarioService"></param>
    public FuncionarioController(IFuncionarioService funcionarioService)
    {
      _funcionarioAppService = funcionarioService;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task Create([FromBody] CreateFuncionarioDto input)
    {
      await _funcionarioAppService.CreateAsync(input);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPut]
    public async Task Update([FromBody] UpdateFuncionarioDto input)
    {
      await _funcionarioAppService.UpdateAsync(input);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpDelete]
    public async Task Delete([FromBody] DeleteFuncionarioDto input)
    {
      await _funcionarioAppService.DeleteAsync(input);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ListResultDto<GetFuncionarioDto>> GetAll()
    {
      return await _funcionarioAppService.GetAllAsync();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet]
    public async Task<GetFuncionarioDto> Get([FromBody] GetFuncionarioDto input)
    {
      return await _funcionarioAppService.GetAsync(input);
    }
  }
}