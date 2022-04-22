using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class ViewLocThongTinGiaoHo1
    {
        public string SoChiTiet { get; set; }
        public string SoBienNhan { get; set; }
        public decimal? TienDatCoc { get; set; }
        public decimal? TongTien { get; set; }
        public string TenKhachHang { get; set; }
        public DateTime? NgayGiaoNhan { get; set; }
        public int? Status { get; set; }
        public string MaNhanVien { get; set; }
        public string MaSoXe { get; set; }
        public DateTime? ThoiGianDi { get; set; }
        public DateTime? ThoiGianVe { get; set; }
        public string TenNhanVien { get; set; }
        public string NhomNhanVien { get; set; }
        public int? StatusSalesOrder { get; set; }
        public string ChiNhanhGh { get; set; }
        public int? TrangThaiGh { get; set; }
        public string LuuY { get; set; }
        public DateTime? NgayTaoPhieu { get; set; }
        public string SoPhu { get; set; }
    }
}
