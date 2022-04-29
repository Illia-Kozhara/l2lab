using System.Threading.Tasks;
using Abp.Application.Services;
using L2Lab.Sessions.Dto;

namespace L2Lab.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
