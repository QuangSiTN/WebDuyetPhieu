using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblMenuForm
    {
        public TblMenuForm()
        {
            TblUserGroupMenus = new HashSet<TblUserGroupMenu>();
        }

        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string Tag { get; set; }
        public int? Status { get; set; }
        public int? LevelNumber { get; set; }

        public virtual ICollection<TblUserGroupMenu> TblUserGroupMenus { get; set; }
    }
}
