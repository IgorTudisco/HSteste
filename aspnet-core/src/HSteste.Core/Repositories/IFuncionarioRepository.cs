using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using HSteste.Core.Models;

namespace HSteste.Core.Repositories
{
  public interface IFuncionarioRepository : IRepository<Funcionario>
  {
  }
}