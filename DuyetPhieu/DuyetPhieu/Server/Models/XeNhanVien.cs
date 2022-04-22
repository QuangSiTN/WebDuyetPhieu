using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class XeNhanVien
    {
        public Guid Stt { get; set; }
        public string MaXe { get; set; }
        public string MaNhanVien2Xe { get; set; }
        public string NhomNhanVien { get; set; }
        public string GhiChu { get; set; }
        public string SoChiTiet { get; set; }
        public string SiteId { get; set; }
        public bool? TinhPhi { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
