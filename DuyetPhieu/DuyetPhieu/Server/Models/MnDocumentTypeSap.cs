using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnDocumentTypeSap
    {
        public int Id { get; set; }
        public string Dcip { get; set; }
        public string Note { get; set; }
        public bool? Active { get; set; }
    }
}
