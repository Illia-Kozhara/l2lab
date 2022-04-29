using System.Threading.Tasks;
using L2Lab.Configuration.Dto;

namespace L2Lab.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
