using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Uni.Notepad.Data
{
    /* This is used if database provider does't define
     * INotepadDbSchemaMigrator implementation.
     */
    public class NullNotepadDbSchemaMigrator : INotepadDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}