using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class SalesReceipt
    {
        public string SalesReceiptId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ShiftId { get; set; }
        public string CashierName { get; set; }
        public string CashierId { get; set; }
        public string EmployeeId { get; set; }
        public string StandId { get; set; }
        public string CustomerName { get; set; }
        public string PaymentModeId { get; set; }
        public string CreditCardId { get; set; }
        public string FccardId { get; set; }
        public float? FccardDiscPercent { get; set; }
        public byte? CreatedInvoiceStatus { get; set; }
        public byte? UpdateAccumulateStatus { get; set; }
        public string Description { get; set; }
        public decimal? ChangeAmt { get; set; }
        public byte? Status { get; set; }
        public byte? PaymentForm { get; set; }
        public byte? DeliveryForm { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string StorehouseId { get; set; }
        public bool? IsSuspended { get; set; }
        public bool? PaymentFinished { get; set; }
        public bool? ActualIssued { get; set; }
        public string SubUnitId { get; set; }
        public string DelivererId { get; set; }
        public string DeliveryAddress { get; set; }
        public string RecipientId { get; set; }
        public string SysStatus { get; set; }
        public DateTime? SysExportedDate { get; set; }
        public string SysExportedUserId { get; set; }
        public string HelpSubUnitId { get; set; }
        public string SysImportFrom { get; set; }
        public DateTime? SysImportDate { get; set; }
        public string SysImportUserId { get; set; }
        public DateTime? PaymentConfirmDate { get; set; }
        public string PaymentName { get; set; }
        public decimal? PaymentAmount { get; set; }
        public DateTime? RejectDate { get; set; }
        public string Rejectname { get; set; }
        public decimal? RejectAmount { get; set; }
        public string SiteId { get; set; }
        public decimal? TotalAmount { get; set; }
        public string EmployeeName { get; set; }
    }
}
