using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblUserIsadmin
    {
        public string UserId { get; set; }
        public string SiteId { get; set; }
        public bool? Active { get; set; }
    }
}
