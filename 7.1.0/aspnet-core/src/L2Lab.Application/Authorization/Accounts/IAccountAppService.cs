using System.Threading.Tasks;
using Abp.Application.Services;
using L2Lab.Authorization.Accounts.Dto;

namespace L2Lab.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
