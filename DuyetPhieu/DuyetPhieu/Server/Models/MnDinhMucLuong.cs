using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnDinhMucLuong
    {
        public string SiteId { get; set; }
        public string PhanVung { get; set; }
        public int? DinhMuc { get; set; }
        public int Status { get; set; }
        public decimal? LuongBaoHiem { get; set; }
        public decimal? Kpi { get; set; }
        public decimal? PcDienThoai { get; set; }
        public decimal? PhiGiaoThong { get; set; }
        public decimal? TongThuNhap { get; set; }
    }
}
