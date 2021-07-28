using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Uni.Notepad.Notes;
using Volo.Abp.Domain.Entities;

namespace Uni.Notepad.NoteCategories
{
    [Table("NoteCategories", Schema = "dbo")]
    public class NoteCategory: Entity<Guid>
    {
        #region Properties

        [MaxLength(NoteCategoryLength.MaxTitle)]
        public string NoteCategoryTitle       { get; set; }
        
        [MaxLength(NoteCategoryLength.MaxDescription)]
        public string NoteCategoryDescription { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        
        #endregion

        #region Relations

        //Relation ismi verdim çünkü EfContext sorun çıkartıyor
        public List<Note> NoteRelation { get; set; }

        #endregion
    }
}