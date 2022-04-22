using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class Viewtinhtienxetai
    {
        public string SoBienNhan { get; set; }
        public string MaSoXe { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string QuanHuyenName { get; set; }
        public string CityName { get; set; }
        public DateTime? NgayGiaoNhan { get; set; }
        public decimal? TongTien { get; set; }
        public decimal? TienDatCoc { get; set; }
        public string NhomNhanVien { get; set; }
        public string Mahang { get; set; }
        public string TenHang { get; set; }
        public string ChiNhanhGh { get; set; }
        public DateTime? ThoiGianVe { get; set; }
    }
}
