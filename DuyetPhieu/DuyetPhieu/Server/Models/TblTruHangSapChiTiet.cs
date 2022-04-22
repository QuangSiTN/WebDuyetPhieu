using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblTruHangSapChiTiet
    {
        public Guid Stt { get; set; }
        public string KeyIdKhoTam { get; set; }
        public string SoBienNhan { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public int? Quantity { get; set; }
        public int? SlocSap { get; set; }
        public int? Status { get; set; }
        public string KeyId { get; set; }
        public string FromSloc { get; set; }
        public string ToSloc { get; set; }
    }
}
