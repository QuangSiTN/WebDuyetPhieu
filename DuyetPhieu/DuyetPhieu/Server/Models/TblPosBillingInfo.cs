using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblPosBillingInfo
    {
        public string SaleRecieptId { get; set; }
        public string CustomerName { get; set; }
        public string PaymentType { get; set; }
        public string CompanyName { get; set; }
        public string TaxCode { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UserName { get; set; }
    }
}
