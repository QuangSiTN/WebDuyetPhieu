using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblOidmap
    {
        public int Oid { get; set; }
        public string Plate { get; set; }
        public string GroupName { get; set; }
        public string DeviceSerial { get; set; }
        public string RemoteId { get; set; }
        public string DiviceName { get; set; }
        public int? MaxSpeed { get; set; }
        public bool? Gbrsenable { get; set; }
        public bool? Smsenable { get; set; }
        public string TrackingMode { get; set; }
        public int? ParkingInterval { get; set; }
        public int? DistanceIntervar { get; set; }
        public DateTime? CreateDay { get; set; }
        public int? SimNumber { get; set; }
    }
}
