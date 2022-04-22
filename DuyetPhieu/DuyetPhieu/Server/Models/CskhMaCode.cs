using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class CskhMaCode
    {
        public string UserId { get; set; }
        public string MaCode { get; set; }
        public DateTime? CreateDay { get; set; }
        public string Computer { get; set; }
        public string CreateBy { get; set; }
        public DateTime? TimeOn { get; set; }
        public DateTime? TimeOff { get; set; }
    }
}
