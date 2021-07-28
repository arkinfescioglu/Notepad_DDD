using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Uni.Notepad.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class NotepadMigrationsDbContextFactory : IDesignTimeDbContextFactory<NotepadMigrationsDbContext>
    {
        public NotepadMigrationsDbContext CreateDbContext(string[] args)
        {
            NotepadEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<NotepadMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new NotepadMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Uni.Notepad.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
