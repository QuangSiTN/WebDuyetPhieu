using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnItemListThuHoi
    {
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public bool? Active { get; set; }
    }
}
