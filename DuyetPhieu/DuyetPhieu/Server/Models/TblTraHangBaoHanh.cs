using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblTraHangBaoHanh
    {
        public Guid Stt { get; set; }
        public string SoPhieu { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public string MaNhanVienTra { get; set; }
        public decimal? TongTienThu { get; set; }
        public decimal? TienThuKhac { get; set; }
        public string LyDo { get; set; }
        public int? Status { get; set; }
        public DateTime? NgayTra { get; set; }
        public string SbnkhachTra { get; set; }
        public int? ThoiGianBaoHanh { get; set; }
        public int? SoLanIn { get; set; }

        public virtual TblThongTinBaoHanh SoPhieuNavigation { get; set; }
    }
}
