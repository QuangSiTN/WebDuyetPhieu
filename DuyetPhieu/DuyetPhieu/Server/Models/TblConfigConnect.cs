using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblConfigConnect
    {
        public string SiteId { get; set; }
        public string Server { get; set; }
        public string Uid { get; set; }
        public string Pass { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseNameDelivery { get; set; }
        public bool? Active { get; set; }
    }
}
