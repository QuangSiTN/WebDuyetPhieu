using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblIteminMc
    {
        public string ItemId { get; set; }
        public string Mcid { get; set; }
        public string Description { get; set; }
        public string NganhHang { get; set; }
        public string BrandId { get; set; }
        public string VendorId { get; set; }
        public decimal? RetailPrice { get; set; }
    }
}
