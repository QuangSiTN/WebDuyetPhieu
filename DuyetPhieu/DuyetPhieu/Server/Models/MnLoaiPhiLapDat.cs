using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnLoaiPhiLapDat
    {
        public string IdloaiMay { get; set; }
        public string NoiDung { get; set; }
        public decimal? Moneys { get; set; }
        public bool Active { get; set; }
    }
}
