using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblThongTinBaoHanhChungTu
    {
        public Guid Stt { get; set; }
        public string SctnhapXuat { get; set; }
        public string Note { get; set; }
        public int? Status { get; set; }
        public string SiteId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Active { get; set; }
        public DateTime? CreateDateXuLy { get; set; }
        public string CreateUserBy { get; set; }
    }
}
