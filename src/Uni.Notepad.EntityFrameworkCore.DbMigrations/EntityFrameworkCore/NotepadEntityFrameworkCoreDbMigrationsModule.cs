using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Uni.Notepad.EntityFrameworkCore
{
    [DependsOn(
        typeof(NotepadEntityFrameworkCoreModule)
        )]
    public class NotepadEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<NotepadMigrationsDbContext>();
        }
    }
}
