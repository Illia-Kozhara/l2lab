using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace L2Lab.Controllers
{
    public abstract class L2LabControllerBase: AbpController
    {
        protected L2LabControllerBase()
        {
            LocalizationSourceName = L2LabConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
