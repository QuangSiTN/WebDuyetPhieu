using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnSendEmailName
    {
        public string SiteId { get; set; }
        public bool? Active { get; set; }
        public string Management { get; set; }
        public string KinhDoanh { get; set; }
        public string KeToan { get; set; }
        public string Kho { get; set; }
        public string Hcns { get; set; }
        public string It { get; set; }
        public string ThuNgan { get; set; }
        public string DieuPhoiCskh { get; set; }
        public string KinhDoanhOnline { get; set; }

        public virtual ChiNhanh Site { get; set; }
    }
}
