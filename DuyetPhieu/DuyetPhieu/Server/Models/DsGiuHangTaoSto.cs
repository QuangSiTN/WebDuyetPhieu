using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class DsGiuHangTaoSto
    {
        public Guid Stt { get; set; }
        public string KeyId { get; set; }
        public string SoBienNhan { get; set; }
        public string SoChiTiet { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public string SiteIdDelivery { get; set; }
        public string SiteIdSap { get; set; }
        public string SiteIdSto { get; set; }
        public string Sto { get; set; }
        public int Status { get; set; }
        public bool? Active { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string QuayBan { get; set; }
        public DateTime? CreateDateLoai { get; set; }
        public string CreateByLoai { get; set; }
    }
}
