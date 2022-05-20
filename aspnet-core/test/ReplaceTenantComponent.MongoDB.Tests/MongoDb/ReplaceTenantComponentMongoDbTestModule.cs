using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace ReplaceTenantComponent.MongoDB;

[DependsOn(
    typeof(ReplaceTenantComponentTestBaseModule),
    typeof(ReplaceTenantComponentMongoDbModule)
    )]
public class ReplaceTenantComponentMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var stringArray = ReplaceTenantComponentMongoDbFixture.ConnectionString.Split('?');
        var connectionString = stringArray[0].EnsureEndsWith('/') +
                                   "Db_" +
                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = connectionString;
        });
    }
}
