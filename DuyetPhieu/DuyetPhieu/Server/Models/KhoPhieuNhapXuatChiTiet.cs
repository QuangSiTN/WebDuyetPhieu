using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class KhoPhieuNhapXuatChiTiet
    {
        public Guid Id { get; set; }
        public string SoPhieu { get; set; }
        public string LoaiNx { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public string MaPo { get; set; }
        public string FromSloc { get; set; }
        public string ToSloc { get; set; }
        public string SlocSiteId { get; set; }

        public virtual KhoPhieuNhapXuat SoPhieuNavigation { get; set; }
    }
}
