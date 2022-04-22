using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnTinhTrangBh
    {
        public MnTinhTrangBh()
        {
            TblBaoHanhNhatKies = new HashSet<TblBaoHanhNhatKy>();
        }

        public string TinhTrangId { get; set; }
        public string TinhTrang { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<TblBaoHanhNhatKy> TblBaoHanhNhatKies { get; set; }
    }
}
