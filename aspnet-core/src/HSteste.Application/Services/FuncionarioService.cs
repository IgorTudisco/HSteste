using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using HSteste.Application.Services.Dto;
using HSteste.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HSteste.Application.Services
{
  /// <summary>
  /// Extends the IApplicationService interface to provide CRUD operations for the Funcionario entity.
  /// </summary>
  public class FuncionarioService : ApplicationService, IFuncionarioService
  {
    private readonly IRepository<Funcionario> _funcionarioRepository;
    private readonly IMapper _mapper;

    public FuncionarioService(IRepository<Funcionario> funcionarioRepository, IMapper mapper)
    {
      _funcionarioRepository = funcionarioRepository;
      _mapper = mapper;
    }

    [HttpPost("api/funcionario/")]
    public async Task<IResult> PostFuncionarioAsync([FromBody] CreateFuncionarioDto createFuncionarioDto)
    {

      if (createFuncionarioDto == null) return Results.BadRequest();

      var funcionario = _mapper.Map<Funcionario>(createFuncionarioDto);
      await _funcionarioRepository.InsertAsync(funcionario);
      var funcionarioDto = _mapper.Map<GetFuncionarioDto>(funcionario);

      return Results.Ok(funcionarioDto);
    }

    [HttpGet("api/funcionario/{id}")]
    public async Task<IResult> GetFuncionarioByIdAsync([FromRoute] int id)
    {
      if (id <= 0) return Results.BadRequest();
      if (id == null) return Results.NotFound();

      var funcionario = _funcionarioRepository.Get(id);
      var funcionarioDto = _mapper.Map<GetFuncionarioDto>(funcionario);

      return Results.Ok(funcionario);
    }

    [HttpGet("api/funcionario/")]
    public async Task<IResult> GetAllFuncionariosAsync()
    {
      var funcionarios = _funcionarioRepository.GetAllList().ToList();
      var funcionarioDto = _mapper.Map<List<GetFuncionarioDto>>(funcionarios);
      return Results.Ok(funcionarioDto);
    }

    [HttpPut("api/funcionario/")]
    public async Task<IResult> PutFuncionarioAsync([FromBody] UpdateFuncionarioDto updateFuncionarioDto)
    {
      if (updateFuncionarioDto is null || updateFuncionarioDto.Id == null)
      {
        return Results.BadRequest();
      }

      var funcionario = _mapper.Map<Funcionario>(updateFuncionarioDto);
      funcionario = _funcionarioRepository.Update(funcionario);

      return Results.NoContent();
    }

    [HttpDelete("api/funcionario/{id}")]
    public async Task<IResult> DeleteFuncionarioAsync([FromRoute] int id)
    {
      if (id <= 0) return Results.BadRequest();
      if (id == null) return Results.NotFound();
      await _funcionarioRepository.DeleteAsync(id);
      return Results.NoContent();
    }

  }
}