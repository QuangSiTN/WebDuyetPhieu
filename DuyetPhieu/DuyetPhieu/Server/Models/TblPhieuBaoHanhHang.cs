using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblPhieuBaoHanhHang
    {
        public Guid Stt { get; set; }
        public string MaGuiNcc { get; set; }
        public string MaNccHang { get; set; }
        public DateTime? NgayNhan { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int? SoLuong { get; set; }
        public string Serial { get; set; }
        public string Nccid { get; set; }
        public string GhiChu { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string SiteId { get; set; }
        public string Sttdetail { get; set; }
    }
}
