using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblBaoHanhOnlineTinhPhi
    {
        public Guid Stt { get; set; }
        public string SoPhieu { get; set; }
        public string MaNhanVien { get; set; }
        public decimal? TienPhi { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public string CreateDuyetPhi { get; set; }
        public DateTime? CreateDayDuyet { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public double? NumberKm { get; set; }
        public int? StatusXacNhan { get; set; }
    }
}
