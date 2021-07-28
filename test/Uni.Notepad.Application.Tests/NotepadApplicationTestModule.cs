using Volo.Abp.Modularity;

namespace Uni.Notepad
{
    [DependsOn(
        typeof(NotepadApplicationModule),
        typeof(NotepadDomainTestModule)
        )]
    public class NotepadApplicationTestModule : AbpModule
    {

    }
}