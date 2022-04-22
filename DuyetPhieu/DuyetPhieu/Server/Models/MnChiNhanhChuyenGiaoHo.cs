using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnChiNhanhChuyenGiaoHo
    {
        public string SiteId { get; set; }
        public string SiteChuyenId { get; set; }
        public string TenChiNhanh { get; set; }
        public bool Active { get; set; }
    }
}
