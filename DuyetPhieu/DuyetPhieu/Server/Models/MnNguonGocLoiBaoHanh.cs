using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnNguonGocLoiBaoHanh
    {
        public string NguonGocLoiId { get; set; }
        public string DienGiai { get; set; }
        public bool Active { get; set; }
    }
}
