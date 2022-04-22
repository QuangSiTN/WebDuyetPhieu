using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblLockUser
    {
        public string MaChiNhanh { get; set; }
        public string TenDangNhap { get; set; }
        public int? LockedUser { get; set; }
    }
}
