using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class CskhThongTinGoiKhach
    {
        public string IdCalling { get; set; }
        public DateTime DateCalling { get; set; }
        public string NameCaller { get; set; }
        public string IdSaleReceipt { get; set; }
        public DateTime? DateBuying { get; set; }
        public string IdBranch { get; set; }
        public string TypeProduct { get; set; }
        public string IdProduct { get; set; }
        public string NameProduct { get; set; }
        public string NameGift { get; set; }
        public string NameCustomer { get; set; }
        public string AddressCustomer { get; set; }
        public string PhoneCustomer { get; set; }
        public string CellphoneCustomer { get; set; }
        public string NameDeliveryEmployee { get; set; }
        public string ServiceDeliveryEmployee { get; set; }
        public decimal? CostDeliveryEmployee { get; set; }
        public string Note { get; set; }
    }
}
