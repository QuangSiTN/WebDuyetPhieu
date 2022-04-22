using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblThongTinBaoHanhXuatDieuChuyen
    {
        public Guid Stt { get; set; }
        public string SoChungTuSap { get; set; }
        public int? Status { get; set; }
        public string SiteId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string SiteIdNhap { get; set; }
        public bool? Active { get; set; }
        public int? StatusKhoiTao { get; set; }
        public string Sttdetail { get; set; }
    }
}
