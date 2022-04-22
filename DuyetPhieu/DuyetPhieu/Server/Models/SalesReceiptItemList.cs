using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class SalesReceiptItemList
    {
        public string SalesReceiptId { get; set; }
        public int? Ordinal { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string CategoryId { get; set; }
        public double? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public double? DiscPercent { get; set; }
        public decimal? Amount { get; set; }
        public string Notes { get; set; }
        public string ReservedStorehouseId { get; set; }
        public decimal? ActualIssuedQty { get; set; }
        public decimal? RejectQty { get; set; }
        public string StorehouseId { get; set; }
        public string StandName { get; set; }
        public decimal? ItemPrice { get; set; }
        public Guid SalesReceiptItemListId { get; set; }
        public string GhiChu { get; set; }
        public string UnitId { get; set; }
        public int? Vat { get; set; }
    }
}
