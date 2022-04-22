using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblThongTinBaoHanhRutSto
    {
        public Guid Stt { get; set; }
        public string SiteFrom { get; set; }
        public string SiteTo { get; set; }
        public string Sloc { get; set; }
        public bool? Active { get; set; }
        public string Sto { get; set; }
        public string ActicleDoc { get; set; }
        public int StatusXuatHang { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
