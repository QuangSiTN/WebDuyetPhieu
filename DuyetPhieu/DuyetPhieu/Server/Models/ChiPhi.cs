using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class ChiPhi
    {
        public int MaCp { get; set; }
        public string MaSoXe { get; set; }
        public DateTime? NgayUng { get; set; }
        public int? SoTien { get; set; }
        public string DienGiai { get; set; }
        public string SoCt { get; set; }
        public string SoKm { get; set; }
    }
}
