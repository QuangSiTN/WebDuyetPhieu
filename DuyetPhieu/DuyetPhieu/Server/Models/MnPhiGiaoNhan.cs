using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnPhiGiaoNhan
    {
        public string SoChungTu { get; set; }
        public string NhomHang { get; set; }
        public decimal? PhiGiaoGan { get; set; }
        public decimal? PhiGiaoXa { get; set; }
        public decimal? PhiLapDat { get; set; }
        public bool? Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
