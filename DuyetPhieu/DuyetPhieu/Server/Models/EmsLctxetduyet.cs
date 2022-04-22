using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class EmsLctxetduyet
    {
        public string MaXetDuyet { get; set; }
        public string LoaiChungTu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string MoTa { get; set; }
        public int? Levels { get; set; }
    }
}
