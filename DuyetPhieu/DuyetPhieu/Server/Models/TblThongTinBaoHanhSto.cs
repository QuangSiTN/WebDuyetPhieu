using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblThongTinBaoHanhSto
    {
        public string SoPhieu { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public int? Active { get; set; }
        public string SiteId { get; set; }
        public string SiteCn { get; set; }
        public string NoiDung { get; set; }
        public string Sto { get; set; }
        public string NhanTu { get; set; }
        public DateTime? CreateDateSo { get; set; }
        public int? StatusSto { get; set; }
        public DateTime? CreateDayNgayDuyet { get; set; }
        public string LyDoLoai { get; set; }
        public string MaSoXe { get; set; }
    }
}
