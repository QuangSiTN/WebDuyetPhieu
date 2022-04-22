using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblBaoHanhOnlineHuongXuLy
    {
        public Guid Stt { get; set; }
        public string SoPhieu { get; set; }
        public string GhiChu { get; set; }
        public string SiteId { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public int? Status { get; set; }
    }
}
