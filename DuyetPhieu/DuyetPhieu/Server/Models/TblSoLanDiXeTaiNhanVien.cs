using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblSoLanDiXeTaiNhanVien
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string MaNhanVien { get; set; }
        public string SiteId { get; set; }
        public string Createby { get; set; }
        public string ComputerName { get; set; }
        public DateTime? CreateDay { get; set; }
        public string Ipaddress { get; set; }
        public string MaSoXe { get; set; }
    }
}
