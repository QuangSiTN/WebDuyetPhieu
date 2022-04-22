using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TempReportBaoHanhAll
    {
        public Guid Stt { get; set; }
        public string FromSloc { get; set; }
        public string ItemId { get; set; }
        public string SiteId { get; set; }
        public int? TonKhoSap { get; set; }
    }
}
