using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblBaoHanhOnlineDetail
    {
        public Guid Stt { get; set; }
        public string SoPhieu { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Serial { get; set; }
        public int Sl { get; set; }
        public string Nccid { get; set; }
        public string Note { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorMail { get; set; }
        public string Mc { get; set; }
        public string Mcname { get; set; }

        public virtual MnNcc Ncc { get; set; }
        public virtual TblBaoHanhOnline SoPhieuNavigation { get; set; }
    }
}
