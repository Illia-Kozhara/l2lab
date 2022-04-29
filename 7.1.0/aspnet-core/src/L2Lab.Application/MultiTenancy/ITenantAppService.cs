using Abp.Application.Services;
using L2Lab.MultiTenancy.Dto;

namespace L2Lab.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

