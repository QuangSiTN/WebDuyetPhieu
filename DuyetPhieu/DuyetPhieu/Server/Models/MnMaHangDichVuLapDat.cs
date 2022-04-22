using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnMaHangDichVuLapDat
    {
        public string SiteId { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? Price { get; set; }
        public string UnitId { get; set; }
        public bool? Active { get; set; }
    }
}
