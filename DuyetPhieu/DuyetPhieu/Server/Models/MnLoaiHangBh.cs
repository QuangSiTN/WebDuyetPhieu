using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnLoaiHangBh
    {
        public string LoaiHangId { get; set; }
        public string TenLoaiHang { get; set; }
        public bool? Active { get; set; }
        public string GhiChu { get; set; }
        public string KeyUpSerial { get; set; }
        public string Mch { get; set; }
        public string Samsung { get; set; }
    }
}
