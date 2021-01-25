using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SMS.ALL.Configuration.Dto;

namespace SMS.ALL.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ALLAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
