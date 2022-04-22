using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class BaoTriXe
    {
        public int Id { get; set; }
        public string MaSoXe { get; set; }
        public DateTime? NgayBd { get; set; }
        public DateTime? NgayKt { get; set; }
        public int? SoTien { get; set; }
        public string LyDo { get; set; }
    }
}
