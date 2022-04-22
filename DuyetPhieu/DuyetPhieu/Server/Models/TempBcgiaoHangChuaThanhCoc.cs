using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TempBcgiaoHangChuaThanhCoc
    {
        public Guid Stt { get; set; }
        public string SalesReceiptId { get; set; }
        public bool? PaymentFinished { get; set; }
        public int? Status { get; set; }
        public string StandId { get; set; }
        public DateTime? GioNap { get; set; }
    }
}
