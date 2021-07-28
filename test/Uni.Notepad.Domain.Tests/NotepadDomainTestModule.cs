using Uni.Notepad.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Uni.Notepad
{
    [DependsOn(
        typeof(NotepadEntityFrameworkCoreTestModule)
        )]
    public class NotepadDomainTestModule : AbpModule
    {

    }
}