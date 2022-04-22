using System;
using System.Collections.Generic;

#nullable disable

namespace DuyetPhieu.Server.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblUserGroups = new HashSet<TblUserGroup>();
        }

        public string MaChiNhanh { get; set; }
        public string TenNguoiDung { get; set; }
        public string TenDangNhap { get; set; }
        public string DienThoai { get; set; }
        public string Pass { get; set; }
        public string PhanCa { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? LockedUser { get; set; }
        public DateTime? LockedDate { get; set; }
        public string LockedReason { get; set; }
        public string IpAddress { get; set; }
        public string Versions { get; set; }
        public string VersionNew { get; set; }
        public bool? LoginActive { get; set; }
        public int? StatusLogin { get; set; }
        public string Agent { get; set; }
        public string Ipserver { get; set; }
        public string PhoneServerPort { get; set; }
        public string UserNamePhone { get; set; }
        public string PassPhone { get; set; }
        public string UserNameWebservicePhone { get; set; }
        public string PassWebSevicePhone { get; set; }
        public int? Status { get; set; }
        public string BoPhanId { get; set; }
        public int? IsAdmins { get; set; }
        public int? SoTrangInPhieuGiaoHang { get; set; }
        public string LoaiHangId { get; set; }
        public bool? KtSoLanNhapXe { get; set; }
        public string Email { get; set; }
        public string PassEmail { get; set; }
        public string HostEmail { get; set; }
        public bool? ActiveNutTraHangBaoHanh { get; set; }
        public bool? ActiveNutNganhHangNcc { get; set; }

        public virtual BhUserTraHang BhUserTraHang { get; set; }
        public virtual ICollection<TblUserGroup> TblUserGroups { get; set; }
    }
}
