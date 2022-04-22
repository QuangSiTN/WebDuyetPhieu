using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblThongTinBaoHanh
    {
        public TblThongTinBaoHanh()
        {
            TblBaoHanhCalls = new HashSet<TblBaoHanhCall>();
            TblBaoHanhLuuYs = new HashSet<TblBaoHanhLuuY>();
            TblBaoHanhNhatKies = new HashSet<TblBaoHanhNhatKy>();
            TblThongTinBaoHanhDetails = new HashSet<TblThongTinBaoHanhDetail>();
            TblThongTinBaoHanhPhuKiens = new HashSet<TblThongTinBaoHanhPhuKien>();
            TblTraHangBaoHanhs = new HashSet<TblTraHangBaoHanh>();
        }

        public string SoPhieu { get; set; }
        public string SoBienNhan { get; set; }
        public DateTime? NgayNhan { get; set; }
        public DateTime? NgayTra { get; set; }
        public string NhanVienNhan { get; set; }
        public string NhanTu { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string NoiDung { get; set; }
        public string GhiChu { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public bool? Active { get; set; }
        public int? Status { get; set; }
        public string MaGuiNcc { get; set; }
        public DateTime? NgayTraBh { get; set; }
        public string SiteId { get; set; }
        public string SiteCn { get; set; }
        public int? SoLanIn { get; set; }
        public DateTime? NgayTaoPhieu { get; set; }
        public string LoaiHangId { get; set; }
        public DateTime? NgayNhanHangGuiCn { get; set; }
        public string MaLoaiBaoHanh { get; set; }
        public string TenLoaiBaoHanh { get; set; }

        public virtual ICollection<TblBaoHanhCall> TblBaoHanhCalls { get; set; }
        public virtual ICollection<TblBaoHanhLuuY> TblBaoHanhLuuYs { get; set; }
        public virtual ICollection<TblBaoHanhNhatKy> TblBaoHanhNhatKies { get; set; }
        public virtual ICollection<TblThongTinBaoHanhDetail> TblThongTinBaoHanhDetails { get; set; }
        public virtual ICollection<TblThongTinBaoHanhPhuKien> TblThongTinBaoHanhPhuKiens { get; set; }
        public virtual ICollection<TblTraHangBaoHanh> TblTraHangBaoHanhs { get; set; }
    }
}
