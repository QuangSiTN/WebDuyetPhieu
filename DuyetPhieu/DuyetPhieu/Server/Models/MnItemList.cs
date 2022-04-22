using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnItemList
    {
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string UnitId { get; set; }
        public bool? IsSell { get; set; }
        public decimal? OrderPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int? Vat { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string CreateBy { get; set; }
        public bool? IsDel { get; set; }
        public string NganhHangId { get; set; }
        public string TheCaoId { get; set; }

        public virtual MnUnit Unit { get; set; }
    }
}
