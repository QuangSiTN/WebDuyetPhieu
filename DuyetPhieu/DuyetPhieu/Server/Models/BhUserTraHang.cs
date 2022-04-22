using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class BhUserTraHang
    {
        public string UserId { get; set; }

        public virtual TblUser User { get; set; }
    }
}
