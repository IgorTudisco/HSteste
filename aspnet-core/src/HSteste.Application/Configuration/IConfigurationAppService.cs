using HSteste.Configuration.Dto;
using System.Threading.Tasks;

namespace HSteste.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
