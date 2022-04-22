using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblKhoHangTam
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string KeyIdKhoTam { get; set; }
        public string Note { get; set; }
        public string SiteId { get; set; }
        public DateTime CreateDay { get; set; }
        public string CreateBy { get; set; }
        public int StatusKhoTam { get; set; }
        public int StatusDieuPhoi { get; set; }
        public bool? Active { get; set; }
        public string ComputerName { get; set; }
        public string Ipaddress { get; set; }
        public int? TrangThai { get; set; }
        public string NhanVienXeGui { get; set; }
        public string NhanVienXeLay { get; set; }
        public DateTime? ThoiGianGui { get; set; }
        public DateTime? ThoiGianLay { get; set; }
        public string GhiChuXeTaiGui { get; set; }
        public string GhiChuXeTaiLay { get; set; }
        public int? StatusPrint { get; set; }
    }
}
