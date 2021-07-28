using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Uni.Notepad.EntityFrameworkCore
{
    public static class NotepadDbContextModelCreatingExtensions
    {
        public static void ConfigureNotepad(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

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