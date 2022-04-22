using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class CskhGoiThongTinLapDat
    {
        public Guid Stt { get; set; }
        public string SaleReceipt { get; set; }
        public string Serial { get; set; }
        public string EmployeeName { get; set; }
        public decimal? Charging { get; set; }
        public string ResultsFor { get; set; }
        public string UserHandling { get; set; }
        public string Note { get; set; }
        public string CreateId { get; set; }
        public string ComputerName { get; set; }
        public DateTime? CreateDay { get; set; }
        public int? Status { get; set; }
        public int? Dgnvbh { get; set; }
        public int? Dgnvgn { get; set; }
        public int? Dgnvtn { get; set; }
    }
}
