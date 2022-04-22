using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblBaoHanhLuuY
    {
        public string LuuYid { get; set; }
        public string SoPhieu { get; set; }
        public DateTime? NgayGhi { get; set; }
        public string MaNhanVien { get; set; }
        public string NoiDung { get; set; }
        public string GhiChu { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public string Stt { get; set; }

        public virtual TblThongTinBaoHanh SoPhieuNavigation { get; set; }
    }
}
