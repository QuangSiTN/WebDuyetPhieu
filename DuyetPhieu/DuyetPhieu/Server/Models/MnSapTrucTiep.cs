using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnSapTrucTiep
    {
        public string SiteId { get; set; }
        public string SiteIdLayHang { get; set; }
        public bool? Active { get; set; }
        public string Note { get; set; }
    }
}
