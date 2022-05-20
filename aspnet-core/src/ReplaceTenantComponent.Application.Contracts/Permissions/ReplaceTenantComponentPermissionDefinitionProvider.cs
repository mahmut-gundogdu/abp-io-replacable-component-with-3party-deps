using ReplaceTenantComponent.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ReplaceTenantComponent.Permissions;

public class ReplaceTenantComponentPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ReplaceTenantComponentPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ReplaceTenantComponentPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ReplaceTenantComponentResource>(name);
    }
}
