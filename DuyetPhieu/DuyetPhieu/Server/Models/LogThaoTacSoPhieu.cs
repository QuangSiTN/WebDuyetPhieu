using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogThaoTacSoPhieu
    {
        public Guid Stt { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string ComputerName { get; set; }
        public string SoBienNhan { get; set; }
        public int? TrangThaiGh { get; set; }
        public int? Status { get; set; }
        public string MaNhanVien { get; set; }
        public string MaSoXe { get; set; }
        public string Ma2Xe { get; set; }
        public string Note { get; set; }
    }
}
