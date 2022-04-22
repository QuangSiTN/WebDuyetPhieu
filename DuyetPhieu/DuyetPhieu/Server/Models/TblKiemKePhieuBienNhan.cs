using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblKiemKePhieuBienNhan
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string InventoryPeriod { get; set; }
        public string SiteId { get; set; }
    }
}
