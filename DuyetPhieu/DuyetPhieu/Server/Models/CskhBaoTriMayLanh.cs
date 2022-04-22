using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class CskhBaoTriMayLanh
    {
        public string SoBienNhan { get; set; }
        public int? Status { get; set; }
        public string SiteId { get; set; }
        public string Note { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public DateTime? CreateDay { get; set; }
        public string SiteTransfer { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int? SoLuong { get; set; }
        public DateTime? TransferDay { get; set; }
    }
}
