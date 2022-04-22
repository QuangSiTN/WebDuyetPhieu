using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblBaoHanhGuiHangDetail
    {
        public Guid Stt { get; set; }
        public string SoPhieu { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int? SoLuong { get; set; }
        public int? StatusLoaiPhieu { get; set; }
        public string Serial { get; set; }
    }
}
