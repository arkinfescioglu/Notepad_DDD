using Microsoft.EntityFrameworkCore;
using Uni.Notepad.Cities;
using Uni.Notepad.EntityFrameworkCore.Seeders;
using Uni.Notepad.NoteCategories;
using Uni.Notepad.Notes;
using Volo.Abp;

namespace Uni.Notepad.EntityFrameworkCore
{
    public static class NotepadDbContextModelCreatingExtensions
    {
        public static void ConfigureNotepad(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<City>(b =>
            {
                b.ToTable("Cities");
                b.HasData(CitySeeder.Run());
            });

            builder.Entity<NoteCategory>(b =>
            {
                b.ToTable("NoteCategories");
                b.HasData(NoteCategorySeeder.Run());
            });

            builder.Entity<Note>(b =>
            {
                b.ToTable("Notes");
            });
            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(NotepadConsts.DbTablePrefix + "YourEntities", NotepadConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}