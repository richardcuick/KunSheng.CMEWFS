using Kunsheng.CMEWFS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Kunsheng.CMEWFS.Permissions;

public class CMEWFSPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CMEWFSPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CMEWFSPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CMEWFSResource>(name);
    }
}
