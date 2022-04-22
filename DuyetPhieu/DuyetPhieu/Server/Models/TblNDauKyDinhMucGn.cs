using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblNDauKyDinhMucGn
    {
        public Guid Id { get; set; }
        public string SiteId { get; set; }
        public int? DauKy { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Createtiondate { get; set; }
        public string CreatedBy { get; set; }
    }
}
