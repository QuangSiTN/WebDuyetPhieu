using System;

#nullable disable

namespace DuyetPhieu.Server.Models
{
	public partial class Xe
    {
        public Guid Stt { get; set; }
        public string MaSoXe { get; set; }
        public string MaVachId { get; set; }
        public string TenXe { get; set; }
        public string Phone { get; set; }
        public DateTime? NgayMua { get; set; }
        public DateTime? NgayNhan { get; set; }
        public string DienGiai { get; set; }
        public string MaNhanVien { get; set; }
        public string MaChiNhanh { get; set; }
        public string NguoiTao { get; set; }
        public bool? Active { get; set; }
        public int LoaiXe { get; set; }
        public int? TinhTrangXe { get; set; }
        public bool? StatusOwe { get; set; }
    }
}
