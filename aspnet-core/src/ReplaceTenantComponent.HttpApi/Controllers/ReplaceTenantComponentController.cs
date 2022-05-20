using ReplaceTenantComponent.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ReplaceTenantComponent.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ReplaceTenantComponentController : AbpControllerBase
{
    protected ReplaceTenantComponentController()
    {
        LocalizationResource = typeof(ReplaceTenantComponentResource);
    }
}
