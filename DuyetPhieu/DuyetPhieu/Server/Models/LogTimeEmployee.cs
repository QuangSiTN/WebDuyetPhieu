using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogTimeEmployee
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime? ThoiGian1 { get; set; }
        public DateTime? ThoiGian2 { get; set; }
        public DateTime? ThoiGian3 { get; set; }
        public DateTime? ThoiGian4 { get; set; }
        public int? StatusTime { get; set; }
        public double? Distance { get; set; }
        public double? DistanceCustomer { get; set; }
        public bool? Active { get; set; }
        public DateTime? ThoiGian5 { get; set; }
    }
}
