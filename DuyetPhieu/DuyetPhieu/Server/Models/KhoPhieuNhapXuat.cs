using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class KhoPhieuNhapXuat
    {
        public KhoPhieuNhapXuat()
        {
            KhoPhieuDieuChuyens = new HashSet<KhoPhieuDieuChuyen>();
            KhoPhieuNhapXuatChiTiets = new HashSet<KhoPhieuNhapXuatChiTiet>();
        }

        public string SoPhieu { get; set; }
        public string MaChiNhanh { get; set; }
        public string LoaiNx { get; set; }
        public DateTime? NgayPost { get; set; }
        public string CreateBy { get; set; }
        public string SoPo { get; set; }
        public string GhiChu { get; set; }
        public bool? Del { get; set; }
        public bool? Reverse { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<KhoPhieuDieuChuyen> KhoPhieuDieuChuyens { get; set; }
        public virtual ICollection<KhoPhieuNhapXuatChiTiet> KhoPhieuNhapXuatChiTiets { get; set; }
    }
}
