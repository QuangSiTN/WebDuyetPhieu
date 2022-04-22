using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class CskhNhanThongTinKh
    {
        public Guid SoPhu { get; set; }
        public string SoPhieu { get; set; }
        public string NguonThongTin { get; set; }
        public DateTime? NgayNhan { get; set; }
        public DateTime? NgayMua { get; set; }
        public string TenKhach { get; set; }
        public string NoiDung { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string TinhTrangSp { get; set; }
        public string KetQua { get; set; }
        public string Huongxuly { get; set; }
        public string TenNv { get; set; }
        public string GhiChu { get; set; }
        public string MaCn { get; set; }
        public decimal? ThuPhi { get; set; }
        public string TenNvgoi { get; set; }
    }
}
