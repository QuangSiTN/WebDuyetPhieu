using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogXeNhanVien
    {
        public Guid Id { get; set; }
        public string MaId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Note { get; set; }
    }
}
