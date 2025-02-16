using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using HSteste.Core.Models;

namespace HSteste.Core.Repositories
{
  public class FuncionarioRepository : IFuncionarioRepository
  {
    private readonly IRepository<Funcionario> _repository;
    public int Count()
    {
      return _repository.Count();
    }

    public int Count(Expression<Func<Funcionario, bool>> predicate)
    {
      return _repository.Count(predicate);
    }

    public Task<int> CountAsync()
    {
      return _repository.CountAsync();
    }

    public Task<int> CountAsync(Expression<Func<Funcionario, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public void Delete(Funcionario entity)
    {
      _repository.Delete(entity);
    }

    public void Delete(int id)
    {
      _repository.Delete(id);
    }

    public void Delete(Expression<Func<Funcionario, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public Task DeleteAsync(Funcionario entity)
    {
      throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task DeleteAsync(Expression<Func<Funcionario, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public Funcionario FirstOrDefault(int id)
    {
      return _repository.FirstOrDefault(id);
    }

    public Funcionario FirstOrDefault(Expression<Func<Funcionario, bool>> predicate)
    {
      return _repository.FirstOrDefault(predicate);
    }

    public Task<Funcionario> FirstOrDefaultAsync(int id)
    {
      return _repository.FirstOrDefaultAsync(id);
    }

    public Task<Funcionario> FirstOrDefaultAsync(Expression<Func<Funcionario, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public Funcionario Get(int id)
    {
      throw new NotImplementedException();
    }

    public IQueryable<Funcionario> GetAll()
    {
      throw new NotImplementedException();
    }

    public Task<IQueryable<Funcionario>> GetAllAsync()
    {
      throw new NotImplementedException();
    }

    public IQueryable<Funcionario> GetAllIncluding(params Expression<Func<Funcionario, object>>[] propertySelectors)
    {
      throw new NotImplementedException();
    }

    public Task<IQueryable<Funcionario>> GetAllIncludingAsync(params Expression<Func<Funcionario, object>>[] propertySelectors)
    {
      throw new NotImplementedException();
    }

    public List<Funcionario> GetAllList()
    {
      throw new NotImplementedException();
    }

    public List<Funcionario> GetAllList(Expression<Func<Funcionario, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public Task<List<Funcionario>> GetAllListAsync()
    {
      throw new NotImplementedException();
    }

    public Task<List<Funcionario>> GetAllListAsync(Expression<Func<Funcionario, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public IQueryable<Funcionario> GetAllReadonly()
    {
      throw new NotImplementedException();
    }

    public Task<IQueryable<Funcionario>> GetAllReadonlyAsync()
    {
      throw new NotImplementedException();
    }

    public IQueryable<Funcionario> GetAllReadonlyIncluding(params Expression<Func<Funcionario, object>>[] propertySelectors)
    {
      throw new NotImplementedException();
    }

    public Task<IQueryable<Funcionario>> GetAllReadonlyIncludingAsync(params Expression<Func<Funcionario, object>>[] propertySelectors)
    {
      throw new NotImplementedException();
    }

    public Task<Funcionario> GetAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Funcionario Insert(Funcionario entity)
    {
      throw new NotImplementedException();
    }

    public int InsertAndGetId(Funcionario entity)
    {
      throw new NotImplementedException();
    }

    public Task<int> InsertAndGetIdAsync(Funcionario entity)
    {
      throw new NotImplementedException();
    }

    public Task<Funcionario> InsertAsync(Funcionario entity)
    {
      throw new NotImplementedException();
    }

    public Funcionario InsertOrUpdate(Funcionario entity)
    {
      throw new NotImplementedException();
    }

    public int InsertOrUpdateAndGetId(Funcionario entity)
    {
      throw new NotImplementedException();
    }

    public Task<int> InsertOrUpdateAndGetIdAsync(Funcionario entity)
    {
      throw new NotImplementedException();
    }

    public Task<Funcionario> InsertOrUpdateAsync(Funcionario entity)
    {
      throw new NotImplementedException();
    }

    public Funcionario Load(int id)
    {
      throw new NotImplementedException();
    }

    public long LongCount()
    {
      throw new NotImplementedException();
    }

    public long LongCount(Expression<Func<Funcionario, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public Task<long> LongCountAsync()
    {
      throw new NotImplementedException();
    }

    public Task<long> LongCountAsync(Expression<Func<Funcionario, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public T Query<T>(Func<IQueryable<Funcionario>, T> queryMethod)
    {
      throw new NotImplementedException();
    }

    public Funcionario Single(Expression<Func<Funcionario, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public Task<Funcionario> SingleAsync(Expression<Func<Funcionario, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public Funcionario Update(Funcionario entity)
    {
      throw new NotImplementedException();
    }

    public Funcionario Update(int id, Action<Funcionario> updateAction)
    {
      throw new NotImplementedException();
    }

    public Task<Funcionario> UpdateAsync(Funcionario entity)
    {
      throw new NotImplementedException();
    }

    public Task<Funcionario> UpdateAsync(int id, Func<Funcionario, Task> updateAction)
    {
      throw new NotImplementedException();
    }
  }
}