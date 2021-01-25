using Abp.Application.Services;
using SMS.ALL.MultiTenancy.Dto;

namespace SMS.ALL.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

