using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogPrintNgoaiLeSbn
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string SiteId { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
