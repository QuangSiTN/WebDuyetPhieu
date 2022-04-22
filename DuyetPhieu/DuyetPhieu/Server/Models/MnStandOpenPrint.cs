using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnStandOpenPrint
    {
        public string StandId { get; set; }
        public bool? Active { get; set; }
        public string Note { get; set; }
    }
}
