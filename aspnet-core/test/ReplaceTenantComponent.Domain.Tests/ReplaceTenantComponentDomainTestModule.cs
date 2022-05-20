using ReplaceTenantComponent.MongoDB;
using Volo.Abp.Modularity;

namespace ReplaceTenantComponent;

[DependsOn(
    typeof(ReplaceTenantComponentMongoDbTestModule)
    )]
public class ReplaceTenantComponentDomainTestModule : AbpModule
{

}
