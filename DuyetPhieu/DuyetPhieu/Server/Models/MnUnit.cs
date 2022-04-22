using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class MnUnit
    {
        public MnUnit()
        {
            MnItemLists = new HashSet<MnItemList>();
        }

        public string UnitId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int? Ordinal { get; set; }

        public virtual ICollection<MnItemList> MnItemLists { get; set; }
    }
}
