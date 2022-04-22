using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class SmsSend
    {
        public Guid Stt { get; set; }
        public string TreeTop { get; set; }
        public string Note { get; set; }
        public bool? Active { get; set; }
        public int? LengthNumber { get; set; }
    }
}
