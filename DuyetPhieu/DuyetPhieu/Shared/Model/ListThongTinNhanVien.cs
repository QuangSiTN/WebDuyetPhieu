using DuyetPhieu.Shared.Model.Details;
using System.Collections.Generic;

namespace DuyetPhieu.Shared.Model
{
	public class ListThongTinNhanVien
	{
		public int Error { get; set; }
		public string Message { get; set; }
		public virtual List<ThongTinNhanVienModel> Data { get; set; }
	}
}
