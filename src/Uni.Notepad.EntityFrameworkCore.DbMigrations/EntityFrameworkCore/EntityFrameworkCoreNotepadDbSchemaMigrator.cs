using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Uni.Notepad.Data;
using Volo.Abp.DependencyInjection;

namespace Uni.Notepad.EntityFrameworkCore
{
    public class EntityFrameworkCoreNotepadDbSchemaMigrator
        : INotepadDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreNotepadDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the NotepadMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<NotepadMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}