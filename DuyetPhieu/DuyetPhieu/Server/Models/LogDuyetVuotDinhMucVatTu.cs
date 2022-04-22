using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogDuyetVuotDinhMucVatTu
    {
        public Guid Id { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public decimal? SlconLai { get; set; }
        public int? Slduyet { get; set; }
    }
}
