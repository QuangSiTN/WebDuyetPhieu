using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class LogNvupdateGiaoHang
    {
        public Guid Stt { get; set; }
        public string SoBienNhan { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime? NgayGiaoNhan { get; set; }
        public string TinhThanh { get; set; }
        public string QuanHuyen { get; set; }
        public string UserId { get; set; }
        public string LuuY { get; set; }
        public string ThongTinXhd { get; set; }
        public DateTime? CreateDate { get; set; }
        public string TenKhachHang { get; set; }
    }
}
