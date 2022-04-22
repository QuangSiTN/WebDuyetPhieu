using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TcSo
    {
        public Guid Id { get; set; }
        public string Sonumber { get; set; }
        public decimal? TongTien { get; set; }
        public string CreatedBy { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
