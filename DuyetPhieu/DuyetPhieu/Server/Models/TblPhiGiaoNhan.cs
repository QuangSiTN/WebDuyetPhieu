using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblPhiGiaoNhan
    {
        public string SoBienNhan { get; set; }
        public decimal? TienNhanVien { get; set; }
        public string Mahang { get; set; }
        public string TenHang { get; set; }
        public string Createby { get; set; }
        public string ComputerName { get; set; }
        public DateTime CreationDate { get; set; }
        public string SiteId { get; set; }
        public int? TrangThaiGh { get; set; }
        public string IdthongTin { get; set; }
        public bool? Active { get; set; }
        public int? StatusDinhMuc { get; set; }
    }
}
