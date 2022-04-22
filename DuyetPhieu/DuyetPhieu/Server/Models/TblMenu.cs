using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblMenu
    {
        public string MenuId { get; set; }
        public int? MenuPosition { get; set; }
        public string MenuValue { get; set; }
        public string MenuFiliationId { get; set; }
        public string FormName { get; set; }
    }
}
