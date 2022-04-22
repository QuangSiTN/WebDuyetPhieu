using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnChuyenChiNhanhLayHang
    {
        public string SiteIdPos { get; set; }
        public string SiteIdDelivery { get; set; }
        public string SiteName { get; set; }
        public bool? Active { get; set; }
    }
}
