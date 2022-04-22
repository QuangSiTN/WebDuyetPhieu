using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblMileageMap
    {
        public Guid Stt { get; set; }
        public int? Oid { get; set; }
        public DateTime? FromDay { get; set; }
        public DateTime? ToDay { get; set; }
        public double? Mileage { get; set; }
        public double? AverageSpeed { get; set; }
        public double? IdleTime { get; set; }
    }
}
