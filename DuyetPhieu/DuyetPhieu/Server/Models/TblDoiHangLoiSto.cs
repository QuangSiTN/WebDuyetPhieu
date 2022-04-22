using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblDoiHangLoiSto
    {
        public byte Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int Sl { get; set; }
        public string Note { get; set; }
        public string SiteBan { get; set; }
        public string SiteLayHang { get; set; }
        public string SiteBaoHanh { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string CreateSite { get; set; }
        public string StoNumber { get; set; }
        public int Status { get; set; }
        public int? StatusSto { get; set; }
    }
}
