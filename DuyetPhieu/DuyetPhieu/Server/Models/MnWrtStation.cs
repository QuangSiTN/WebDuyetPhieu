using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnWrtStation
    {
        public string DucumentId { get; set; }
        public string VendorIds { get; set; }
        public string Mchs { get; set; }
        public string WrtstationName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string Note { get; set; }
        public string CreaetedBy { get; set; }
        public DateTime? Creationdate { get; set; }
    }
}
