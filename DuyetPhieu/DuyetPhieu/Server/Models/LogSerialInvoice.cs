using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogSerialInvoice
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string Serial { get; set; }
        public string InvoiceNum { get; set; }
        public DateTime? CreateDay { get; set; }
        public string DanhGiaKhachHang { get; set; }
        public string CreateBy { get; set; }
        public string Computer { get; set; }
    }
}
