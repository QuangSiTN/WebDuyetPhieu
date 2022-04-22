using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class CskhThongTinPhanHoiKhChiNhanh
    {
        public Guid Id { get; set; }
        public DateTime? NgayGoi { get; set; }
        public DateTime? NgayMua { get; set; }
        public string SoPhieu { get; set; }
        public string TenKhach { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string KetQua { get; set; }
        public string CachXuLy { get; set; }
        public string TenNv { get; set; }
        public string GhiChu { get; set; }
        public string MaCn { get; set; }
        public decimal? ThuPhi { get; set; }
        public string TenNvgoi { get; set; }
        public string SanPham01 { get; set; }
        public string SanPham02 { get; set; }
        public int? Kdban { get; set; }
    }
}
