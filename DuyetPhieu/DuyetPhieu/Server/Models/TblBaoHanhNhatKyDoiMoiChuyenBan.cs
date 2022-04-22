using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblBaoHanhNhatKyDoiMoiChuyenBan
    {
        public string SttlinkDetail { get; set; }
        public string MaNhatKyBh { get; set; }
        public int Status { get; set; }
        public string Sto { get; set; }
        public string SiteId { get; set; }
        public string NoteSto { get; set; }
        public string CreateSto { get; set; }
        public DateTime? CreateDateSto { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public bool? Active { get; set; }
    }
}
