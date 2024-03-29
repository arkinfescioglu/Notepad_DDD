﻿using Microsoft.EntityFrameworkCore;
using Uni.Notepad.Cities;
using Uni.Notepad.EntityFrameworkCore.Seeders;
using Uni.Notepad.NoteCategories;
using Uni.Notepad.Notes;
using Uni.Notepad.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Uni.Notepad.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See NotepadMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class NotepadDbContext : AbpDbContext<NotepadDbContext>
    {
        public DbSet<AppUser> Users { get; set; }
        
        public DbSet<City> Cities { get; set; }

        public DbSet<NoteCategory> NoteCategories { get; set; }

        public DbSet<Note> Notes { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside NotepadDbContextModelCreatingExtensions.ConfigureNotepad
         */

        public NotepadDbContext(DbContextOptions<NotepadDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.Property(x => x.Password);
                b.Property(x => x.CityId);
                b.Property(x => x.CreatedDate);
                b.Property(x => x.ModifiedDate);
                b.ToTable("AbpUsers"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the NotepadEfCoreEntityExtensionMappings class
                 */
            });
            
            /* Configure your own tables/entities inside the ConfigureNotepad method */

            builder.ConfigureNotepad();
        }
    }
}
