using System.Threading.Tasks;
using Abp.Application.Services;
using Trip.Authorization.Accounts.Dto;

namespace Trip.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
