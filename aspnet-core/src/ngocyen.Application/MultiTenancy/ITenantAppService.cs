using Abp.Application.Services;
using ngocyen.MultiTenancy.Dto;

namespace ngocyen.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

