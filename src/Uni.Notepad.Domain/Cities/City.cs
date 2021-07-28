using System;
using System.Collections.Generic;
using Uni.Notepad.Users;
using Volo.Abp.Domain.Entities.Auditing;

namespace Uni.Notepad.Cities
{
    public class City: AuditedAggregateRoot<Guid>
    {
        #region Properties

        public string CityName { get; set; }
        
        #endregion

        #region Relation Ships

        public List<AppUser> UserRelation { get; set; }

        #endregion
    }
}