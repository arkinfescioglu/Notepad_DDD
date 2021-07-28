using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Uni.Notepad.NoteCategories;
using Uni.Notepad.Users;
using Volo.Abp.Domain.Entities;


namespace Uni.Notepad.Notes
{
    [Table("Notes", Schema = "dbo")]
    public class Note: Entity<Guid>
    {
        #region Properties

        [MaxLength(NoteLength.MaxTitle)]
        public string NoteTitle { get; set; }
        
        public string NoteContent { get; set; }

        public Guid UserId { get; set; }
        
        public Guid CategoryId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        
        #endregion

        #region Relations

        [ForeignKey("UserId")] public AppUser User { get; set; }
        [ForeignKey("CategoryId")] public NoteCategory Category { get; set; }

        #endregion
    }
}