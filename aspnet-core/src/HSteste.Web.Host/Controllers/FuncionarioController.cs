using HSteste.Controllers;
using HSteste.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HSteste.Application.Services.Dto;
using Abp.Application.Services.Dto;
using HSteste.Application.Services;

namespace HSteste.Web.Host.Controllers
{
  public class FuncionarioController : HStesteControllerBase
  {
    private readonly IFuncionarioService _funcionarioAppService;

    public FuncionarioController(IFuncionarioService funcionarioService)
    {
      _funcionarioAppService = funcionarioService;
    }

    [HttpPost]
    public async Task Create([FromBody] CreateFuncionarioDto input)
    {
      await _funcionarioAppService.CreateAsync(input);
    }

    [HttpPut]
    public async Task Update([FromBody] UpdateFuncionarioDto input)
    {
      await _funcionarioAppService.UpdateAsync(input);
    }

    [HttpDelete]
    public async Task Delete([FromBody] DeleteFuncionarioDto input)
    {
      await _funcionarioAppService.DeleteAsync(input);
    }

    [HttpGet]
    public async Task<ListResultDto<GetFuncionarioDto>> GetAll()
    {
      return await _funcionarioAppService.GetAllAsync();
    }

    [HttpGet]
    public async Task<GetFuncionarioDto> Get([FromBody] GetFuncionarioDto input)
    {
      return await _funcionarioAppService.GetAsync(input);
    }
  }
}