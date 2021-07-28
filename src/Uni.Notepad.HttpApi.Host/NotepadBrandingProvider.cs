using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Uni.Notepad
{
    [Dependency(ReplaceServices = true)]
    public class NotepadBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Notepad";
    }
}
