using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogSendEmail
    {
        public Guid Stt { get; set; }
        public string SoChungTu { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string MoTaLoi { get; set; }
        public string GhiChu { get; set; }
        public string Serial { get; set; }
        public int? Sl { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Send { get; set; }
        public string Cc { get; set; }
        public string CreateBy { get; set; }
    }
}
