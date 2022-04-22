using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class BarcodeBaoVeQuet
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public DateTime? ThoiGianDi { get; set; }
        public string CreateBy { get; set; }
        public string ComputerName { get; set; }
        public string SiteId { get; set; }
        public int? TrangThai { get; set; }
        public bool? Active { get; set; }
    }
}
