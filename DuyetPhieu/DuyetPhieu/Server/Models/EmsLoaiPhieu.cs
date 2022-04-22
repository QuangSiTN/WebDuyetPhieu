using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class EmsLoaiPhieu
    {
        public string SoChungTu { get; set; }
        public string LoaiPhieu { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Creationdate { get; set; }
    }
}
