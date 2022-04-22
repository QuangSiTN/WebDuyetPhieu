using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnSloc
    {
        public string SiteDelivery { get; set; }
        public string SiteIdSap { get; set; }
        public string FromSloc { get; set; }
        public string ToSloc { get; set; }
        public string SlocName { get; set; }
        public int? Status { get; set; }
        public bool? Active { get; set; }
    }
}
