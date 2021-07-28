using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Uni.Notepad.Users;
using Volo.Abp.Domain.Entities;

namespace Uni.Notepad.Cities
{
    [Table("Cities", Schema = "dbo")]
    public class City: Entity<Guid>
    {
        #region Properties

        public string CityName { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        #endregion

        #region Relation Ships

        public List<AppUser> UserRelation { get; set; }

        #endregion
    }
}