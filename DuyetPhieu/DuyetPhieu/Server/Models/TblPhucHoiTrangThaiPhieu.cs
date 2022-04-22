using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblPhucHoiTrangThaiPhieu
    {
        public Guid Id { get; set; }
        public string SoBienNhan { get; set; }
        public string GhiChu { get; set; }
        public string SiteId { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? CreateDay { get; set; }
    }
}
