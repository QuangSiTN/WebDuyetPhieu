using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class QuanHuyen
    {
        public string QuanHuyenId { get; set; }
        public string QuanHuyenName { get; set; }
        public string CityId { get; set; }
        public bool? Active { get; set; }
        public int? Ordinal { get; set; }
        public string DistrictIdEms { get; set; }
        public string SlugNameEms { get; set; }

        public virtual TinhThanh City { get; set; }
    }
}
