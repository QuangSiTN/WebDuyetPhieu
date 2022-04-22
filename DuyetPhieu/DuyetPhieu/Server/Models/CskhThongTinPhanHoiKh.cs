using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class CskhThongTinPhanHoiKh
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
        public string Serial { get; set; }
        public int? StatusIndex { get; set; }
        public string MaCode { get; set; }
        public int? Dgnvbh { get; set; }
        public int? Dgnvgn { get; set; }
        public string ChatLuongPv { get; set; }
        public int? Dgnvtn { get; set; }
    }
}
