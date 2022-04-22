using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TempReportBaoHanh
    {
        public string SiteId { get; set; }
        public string Sloc { get; set; }
        public string ItemId { get; set; }
        public int? QuantitySap { get; set; }
        public int? QuantityDelivery { get; set; }
    }
}
