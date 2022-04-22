using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnNhanTuBh
    {
        public string MaThongTin { get; set; }
        public string TenThongTin { get; set; }
        public bool? Active { get; set; }
        public string GhiChu { get; set; }
    }
}
