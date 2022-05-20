using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ReplaceTenantComponent;

[Dependency(ReplaceServices = true)]
public class ReplaceTenantComponentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ReplaceTenantComponent";
}
