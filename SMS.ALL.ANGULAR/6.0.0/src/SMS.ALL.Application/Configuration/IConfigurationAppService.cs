using System.Threading.Tasks;
using SMS.ALL.Configuration.Dto;

namespace SMS.ALL.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
