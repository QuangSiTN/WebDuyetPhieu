using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TinhThanh
    {
        public TinhThanh()
        {
            QuanHuyens = new HashSet<QuanHuyen>();
        }

        public string CityId { get; set; }
        public string CityName { get; set; }
        public bool? Active { get; set; }
        public int? Ordinal { get; set; }
        public string CodeEms { get; set; }
        public string SlugNameEms { get; set; }

        public virtual ICollection<QuanHuyen> QuanHuyens { get; set; }
    }
}
