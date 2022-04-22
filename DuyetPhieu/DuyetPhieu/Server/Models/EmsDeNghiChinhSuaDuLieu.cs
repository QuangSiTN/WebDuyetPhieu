using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class EmsDeNghiChinhSuaDuLieu
    {
        public string SoChungTu { get; set; }
        public string LoaiChungTu { get; set; }
        public string ChungTuLq { get; set; }
        public string UrlAnh { get; set; }
        public string NguyeNhanLoi { get; set; }
        public string HinhThucChinhSua { get; set; }
        public string NoiDung { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? Status { get; set; }
    }
}
