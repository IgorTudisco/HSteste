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
  public class FuncionarioService : ApplicationService, IFuncionarioService
  {
    private readonly IRepository<Funcionario> _funcionarioRepository;
    private readonly IMapper _mapper;

    public FuncionarioService(IRepository<Funcionario> funcionarioRepository, IMapper mapper)
    {
      _funcionarioRepository = funcionarioRepository;
      _mapper = mapper;
    }

    public async Task<List<GetFuncionarioDto>> GetFuncionarios()
    {
      var funcionarios = await _funcionarioRepository.GetAllListAsync();
      return _mapper.Map<List<GetFuncionarioDto>>(funcionarios);
    }

    public async Task<GetFuncionarioDto> GetFuncionarioById(int id)
    {
      var funcionario = await _funcionarioRepository.GetAsync(id);
      return _mapper.Map<GetFuncionarioDto>(funcionario);
    }

    public async Task<GetFuncionarioDto> CreateFuncionario(CreateFuncionarioDto input)
    {
      var funcionario = _mapper.Map<Funcionario>(input);
      await _funcionarioRepository.InsertAsync(funcionario);
      return _mapper.Map<GetFuncionarioDto>(funcionario);
    }

    public async Task<GetFuncionarioDto> UpdateFuncionario(UpdateFuncionarioDto input)
    {
      var funcionario = await _funcionarioRepository.GetAsync(input.Id);
      _mapper.Map(input, funcionario);
      await _funcionarioRepository.UpdateAsync(funcionario);
      return _mapper.Map<GetFuncionarioDto>(funcionario);
    }

    public async Task DeleteFuncionario(int id)
    {
      await _funcionarioRepository.DeleteAsync(id);
    }

    public Task CreateAsync(CreateFuncionarioDto input)
    {
      throw new System.NotImplementedException();
    }

    public Task UpdateAsync(UpdateFuncionarioDto input)
    {
      throw new System.NotImplementedException();
    }

    public Task DeleteAsync(DeleteFuncionarioDto input)
    {
      throw new System.NotImplementedException();
    }

    public Task<GetFuncionarioDto> GetAsync(GetFuncionarioDto input)
    {
      throw new System.NotImplementedException();
    }

    public Task<ListResultDto<GetFuncionarioDto>> GetAllAsync()
    {
      throw new System.NotImplementedException();
    }
  }
}