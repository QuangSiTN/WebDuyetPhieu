using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblItemName
    {
        public string ItemId { get; set; }
        public long? NumberId { get; set; }
        public string ItemName { get; set; }
        public string CategoryId { get; set; }
        public string Unit { get; set; }
        public string Note { get; set; }
        public bool Sell { get; set; }
        public decimal? SalePrice { get; set; }
        public string UnitPrice { get; set; }
        public string BarCode { get; set; }
        public int? ItemOrService { get; set; }
        public bool? Buy { get; set; }
        public string Vatid { get; set; }
    }
}
