using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblLapDatCenter
    {
        public string Idlapdat { get; set; }
        public string SalesReceiptArising { get; set; }
        public string SalesReceiptId { get; set; }
        public string EmployeeDeliveryName { get; set; }
        public string Note { get; set; }
        public string Createby { get; set; }
        public string ComputerName { get; set; }
        public DateTime CreationDate { get; set; }
        public double? Quantity { get; set; }
        public string ItemName { get; set; }
        public string ItemId { get; set; }
        public string SiteId { get; set; }
        public decimal? ArisingMoney { get; set; }
        public decimal? WagesMoney { get; set; }
        public decimal? TotalAmount { get; set; }
        public string IdloaiMay { get; set; }
        public int? Status { get; set; }
        public int? StatusDichVu { get; set; }
        public int? StatusBaoCong { get; set; }
        public int? StatusHcKiemTra { get; set; }
        public bool? StatusTruKho { get; set; }
        public int? StatusCall { get; set; }
    }
}
