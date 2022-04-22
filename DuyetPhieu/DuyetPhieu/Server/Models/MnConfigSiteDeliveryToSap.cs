using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnConfigSiteDeliveryToSap
    {
        public string SiteIdDelivery { get; set; }
        public string SiteIdToSap { get; set; }
        public bool Active { get; set; }
    }
}
