using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class CskhXuLyTraHangChiNhanh
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string NoiDungXuLy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public string SiteId { get; set; }
    }
}
