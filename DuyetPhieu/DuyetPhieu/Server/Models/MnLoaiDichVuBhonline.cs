using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnLoaiDichVuBhonline
    {
        public string LoaiDichVuId { get; set; }
        public string TenLoaiDichVu { get; set; }
        public bool? Active { get; set; }
    }
}
