using Abp.Application.Services;
using HSteste.Sessions.Dto;
using System.Threading.Tasks;

namespace HSteste.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
