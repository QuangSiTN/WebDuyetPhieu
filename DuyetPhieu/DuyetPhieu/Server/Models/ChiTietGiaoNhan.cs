using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class ChiTietGiaoNhan
    {
        public Guid Stt { get; set; }
        public string SoChiTiet { get; set; }
        public string Mahang { get; set; }
        public string TenHang { get; set; }
        public double? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public int? D { get; set; }
        public int? R { get; set; }
        public int? C { get; set; }
        public decimal? Hs { get; set; }
        public decimal? Tl { get; set; }
        public decimal? Tt { get; set; }
        public decimal? HsxTt { get; set; }
        public string SlocId { get; set; }
    }
}
