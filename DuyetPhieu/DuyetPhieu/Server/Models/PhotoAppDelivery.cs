using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class PhotoAppDelivery
    {
        public Guid Stt { get; set; }
        public string SaleReceiptId { get; set; }
        public string PhotoId { get; set; }
        public string Folder { get; set; }
        public string PhotoUuid { get; set; }
        public string PhotoUuidFull { get; set; }
        public string PhotoName { get; set; }
        public int? PhotoTypeId { get; set; }
        public int? ParentTypeId { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public bool? IsMainPhoto { get; set; }
        public int? SortOrder { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? CreateDate { get; set; }
        public string EmployeeId { get; set; }
    }
}
