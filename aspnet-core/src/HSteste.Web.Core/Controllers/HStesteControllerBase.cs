using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HSteste.Controllers
{
    public abstract class HStesteControllerBase : AbpController
    {
        protected HStesteControllerBase()
        {
            LocalizationSourceName = HStesteConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
