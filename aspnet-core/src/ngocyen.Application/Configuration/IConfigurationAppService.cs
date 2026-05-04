using System.Threading.Tasks;
using ngocyen.Configuration.Dto;

namespace ngocyen.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
