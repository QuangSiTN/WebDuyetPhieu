using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblBaoHanhNhatKy
    {
        public string MaNhatKyBh { get; set; }
        public string SoPhieu { get; set; }
        public DateTime? NgayNhan { get; set; }
        public string Nvnhan { get; set; }
        public string TinhTrangId { get; set; }
        public decimal? TienThuNcc { get; set; }
        public decimal? TienTraNcc { get; set; }
        public decimal? TienThuKh { get; set; }
        public decimal? TienTraKh { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Serial { get; set; }
        public string Nsx { get; set; }
        public int? SoLuong { get; set; }
        public string NoiDung { get; set; }
        public string GhiChu { get; set; }
        public int? Status { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public string Stt { get; set; }

        public virtual TblThongTinBaoHanh SoPhieuNavigation { get; set; }
        public virtual MnTinhTrangBh TinhTrang { get; set; }
    }
}
