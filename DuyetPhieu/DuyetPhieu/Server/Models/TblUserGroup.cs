using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblUserGroup
    {
        public string GroupId { get; set; }
        public string UserId { get; set; }

        public virtual TblGroup Group { get; set; }
        public virtual TblUser User { get; set; }
    }
}
