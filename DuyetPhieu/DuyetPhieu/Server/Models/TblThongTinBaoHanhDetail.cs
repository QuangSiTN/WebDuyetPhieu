using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblThongTinBaoHanhDetail
    {
        public Guid Stt { get; set; }
        public string SoPhieu { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Nsx { get; set; }
        public string Serial { get; set; }
        public double? Sl { get; set; }
        public string LoaiDv { get; set; }
        public string MoTaLoi { get; set; }
        public DateTime? NgayTemCty { get; set; }
        public int? ThangBaoHanh { get; set; }
        public DateTime? NgayTemNsx { get; set; }
        public string Note { get; set; }
        public int? StatusDetail { get; set; }
        public int? TrangThai { get; set; }
        public string MaGuiNcc { get; set; }
        public DateTime? NgayTraBh { get; set; }
        public string TinhTrangId { get; set; }
        public double? Slxuat { get; set; }
        public DateTime? NgayNhanHangBaoHanh { get; set; }
        public string SiteNhanBaoHanh { get; set; }
        public string SiteNhapBaoHanh { get; set; }
        public DateTime? CreateDateDetail { get; set; }
        public bool? ActiveDetail { get; set; }
        public int? TrangThaiGui { get; set; }
        public string SoPhieuSto { get; set; }
        public string SlocBaoHanh { get; set; }
        public string NguonGocLoiId { get; set; }
        public int? StatusXacNhan { get; set; }
        public DateTime? NgayGuiHangBaoHanh { get; set; }
        public DateTime? NgayNhanVeTuHang { get; set; }
        public string HuongXuLyId { get; set; }
        public string KinhDoanhGhiChu { get; set; }
        public int? StatusRutSto { get; set; }
        public int? StatusCapNhatGiaBan { get; set; }
        public decimal? Price { get; set; }
        public int? StatusDieuChuyen { get; set; }
        public string Idbb { get; set; }
        public int? StatusEmail { get; set; }
        public int? StatusHangKyThuat { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorMail { get; set; }
        public string Mc { get; set; }
        public string Mcname { get; set; }

        public virtual MnLoaiDichVuBh LoaiDvNavigation { get; set; }
        public virtual TblThongTinBaoHanh SoPhieuNavigation { get; set; }
    }
}
