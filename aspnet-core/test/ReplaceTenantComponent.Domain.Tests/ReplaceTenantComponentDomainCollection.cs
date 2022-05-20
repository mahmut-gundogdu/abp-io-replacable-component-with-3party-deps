using ReplaceTenantComponent.MongoDB;
using Xunit;

namespace ReplaceTenantComponent;

[CollectionDefinition(ReplaceTenantComponentTestConsts.CollectionDefinitionName)]
public class ReplaceTenantComponentDomainCollection : ReplaceTenantComponentMongoDbCollectionFixtureBase
{

}
