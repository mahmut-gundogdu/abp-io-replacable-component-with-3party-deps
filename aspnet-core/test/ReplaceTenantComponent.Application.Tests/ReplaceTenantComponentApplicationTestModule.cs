using Volo.Abp.Modularity;

namespace ReplaceTenantComponent;

[DependsOn(
    typeof(ReplaceTenantComponentApplicationModule),
    typeof(ReplaceTenantComponentDomainTestModule)
    )]
public class ReplaceTenantComponentApplicationTestModule : AbpModule
{

}
