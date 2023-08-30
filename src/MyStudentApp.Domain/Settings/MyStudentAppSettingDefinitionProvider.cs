using Volo.Abp.Settings;

namespace MyStudentApp.Settings;

public class MyStudentAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MyStudentAppSettings.MySetting1));
    }
}
