using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class NhanVien
    {
        public Guid Stt { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string LuuY { get; set; }
        public string UserTao { get; set; }
        public string MaChiNhanh { get; set; }
        public int? SoLanDi { get; set; }
        public int? SoLuongPhieu { get; set; }
        public string MaBaCodeId { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? StatusOwe { get; set; }
        public bool? NgoaiLeDinhMucLuong { get; set; }
        public int? StatusDichVu { get; set; }
        public string DepartMentId { get; set; }
        public string DepartMentName { get; set; }
    }
}
