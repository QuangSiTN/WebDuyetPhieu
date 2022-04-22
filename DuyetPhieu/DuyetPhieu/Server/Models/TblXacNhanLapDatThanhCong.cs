using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblXacNhanLapDatThanhCong
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string SiteId { get; set; }
        public int? StatusCall { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public decimal? TienLapDat { get; set; }
        public string Note { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDateStatus { get; set; }
        public string CreateByStatus { get; set; }
        public string CreateByNghe { get; set; }
        public string CreateDateNghe { get; set; }
        public string NoteNghe { get; set; }
    }
}
