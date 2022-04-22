using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblPhiGiaoNhanXeTai
    {
        public string SoBienNhan { get; set; }
        public string MaNhanVien { get; set; }
        public decimal? TienNhanVien { get; set; }
        public string SiteId { get; set; }
        public DateTime? CreateDay { get; set; }
    }
}
