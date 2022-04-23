using DuyetPhieu.Shared.Model.Details;
using System.Collections.Generic;

namespace DuyetPhieu.Shared.Model
{
	public class ListInformationChiNhanh
	{
		public int Error { get; set; }
		public string Message { get; set; }
		public virtual List<InformationChiNhanhModel> Data { get; set; }
	}
}
