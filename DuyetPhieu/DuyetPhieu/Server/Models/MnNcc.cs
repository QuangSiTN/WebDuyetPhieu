using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnNcc
    {
        public MnNcc()
        {
            TblBaoHanhOnlineDetails = new HashSet<TblBaoHanhOnlineDetail>();
        }

        public string Nccid { get; set; }
        public string Nccname { get; set; }
        public string NganhHangId { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public decimal? TienPhiCongTac { get; set; }
        public string WardId { get; set; }
        public string VerdorPosCenter { get; set; }
        public string SiteId { get; set; }

        public virtual MnNccnganhHang NganhHang { get; set; }
        public virtual ICollection<TblBaoHanhOnlineDetail> TblBaoHanhOnlineDetails { get; set; }
    }
}
