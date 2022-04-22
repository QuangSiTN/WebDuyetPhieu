using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnMaHangLapDat
    {
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string IdloaiMay { get; set; }
        public bool Active { get; set; }
    }
}
