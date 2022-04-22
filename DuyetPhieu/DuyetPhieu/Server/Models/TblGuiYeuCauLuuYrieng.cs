using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblGuiYeuCauLuuYrieng
    {
        public Guid? Stt { get; set; }
        public string SoBienNhan { get; set; }
        public DateTime? NgayGioGiao { get; set; }
        public string KhungGio { get; set; }
        public string Note { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string CreateByDuyet { get; set; }
        public DateTime? CreateDateDuyet { get; set; }
        public int? Flag { get; set; }
    }
}
