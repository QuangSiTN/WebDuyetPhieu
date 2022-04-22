using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnKhuVucGiaoHang
    {
        public string SiteId { get; set; }
        public string DistrictId { get; set; }
        public bool Active { get; set; }
    }
}
