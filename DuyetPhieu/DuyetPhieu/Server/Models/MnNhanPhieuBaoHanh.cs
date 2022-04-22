using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnNhanPhieuBaoHanh
    {
        public string SiteId { get; set; }
        public int NumberMin { get; set; }
        public int NumberMax { get; set; }
        public int NumberSum { get; set; }
        public bool Active { get; set; }
        public bool Warning { get; set; }
    }
}
