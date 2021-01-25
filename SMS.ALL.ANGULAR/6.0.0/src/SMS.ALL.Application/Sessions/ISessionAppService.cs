using System.Threading.Tasks;
using Abp.Application.Services;
using SMS.ALL.Sessions.Dto;

namespace SMS.ALL.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
