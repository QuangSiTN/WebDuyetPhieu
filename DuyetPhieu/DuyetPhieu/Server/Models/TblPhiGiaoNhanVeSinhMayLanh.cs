using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblPhiGiaoNhanVeSinhMayLanh
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public double? TienNhanVien { get; set; }
        public string MaNhanVien { get; set; }
        public string Mahang { get; set; }
        public string TenHang { get; set; }
        public string Createby { get; set; }
        public string ComputerName { get; set; }
        public DateTime? CreationDate { get; set; }
        public string SiteId { get; set; }
        public string Note { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public bool? Active { get; set; }
    }
}
