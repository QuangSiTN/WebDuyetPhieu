using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnLoaiDichVuBh
    {
        public MnLoaiDichVuBh()
        {
            TblThongTinBaoHanhDetails = new HashSet<TblThongTinBaoHanhDetail>();
        }

        public string MaLoaiDichVu { get; set; }
        public string TenLoaiDichVu { get; set; }
        public bool? Active { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<TblThongTinBaoHanhDetail> TblThongTinBaoHanhDetails { get; set; }
    }
}
