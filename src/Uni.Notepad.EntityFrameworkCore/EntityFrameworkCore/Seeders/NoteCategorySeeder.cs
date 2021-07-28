using Uni.Notepad.NoteCategories;

namespace Uni.Notepad.EntityFrameworkCore.Seeders
{
    public static class NoteCategorySeeder
    {
        public static NoteCategory[] Run()
        {
            return new NoteCategory[]
            {
                new NoteCategory
                {
                    NoteCategoryTitle = "Önemli",
                    NoteCategoryDescription = "Önemli Notlar"
                }, 
                new NoteCategory
                {
                    NoteCategoryTitle       = "Yazılım",
                    NoteCategoryDescription = "Yazılımla Alakalı Notlar"
                },
                new NoteCategory
                {
                    NoteCategoryTitle       = "İş",
                    NoteCategoryDescription = "İş İle İlgili Notlar"
                },
            };
        }
    }
}