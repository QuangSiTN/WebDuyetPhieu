using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogDuyetThemSoLuongPhieu
    {
        public Guid Stt { get; set; }
        public DateTime Ngay { get; set; }
        public string SiteId { get; set; }
        public int SoLuong { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string IpAddress { get; set; }
        public string ComputerName { get; set; }
    }
}
