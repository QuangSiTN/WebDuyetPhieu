using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogBaoHanhOnline
    {
        public Guid Stt { get; set; }
        public string SoPhieu { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public string Note { get; set; }
        public string SiteId { get; set; }
        public string GhiChuChuyen { get; set; }
        public string KetQua { get; set; }
    }
}
