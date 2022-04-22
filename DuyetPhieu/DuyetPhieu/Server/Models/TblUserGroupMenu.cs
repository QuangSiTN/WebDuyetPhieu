using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblUserGroupMenu
    {
        public Guid Stt { get; set; }
        public string GroupId { get; set; }
        public string MenuId { get; set; }
        public int? Status { get; set; }

        public virtual TblGroup Group { get; set; }
        public virtual TblMenuForm Menu { get; set; }
    }
}
