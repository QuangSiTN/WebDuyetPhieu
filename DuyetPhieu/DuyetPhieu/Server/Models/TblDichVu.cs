using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblDichVu
    {
        public string SoPhieuThu { get; set; }
        public string SoBienNhanCu { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanh { get; set; }
        public string MaNhanVien { get; set; }
        public string SiteId { get; set; }
        public decimal? ThuPhi { get; set; }
        public decimal? TongTien { get; set; }
        public int? Status { get; set; }
        public int? SoLanInPhieu { get; set; }
        public DateTime? NgayInPhieu { get; set; }
        public string Createby { get; set; }
        public string ComputerName { get; set; }
        public DateTime CreationDate { get; set; }
        public string SiteDeliveryId { get; set; }
        public int? CheckHelp { get; set; }
        public string Note { get; set; }
        public string SaleRecieptId { get; set; }
        public int? StatusSaleReciept { get; set; }
        public string SiteIdPos { get; set; }
    }
}
