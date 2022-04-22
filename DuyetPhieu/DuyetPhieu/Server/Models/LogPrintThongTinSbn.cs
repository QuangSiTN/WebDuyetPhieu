using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogPrintThongTinSbn
    {
        public string SaleRecieptId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
        public Guid Stt { get; set; }
    }
}
