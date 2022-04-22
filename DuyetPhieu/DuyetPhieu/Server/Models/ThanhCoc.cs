using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class ThanhCoc
    {
        public string SalesReceiptId { get; set; }
        public short Ordinal { get; set; }
        public string ForgCurrId { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal? ForgCurrAmt { get; set; }
        public decimal? LocalCurrAmt { get; set; }
        public DateTime PaymentDate { get; set; }
        public Guid SalesReceiptPaymentId { get; set; }
        public string ShiftId { get; set; }
        public string CashDrawerId { get; set; }
        public string CashierId { get; set; }
    }
}
