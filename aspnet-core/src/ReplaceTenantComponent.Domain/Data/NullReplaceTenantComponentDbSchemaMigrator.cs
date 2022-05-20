using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ReplaceTenantComponent.Data;

/* This is used if database provider does't define
 * IReplaceTenantComponentDbSchemaMigrator implementation.
 */
public class NullReplaceTenantComponentDbSchemaMigrator : IReplaceTenantComponentDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
