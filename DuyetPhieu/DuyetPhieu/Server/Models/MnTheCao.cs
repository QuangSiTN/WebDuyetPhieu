using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnTheCao
    {
        public string TheCaoId { get; set; }
        public string TenTheCao { get; set; }
        public bool? Active { get; set; }
    }
}
