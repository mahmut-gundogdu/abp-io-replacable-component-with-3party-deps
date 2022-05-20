using System;
using System.Collections.Generic;
using System.Text;
using ReplaceTenantComponent.Localization;
using Volo.Abp.Application.Services;

namespace ReplaceTenantComponent;

/* Inherit your application services from this class.
 */
public abstract class ReplaceTenantComponentAppService : ApplicationService
{
    protected ReplaceTenantComponentAppService()
    {
        LocalizationResource = typeof(ReplaceTenantComponentResource);
    }
}
