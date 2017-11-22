using System.Threading.Tasks;
using Abp.Application.Services;
using Trip.Sessions.Dto;

namespace Trip.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
