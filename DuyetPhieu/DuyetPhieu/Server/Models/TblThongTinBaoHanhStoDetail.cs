using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblThongTinBaoHanhStoDetail
    {
        public Guid Stt { get; set; }
        public string SoPhieu { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Nsx { get; set; }
        public string Serial { get; set; }
        public double? Sl { get; set; }
        public string LoaiDv { get; set; }
        public string MoTaLoi { get; set; }
        public DateTime? NgayTemCty { get; set; }
        public int? ThangBaoHanh { get; set; }
        public DateTime? NgayTemNsx { get; set; }
        public string Note { get; set; }
        public int? StatusDetail { get; set; }
        public string SlocBaoHanh { get; set; }
        public string NguonGocLoiId { get; set; }
        public string Idbbsto { get; set; }
    }
}
