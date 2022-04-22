using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class KhoXuatNhapTon
    {
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string ItemId { get; set; }
        public string MaChiNhanh { get; set; }
        public string SlocSiteId { get; set; }
        public decimal TonDau { get; set; }
        public decimal PhatSinhNhap { get; set; }
        public decimal PhatSinhXuat { get; set; }
        public decimal TonCuoi { get; set; }
        public DateTime? CreateDay { get; set; }
    }
}
