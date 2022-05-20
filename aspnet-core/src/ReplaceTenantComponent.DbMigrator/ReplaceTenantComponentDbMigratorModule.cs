using ReplaceTenantComponent.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ReplaceTenantComponent.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ReplaceTenantComponentMongoDbModule),
    typeof(ReplaceTenantComponentApplicationContractsModule)
    )]
public class ReplaceTenantComponentDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
