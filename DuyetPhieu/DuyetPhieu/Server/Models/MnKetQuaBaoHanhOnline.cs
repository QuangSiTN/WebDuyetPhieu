using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnKetQuaBaoHanhOnline
    {
        public string KetQuaId { get; set; }
        public string NoiDung { get; set; }
        public bool? Active { get; set; }
    }
}
