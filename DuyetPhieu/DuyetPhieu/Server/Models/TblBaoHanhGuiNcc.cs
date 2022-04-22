using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblBaoHanhGuiNcc
    {
        public string MaGuiNcc { get; set; }
        public string TenNcc { get; set; }
        public string NoiDung { get; set; }
        public string GhiChu { get; set; }
        public string MaNvgui { get; set; }
        public DateTime? NgayGui { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
    }
}
