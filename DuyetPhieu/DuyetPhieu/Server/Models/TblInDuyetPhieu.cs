using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblInDuyetPhieu
    {
        public Guid Stt { get; set; }
        public string SoPhieuBienNhan { get; set; }
        public string LyDoHuy { get; set; }
        public DateTime? NgayInPhieu { get; set; }
        public string Createby { get; set; }
        public string ComputerName { get; set; }
        public string SiteId { get; set; }
        public string CreatebyUser { get; set; }
        public string ComputerNameUser { get; set; }
        public DateTime? NgayHuyPhieu { get; set; }
    }
}
