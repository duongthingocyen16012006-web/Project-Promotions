using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ngocyen.Controllers
{
    public abstract class ngocyenControllerBase: AbpController
    {
        protected ngocyenControllerBase()
        {
            LocalizationSourceName = ngocyenConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
