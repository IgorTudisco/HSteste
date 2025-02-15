using Abp.Application.Services;
using HSteste.MultiTenancy.Dto;

namespace HSteste.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

