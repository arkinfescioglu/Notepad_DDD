using System.Threading.Tasks;

namespace Uni.Notepad.Data
{
    public interface INotepadDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
