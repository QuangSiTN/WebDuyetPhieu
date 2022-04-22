using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogTruHangBaoHanh
    {
        public Guid Stt { get; set; }
        public string SoPhieu { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Serial { get; set; }
        public double? Sl { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ChungTuSap { get; set; }
    }
}
