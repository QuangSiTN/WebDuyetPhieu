using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnTienPhiLapDat
    {
        public string SiteId { get; set; }
        public string IdloaiMay { get; set; }
        public decimal Moneys { get; set; }
        public decimal MoneyDichVu { get; set; }
        public bool Active { get; set; }
    }
}
