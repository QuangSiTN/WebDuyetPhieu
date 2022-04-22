using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogBaoHanhSuaChua
    {
        public Guid Stt { get; set; }
        public string SoPhieu { get; set; }
        public string NoiDung { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string ComputerName { get; set; }
        public string SiteId { get; set; }
        public string Serial { get; set; }
        public decimal? TinhPhi { get; set; }
        public string ItemId { get; set; }
        public string MoTaLoi { get; set; }
    }
}
