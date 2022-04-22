using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblHienThiNoiDungThongBao
    {
        public Guid Stt { get; set; }
        public string Note { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDay { get; set; }
        public bool? Active { get; set; }
    }
}
