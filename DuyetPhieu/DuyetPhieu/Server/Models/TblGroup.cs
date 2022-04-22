using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblGroup
    {
        public TblGroup()
        {
            TblUserGroupMenus = new HashSet<TblUserGroupMenu>();
            TblUserGroups = new HashSet<TblUserGroup>();
        }

        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public string Note { get; set; }
        public bool IsAdmin { get; set; }

        public virtual ICollection<TblUserGroupMenu> TblUserGroupMenus { get; set; }
        public virtual ICollection<TblUserGroup> TblUserGroups { get; set; }
    }
}
