using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblPhieuNhanTien
    {
        public string MaPhieu { get; set; }
        public string MaNhanVien { get; set; }
        public string Cmnd { get; set; }
        public DateTime? CreateDayCmnd { get; set; }
        public string LyDo { get; set; }
        public decimal? SoTien { get; set; }
        public string SiteId { get; set; }
        public DateTime? Createday { get; set; }
        public string CreateUser { get; set; }
        public string Computer { get; set; }
        public int? SoLanIn { get; set; }
        public string SiteIdnhan { get; set; }
    }
}
