using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnSapTrungGian
    {
        public string SiteId { get; set; }
        public string SiteIdTrungGian { get; set; }
        public bool? Active { get; set; }
        public string Note { get; set; }
    }
}
