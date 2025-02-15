using Abp.Application.Services;
using HSteste.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace HSteste.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
