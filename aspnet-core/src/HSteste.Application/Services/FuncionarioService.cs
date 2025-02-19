using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using HSteste.Application.Services.Dto;
using HSteste.Core.Models;

namespace HSteste.Application.Services
{
  /// <summary>
  /// Extends the IApplicationService interface to provide CRUD operations for the Funcionario entity.
  /// </summary>
  public class FuncionarioService : ApplicationService, IFuncionarioService
  {
    private readonly IRepository<Funcionario> _funcionarioRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="funcionarioRepository"></param>
    /// <param name="mapper"></param>
    public FuncionarioService(IRepository<Funcionario> funcionarioRepository, IMapper mapper)
    {
      _funcionarioRepository = funcionarioRepository;
      _mapper = mapper;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<List<GetFuncionarioDto>> GetFuncionarios()
    {
      var funcionarios = await _funcionarioRepository.GetAllListAsync();
      return _mapper.Map<List<GetFuncionarioDto>>(funcionarios);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<GetFuncionarioDto> GetFuncionarioById(int id)
    {
      var funcionario = await _funcionarioRepository.GetAsync(id);
      return _mapper.Map<GetFuncionarioDto>(funcionario);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<GetFuncionarioDto> CreateFuncionario(CreateFuncionarioDto input)
    {
      var funcionario = _mapper.Map<Funcionario>(input);
      await _funcionarioRepository.InsertAsync(funcionario);
      return _mapper.Map<GetFuncionarioDto>(funcionario);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public async Task<GetFuncionarioDto> UpdateFuncionario(UpdateFuncionarioDto input)
    {
      var funcionario = await _funcionarioRepository.GetAsync(input.Id);
      _mapper.Map(input, funcionario);
      await _funcionarioRepository.UpdateAsync(funcionario);
      return _mapper.Map<GetFuncionarioDto>(funcionario);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task DeleteFuncionario(int id)
    {
      await _funcionarioRepository.DeleteAsync(id);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public Task CreateAsync(CreateFuncionarioDto input)
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public Task UpdateAsync(UpdateFuncionarioDto input)
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public Task DeleteAsync(DeleteFuncionarioDto input)
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public Task<GetFuncionarioDto> GetAsync(GetFuncionarioDto input)
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public Task<ListResultDto<GetFuncionarioDto>> GetAllAsync()
    {
      throw new System.NotImplementedException();
    }
  }
}