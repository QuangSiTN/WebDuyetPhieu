using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnWrtDinhmucbh
    {
        public string Documentid { get; set; }
        public string Vendorid { get; set; }
        public string Industryid { get; set; }
        public string Brandid { get; set; }
        public string ItemId { get; set; }
        public int? Warrantytime { get; set; }
        public int? Idtrttimeofsale { get; set; }
        public int? Idtrttimeofsloc { get; set; }
        public string Documentrequest { get; set; }
        public string Note { get; set; }
        public string UserName { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
