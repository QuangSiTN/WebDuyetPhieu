using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblHinhAnh
    {
        public string SoBienNhan { get; set; }
        public byte[] HinhAnh { get; set; }
        public string Note { get; set; }
        public string SiteId { get; set; }
        public string Createby { get; set; }
        public string ComputerName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DateGiao { get; set; }
        public int? Time0811 { get; set; }
        public int? Time1112 { get; set; }
        public int? Time1213 { get; set; }
        public int? Time1314 { get; set; }
        public int? Time1415 { get; set; }
        public int? Time1516 { get; set; }
        public int? Time1617 { get; set; }
        public int? Time1718 { get; set; }
        public int? Time1819 { get; set; }
        public int? Time1921 { get; set; }
        public int? Status { get; set; }
    }
}
