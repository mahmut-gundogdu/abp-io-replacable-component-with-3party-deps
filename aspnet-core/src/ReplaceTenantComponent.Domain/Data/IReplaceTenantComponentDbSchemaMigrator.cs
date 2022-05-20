using System.Threading.Tasks;

namespace ReplaceTenantComponent.Data;

public interface IReplaceTenantComponentDbSchemaMigrator
{
    Task MigrateAsync();
}
