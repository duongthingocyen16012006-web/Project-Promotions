using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ngocyen.Configuration.Dto;

namespace ngocyen.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ngocyenAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
