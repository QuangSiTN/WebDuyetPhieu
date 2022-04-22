using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnConnectAllSite
    {
        public string MaCn { get; set; }
        public string TenChiNhanh { get; set; }
        public string ServerAdd { get; set; }
        public string ConnectType { get; set; }
        public bool? ConnectMobiPhone { get; set; }
        public bool? ExecuteSql { get; set; }
        public string EmailItSite { get; set; }
        public string EmailKtHangHoaCn { get; set; }
    }
}
