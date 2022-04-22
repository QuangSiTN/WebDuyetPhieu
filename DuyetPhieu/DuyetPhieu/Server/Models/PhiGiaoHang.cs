using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class PhiGiaoHang
    {
        public Guid? Stt { get; set; }
        public string BienPhi { get; set; }
        public decimal? GiaTri { get; set; }
    }
}
