using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnWard
    {
        public string WardId { get; set; }
        public string WardName { get; set; }
        public string DistrictId { get; set; }
        public bool? Active { get; set; }
    }
}
