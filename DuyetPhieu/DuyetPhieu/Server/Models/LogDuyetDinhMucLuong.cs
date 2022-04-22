using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogDuyetDinhMucLuong
    {
        public int? Thang { get; set; }
        public int? Nam { get; set; }
        public string SiteId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string ComputerName { get; set; }
    }
}
