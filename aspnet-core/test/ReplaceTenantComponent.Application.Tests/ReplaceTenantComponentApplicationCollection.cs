using ReplaceTenantComponent.MongoDB;
using Xunit;

namespace ReplaceTenantComponent;

[CollectionDefinition(ReplaceTenantComponentTestConsts.CollectionDefinitionName)]
public class ReplaceTenantComponentApplicationCollection : ReplaceTenantComponentMongoDbCollectionFixtureBase
{

}
