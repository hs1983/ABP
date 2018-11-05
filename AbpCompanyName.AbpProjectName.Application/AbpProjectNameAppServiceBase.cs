using Abp.Application.Services;
using Abp.IdentityFramework;
using Microsoft.AspNet.Identity;

namespace AbpCompanyName.AbpProjectName
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AbpProjectNameAppServiceBase : ApplicationService
    {
        protected AbpProjectNameAppServiceBase()
        {
            LocalizationSourceName = AbpProjectNameConsts.LocalizationSourceName;
        }


        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}