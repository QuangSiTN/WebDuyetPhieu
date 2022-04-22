using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class EmsNguyenNhanLoi
    {
        public string SoChungTu { get; set; }
        public string LoaiLoi { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Creationdate { get; set; }
    }
}
