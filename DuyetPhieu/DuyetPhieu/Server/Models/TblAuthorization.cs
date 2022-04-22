using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblAuthorization
    {
        public string AuthorizationId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MethodFullName { get; set; }
        public int? ModuleId { get; set; }
    }
}
