using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblKhoHangTamChiTiet
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public double SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public bool? Active { get; set; }
        public string KeyIdKhoTam { get; set; }
    }
}
