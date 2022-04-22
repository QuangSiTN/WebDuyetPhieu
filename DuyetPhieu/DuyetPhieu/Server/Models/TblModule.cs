using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblModule
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string Note { get; set; }
    }
}
