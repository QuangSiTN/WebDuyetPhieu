using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnBoPhan
    {
        public string BoPhanId { get; set; }
        public string TenBoPhan { get; set; }
        public string LoaiHangId { get; set; }
        public bool? Active { get; set; }
    }
}
