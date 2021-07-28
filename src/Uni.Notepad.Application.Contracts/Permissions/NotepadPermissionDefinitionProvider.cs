using Uni.Notepad.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Uni.Notepad.Permissions
{
    public class NotepadPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(NotepadPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(NotepadPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<NotepadResource>(name);
        }
    }
}
