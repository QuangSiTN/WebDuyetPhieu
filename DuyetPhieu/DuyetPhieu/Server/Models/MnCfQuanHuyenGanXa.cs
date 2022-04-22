using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnCfQuanHuyenGanXa
    {
        public string DocumentId { get; set; }
        public string DistrictId { get; set; }
        public string WardId { get; set; }
        public int? KmMin { get; set; }
        public int? KmMax { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Creationdate { get; set; }
        public string SiteId { get; set; }
    }
}
