using Abp.Authorization;
using Abp.Runtime.Session;
using HSteste.Configuration.Dto;
using System.Threading.Tasks;

namespace HSteste.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : HStesteAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
