using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogXacNhanCallPhieuThongTinBaoHanh
    {
        public Guid Stt { get; set; }
        public string SoPhieu { get; set; }
        public string Note { get; set; }
        public int? Point { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string SiteId { get; set; }
    }
}
