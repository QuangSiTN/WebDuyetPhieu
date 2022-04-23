using System;

namespace DuyetPhieu.Shared.Model.Details
{
	public class NhanVienModel
	{
        public Guid Stt { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string LuuY { get; set; }
        public string UserTao { get; set; }
        public string MaChiNhanh { get; set; }
        public int SoLanDi { get; set; }
        public int SoLuongPhieu { get; set; }
        public string MaBaCodeId { get; set; }
        public int Active { get; set; }
        public string CreateDate { get; set; }
        public int StatusOwe { get; set; }
        public int NgoaiLeDinhMucLuong { get; set; }
        public int StatusDichVu { get; set; }
        public string DepartMentId { get; set; }
        public string DepartMentName { get; set; }
    }
}
