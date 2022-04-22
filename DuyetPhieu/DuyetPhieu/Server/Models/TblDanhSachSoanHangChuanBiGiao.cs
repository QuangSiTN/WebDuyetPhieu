using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblDanhSachSoanHangChuanBiGiao
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public int Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string SiteId { get; set; }
        public int? LoaiXe { get; set; }
        public int? StatusSoanHang { get; set; }
        public string Note { get; set; }
    }
}
