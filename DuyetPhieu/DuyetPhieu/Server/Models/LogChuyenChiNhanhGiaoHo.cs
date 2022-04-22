using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogChuyenChiNhanhGiaoHo
    {
        public string SoBienNhan { get; set; }
        public string UserId { get; set; }
        public string SiteId { get; set; }
        public string SiteChuyenDen { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDay { get; set; }
        public string ComputerName { get; set; }
        public string LuuYcu { get; set; }
        public Guid Stt { get; set; }
    }
}
