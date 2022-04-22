using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblBilling
    {
        public string BillingId { get; set; }
        public string SerialNo { get; set; }
        public string InvoiceNum { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Vat { get; set; }
        public decimal? TotalBeforVat { get; set; }
        public decimal? TotalVat { get; set; }
        public decimal? ToTalAfterVat { get; set; }
        public string SaleRecieptId { get; set; }
        public string TaxCode { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public string PaymentForm { get; set; }
        public DateTime? BillingDate { get; set; }
        public string ComputerName { get; set; }
        public string UserName { get; set; }
        public int? Status { get; set; }
        public string CompanyName { get; set; }
        public DateTime? CreateDaySend { get; set; }
        public string SiteId { get; set; }
    }
}
