using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblSoLanDiLog
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string SiteId { get; set; }
        public string Createby { get; set; }
        public string ComputerName { get; set; }
        public DateTime? CreateDay { get; set; }
        public string Note { get; set; }
        public int? Status { get; set; }
    }
}
