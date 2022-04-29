using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using L2Lab.Configuration.Dto;

namespace L2Lab.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : L2LabAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
