using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblBaoHanhGuiHang
    {
        public string SoPhieu { get; set; }
        public string TenTramBaoHanh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public int? StatusBe { get; set; }
        public int? StatusTray { get; set; }
        public int? StatusMop { get; set; }
        public int? StatusLoiKt { get; set; }
        public string ErrorKhac { get; set; }
        public string MaNhanVien { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public string SiteId { get; set; }
        public decimal? TienPhiCtac { get; set; }
        public DateTime? ThoiGianDi { get; set; }
        public DateTime? ThoiGianVe { get; set; }
        public int? Status { get; set; }
    }
}
