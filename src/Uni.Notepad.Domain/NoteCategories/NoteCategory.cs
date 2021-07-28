using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Uni.Notepad.Notes;
using Volo.Abp.Domain.Entities.Auditing;

namespace Uni.Notepad.NoteCategories
{
    public class NoteCategory: AuditedAggregateRoot<Guid>
    {
        #region Properties

        [MaxLength(NoteCategoryLength.MaxTitle)]
        public string NoteCategoryTitle       { get; set; }
        
        [MaxLength(NoteCategoryLength.MaxDescription)]
        public string NoteCategoryDescription { get; set; }
        
        #endregion

        #region Relations

        //Relation ismi verdim çünkü EfContext sorun çıkartıyor
        public List<Note> NoteRelation { get; set; }

        #endregion
    }
}