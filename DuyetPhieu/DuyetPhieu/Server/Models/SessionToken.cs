using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class SessionToken
    {
        public int SessionTokenId { get; set; }
        public string Token { get; set; }
        public DateTimeOffset ExpiredDay { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
