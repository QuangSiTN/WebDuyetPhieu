using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class CskhGoiPhieuHenKhach
    {
        public Guid Stt { get; set; }
        public string Sbn { get; set; }
        public string SiteId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public int? StatusCall { get; set; }
        public string Note { get; set; }
        public string CreateByHandling { get; set; }
        public DateTime? CreateDateHandling { get; set; }
        public string SiteIdHandling { get; set; }
    }
}
