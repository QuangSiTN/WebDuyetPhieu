using System.Collections.Generic;

namespace DuyetPhieu.Shared.ChinhSuaDuLieu.In
{
	public class EmsDeNghiChinhSuaDuLieuInModel
	{
        public string SoChungTu { get; set; }
        public string LoaiChungTu { get; set; }
        public string ChungTuLq { get; set; }
        public  ICollection<UploadedFile> UrlAnh { get; set; }
        public string NguyeNhanLoi { get; set; }
        public string HinhThucChinhSua { get; set; }
        public string NoiDung { get; set; }
        public string CreatedBy { get; set; }
    }
}
