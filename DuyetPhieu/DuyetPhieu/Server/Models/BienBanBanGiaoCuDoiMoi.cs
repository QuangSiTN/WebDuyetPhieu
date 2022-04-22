using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class BienBanBanGiaoCuDoiMoi
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string MaNhanVien { get; set; }
        public string TenSanPhamThuHoi { get; set; }
        public string TenChuongTrinh { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string ComputerName { get; set; }
        public string SiteId { get; set; }
    }
}
