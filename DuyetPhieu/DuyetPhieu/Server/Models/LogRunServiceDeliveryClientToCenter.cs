using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogRunServiceDeliveryClientToCenter
    {
        public Guid Stt { get; set; }
        public DateTime DateRun { get; set; }
        public string SiteId { get; set; }
        public string IpServer { get; set; }
        public string ComputerName { get; set; }
    }
}
