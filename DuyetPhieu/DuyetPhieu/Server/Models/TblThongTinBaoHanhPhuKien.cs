using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblThongTinBaoHanhPhuKien
    {
        public Guid Id { get; set; }
        public string SoPhieu { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public double? SoLuong { get; set; }
        public string Serial { get; set; }
        public string NhaSx { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }

        public virtual TblThongTinBaoHanh SoPhieuNavigation { get; set; }
    }
}
