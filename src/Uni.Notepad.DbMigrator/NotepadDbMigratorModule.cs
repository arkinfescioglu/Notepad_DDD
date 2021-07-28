using Uni.Notepad.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Uni.Notepad.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(NotepadEntityFrameworkCoreDbMigrationsModule),
        typeof(NotepadApplicationContractsModule)
        )]
    public class NotepadDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
