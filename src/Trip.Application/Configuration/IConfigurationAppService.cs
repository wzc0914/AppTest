using System.Threading.Tasks;
using Abp.Application.Services;
using Trip.Configuration.Dto;

namespace Trip.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}