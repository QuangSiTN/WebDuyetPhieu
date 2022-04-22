using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class NCfConfigConection
    {
        public string DocumentId { get; set; }
        public string ServerName { get; set; }
        public string Connection { get; set; }
        public string Note { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
