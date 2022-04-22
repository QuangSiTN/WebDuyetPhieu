using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblSiteWeb
    {
        public string SiteId { get; set; }
        public string SiteName { get; set; }
        public string Address { get; set; }
        public string DistrictId { get; set; }
        public string CityId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public bool Active { get; set; }
        public int? SiteVoucherId { get; set; }
        public string TaxCode { get; set; }
    }
}
