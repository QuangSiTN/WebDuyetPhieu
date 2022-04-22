using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class KhoPhieuDieuChuyen
    {
        public Guid Id { get; set; }
        public string AutoLine { get; set; }
        public string SoPhieu { get; set; }
        public string ItemId { get; set; }
        public string FromSloc { get; set; }
        public string ToSloc { get; set; }
        public double SoLuong { get; set; }

        public virtual KhoPhieuNhapXuat SoPhieuNavigation { get; set; }
    }
}
