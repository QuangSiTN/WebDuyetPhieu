using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblNumberDistance
    {
        public Guid Stt { get; set; }
        public string EmployeeId { get; set; }
        public string SaleRecieptId { get; set; }
        public double? Distance { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDay { get; set; }
    }
}
