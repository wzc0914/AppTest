using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Trip.MultiTenancy.Dto;

namespace Trip.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
