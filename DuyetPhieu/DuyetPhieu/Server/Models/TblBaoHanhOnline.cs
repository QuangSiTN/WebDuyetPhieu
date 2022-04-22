using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblBaoHanhOnline
    {
        public TblBaoHanhOnline()
        {
            TblBaoHanhOnlineDetails = new HashSet<TblBaoHanhOnlineDetail>();
        }

        public string SoPhieu { get; set; }
        public string SoBienNhan { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime? NgayNhan { get; set; }
        public DateTime? NgayMuaHang { get; set; }
        public string LoaiHangId { get; set; }
        public string TinhTrang { get; set; }
        public string GhiChu { get; set; }
        public int? Status { get; set; }
        public string SiteId { get; set; }
        public string SiteCn { get; set; }
        public string MaThongTin { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public int? StatusBaoHanh { get; set; }
        public int? StatusTinhPhi { get; set; }
        public int? StatusSuaLai { get; set; }
        public int? StatusChuyenVeTtbh { get; set; }
        public int? StatusSuaChuaTaiNha { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime? ThoiGianDi { get; set; }
        public DateTime? ThoiGianVe { get; set; }
        public int? SoKm { get; set; }
        public int? SoLanIn { get; set; }
        public string KetQuaId { get; set; }
        public decimal? TienPhiCtac { get; set; }
        public DateTime? NgayGioXuLy { get; set; }
        public string GhiChuChuyen { get; set; }
        public string SiteIdSbn { get; set; }
        public int? TrangThaiSend { get; set; }
        public DateTime? ThoiGianChapNhanBaoHanh { get; set; }
        public int? Point { get; set; }
        public string LoaiDichVuId { get; set; }
        public string IdTicketRequest { get; set; }

        public virtual ICollection<TblBaoHanhOnlineDetail> TblBaoHanhOnlineDetails { get; set; }
    }
}
