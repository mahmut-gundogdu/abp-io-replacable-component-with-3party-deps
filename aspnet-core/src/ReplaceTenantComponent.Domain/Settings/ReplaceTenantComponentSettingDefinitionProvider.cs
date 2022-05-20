using Volo.Abp.Settings;

namespace ReplaceTenantComponent.Settings;

public class ReplaceTenantComponentSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ReplaceTenantComponentSettings.MySetting1));
    }
}
