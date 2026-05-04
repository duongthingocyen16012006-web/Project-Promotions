using System.Threading.Tasks;
using Abp.Application.Services;
using ngocyen.Sessions.Dto;

namespace ngocyen.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
