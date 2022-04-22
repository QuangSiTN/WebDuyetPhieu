using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class KhoTonDau
    {
        public string ItemId { get; set; }
        public string MaChiNhanh { get; set; }
        public string SlocSiteId { get; set; }
        public decimal SoLuong { get; set; }
        public DateTime NgayTonDau { get; set; }
    }
}
