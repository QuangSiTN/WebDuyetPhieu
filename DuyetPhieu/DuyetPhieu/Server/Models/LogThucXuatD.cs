using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogThucXuatD
    {
        public Guid Stt { get; set; }
        public string Matx { get; set; }
        public string SalesReceiptId { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
