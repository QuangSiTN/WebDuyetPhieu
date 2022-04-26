using System.ComponentModel.DataAnnotations;

namespace DuyetPhieu.Shared.ThongTinTiepNhan.Details
{
	public class ThongTinTiepNhanSearch
	{
		[Required]
		public string SoPhieuBienNhan { get; set; }
		public string TuNgay { get; set; }
		public string DenNgay { get; set; }
	}
}
