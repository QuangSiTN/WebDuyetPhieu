using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnAutoSoPhu
    {
        public string SiteCnGiaoHo { get; set; }
        public string SiteId { get; set; }
        public int Stt { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
