using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Trip.Configuration.Dto;

namespace Trip.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TripAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
