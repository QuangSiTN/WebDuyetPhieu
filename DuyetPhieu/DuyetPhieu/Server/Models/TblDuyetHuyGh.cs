using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblDuyetHuyGh
    {
        public Guid Stt { get; set; }
        public string SoPhieuBienNhan { get; set; }
        public DateTime? NgayDuyetPhieu { get; set; }
        public string Createby { get; set; }
        public string ComputerName { get; set; }
        public string SiteId { get; set; }
        public string Note { get; set; }
    }
}
