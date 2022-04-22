using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnSiteAutoUpdate
    {
        public string SiteId { get; set; }
        public string SiteName { get; set; }
        public DateTime? CreateDay { get; set; }
    }
}
