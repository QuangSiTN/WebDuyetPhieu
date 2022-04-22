using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblAdressMap
    {
        public Guid Stt { get; set; }
        public int? Oid { get; set; }
        public double? TimeGps { get; set; }
        public int? Velocity { get; set; }
        public int? OnOff { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Way { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDay { get; set; }
    }
}
