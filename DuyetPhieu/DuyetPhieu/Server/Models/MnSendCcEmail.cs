using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnSendCcEmail
    {
        public string SiteId { get; set; }
        public string EmailCc { get; set; }
        public string EmailBaoHanhHang { get; set; }
        public bool? Active { get; set; }
    }
}
