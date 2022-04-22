using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnNccnganhHang
    {
        public MnNccnganhHang()
        {
            MnNccs = new HashSet<MnNcc>();
        }

        public string NganhHangId { get; set; }
        public string NganhHangName { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDay { get; set; }
        public string CreateBy { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<MnNcc> MnNccs { get; set; }
    }
}
