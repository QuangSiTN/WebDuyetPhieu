using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnConfigDeliveryToPo
    {
        public string SiteId { get; set; }
        public string StoreId { get; set; }
        public bool? Active { get; set; }
    }
}
