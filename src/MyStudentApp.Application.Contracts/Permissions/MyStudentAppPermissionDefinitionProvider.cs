using MyStudentApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyStudentApp.Permissions;

public class MyStudentAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MyStudentAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MyStudentAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MyStudentAppResource>(name);
    }
}
