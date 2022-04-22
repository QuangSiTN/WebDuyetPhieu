using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblSoTrangIn
    {
        public string MaChiNhanh { get; set; }
        public string TenChiNhanh { get; set; }
        public int? SoTrangIn { get; set; }
        public int? SoTrangInLai { get; set; }
        public bool? Active { get; set; }
        public bool? StatusBacode { get; set; }
        public bool? A4a5 { get; set; }
        public bool? CheckedA4 { get; set; }
    }
}
