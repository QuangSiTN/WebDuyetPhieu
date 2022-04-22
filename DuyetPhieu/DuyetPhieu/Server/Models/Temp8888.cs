using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class Temp8888
    {
        public Guid Stt { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string SiteId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public string SoBienNhan { get; set; }
    }
}
