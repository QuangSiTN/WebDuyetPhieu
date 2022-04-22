using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogNhanHangBaoHanhChiNhanh
    {
        public Guid? Stt { get; set; }
        public string MoTaLoi { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Nsx { get; set; }
        public string Serial { get; set; }
        public double? Sl { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
    }
}
