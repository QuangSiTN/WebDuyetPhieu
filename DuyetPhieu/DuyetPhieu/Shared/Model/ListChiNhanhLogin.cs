using DuyetPhieu.Shared.Model.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyetPhieu.Shared.Model
{
	public class ListChiNhanhLogin
	{
		public int Error { get; set; }
		public string Message { get; set; }
		public virtual List<ChiNhanhLoginModel> Data { get; set; }
	}
}
