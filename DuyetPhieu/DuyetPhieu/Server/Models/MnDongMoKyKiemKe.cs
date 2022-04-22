using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnDongMoKyKiemKe
    {
        public string KyKiemKe { get; set; }
        public string SiteId { get; set; }
        public bool Active { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
