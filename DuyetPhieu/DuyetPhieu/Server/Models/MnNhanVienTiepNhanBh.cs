using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnNhanVienTiepNhanBh
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public bool Active { get; set; }
        public string GhiChu { get; set; }
        public string SiteId { get; set; }
        public string Phone { get; set; }
    }
}
