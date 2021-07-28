using Volo.Abp.Settings;

namespace Uni.Notepad.Settings
{
    public class NotepadSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(NotepadSettings.MySetting1));
        }
    }
}
