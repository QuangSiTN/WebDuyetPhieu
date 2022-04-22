using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblTruHangSapNoteSto
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string IpAddress { get; set; }
        public string ComputerName { get; set; }
        public string Note { get; set; }
        public int? StatusSto { get; set; }
        public string SiteId { get; set; }
    }
}
