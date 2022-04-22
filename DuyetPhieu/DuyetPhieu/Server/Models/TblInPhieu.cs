using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblInPhieu
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public DateTime NgayInPhieu { get; set; }
        public int SoLanIn { get; set; }
        public string Createby { get; set; }
        public string ComputerName { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDay { get; set; }
    }
}
