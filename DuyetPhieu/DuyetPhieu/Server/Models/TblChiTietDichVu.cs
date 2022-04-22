using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblChiTietDichVu
    {
        public Guid Stt { get; set; }
        public string SoPhieuThu { get; set; }
        public string Mahang { get; set; }
        public string TenHang { get; set; }
        public double? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public string UnitId { get; set; }
        public int? CheckRaBn { get; set; }
    }
}
