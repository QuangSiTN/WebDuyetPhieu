using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class EmsNguoiDuyet
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string DepartmenId { get; set; }
        public string CreatedBy { get; set; }
        public int? Levels { get; set; }
        public string Note { get; set; }
        public string LoaiChungTu { get; set; }
        public string SiteId { get; set; }
    }
}
