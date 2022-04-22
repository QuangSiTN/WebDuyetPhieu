using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class EmsChungtuxd
    {
        public Guid MaGiaoDich { get; set; }
        public string GhiChu { get; set; }
        public string LoaiChungTu { get; set; }
        public string SoChungTu { get; set; }
        public string GoiDen { get; set; }
        public string ThucHien { get; set; }
        public int? Status { get; set; }
        public DateTime? NgayGoi { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public decimal? TongGiaTri { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? TrangThaiDuyet { get; set; }
        public string Lydo { get; set; }
    }
}
