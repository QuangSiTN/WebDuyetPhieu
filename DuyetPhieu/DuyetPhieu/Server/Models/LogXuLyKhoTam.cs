using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogXuLyKhoTam
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string Note { get; set; }
        public string SiteId { get; set; }
        public int StatusKhoTam { get; set; }
        public int StatusDieuPhoi { get; set; }
        public DateTime CreateDay { get; set; }
        public string CreateBy { get; set; }
        public string ComputerName { get; set; }
        public string Ipaddress { get; set; }
    }
}
