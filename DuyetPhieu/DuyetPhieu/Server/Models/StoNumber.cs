using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class StoNumber
    {
        public string Stonumbers { get; set; }
        public double? Quantity { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string ComputerName { get; set; }
        public string Ipaddress { get; set; }
        public string SiteId { get; set; }
        public string ToSiteId { get; set; }
    }
}
