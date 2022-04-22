using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class DelDaXemSoanHang
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string MaHang { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string SiteId { get; set; }
        public string IpAddress { get; set; }
        public int? Status { get; set; }
    }
}
