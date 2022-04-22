using Microsoft.EntityFrameworkCore;
using DuyetPhieu.Server.Models;

#nullable disable

namespace DuyetPhieu.Server.Data
{
    public partial class DeleiveryDBContext : DbContext
    {
        public DeleiveryDBContext()
        {
        }

        public DeleiveryDBContext(DbContextOptions<DeleiveryDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaoTriXe> BaoTriXes { get; set; }
        public virtual DbSet<BarcodeBaoVeQuet> BarcodeBaoVeQuets { get; set; }
        public virtual DbSet<BarcodeSerial> BarcodeSerials { get; set; }
        public virtual DbSet<BhLogTraHangChiNhanh> BhLogTraHangChiNhanhs { get; set; }
        public virtual DbSet<BhUserTraHang> BhUserTraHangs { get; set; }
        public virtual DbSet<BienBanBanGiaoCuDoiMoi> BienBanBanGiaoCuDoiMois { get; set; }
        public virtual DbSet<ChiNhanh> ChiNhanhs { get; set; }
        public virtual DbSet<ChiPhi> ChiPhis { get; set; }
        public virtual DbSet<ChiTietGiaoNhan> ChiTietGiaoNhans { get; set; }
        public virtual DbSet<CskhBaoTriMayLanh> CskhBaoTriMayLanhs { get; set; }
        public virtual DbSet<CskhChatLuongPhucVu> CskhChatLuongPhucVus { get; set; }
        public virtual DbSet<CskhGoiPhieuHenKhach> CskhGoiPhieuHenKhaches { get; set; }
        public virtual DbSet<CskhGoiThongTinLapDat> CskhGoiThongTinLapDats { get; set; }
        public virtual DbSet<CskhKetQuaPhucVu> CskhKetQuaPhucVus { get; set; }
        public virtual DbSet<CskhKqpvbaoHanh> CskhKqpvbaoHanhs { get; set; }
        public virtual DbSet<CskhMaCode> CskhMaCodes { get; set; }
        public virtual DbSet<CskhNguonThongTin> CskhNguonThongTins { get; set; }
        public virtual DbSet<CskhNhanThongTinKh> CskhNhanThongTinKhs { get; set; }
        public virtual DbSet<CskhThongTinGoiKhach> CskhThongTinGoiKhaches { get; set; }
        public virtual DbSet<CskhThongTinPhanHoiKh> CskhThongTinPhanHoiKhs { get; set; }
        public virtual DbSet<CskhThongTinPhanHoiKhChiNhanh> CskhThongTinPhanHoiKhChiNhanhs { get; set; }
        public virtual DbSet<CskhXuLyTraHangChiNhanh> CskhXuLyTraHangChiNhanhs { get; set; }
        public virtual DbSet<DelDaXemSoanHang> DelDaXemSoanHangs { get; set; }
        public virtual DbSet<DsGiuHangTaoSto> DsGiuHangTaoStos { get; set; }
        public virtual DbSet<EmsChungtuxd> EmsChungtuxds { get; set; }
        public virtual DbSet<EmsDeNghiChinhSuaDuLieu> EmsDeNghiChinhSuaDuLieus { get; set; }
        public virtual DbSet<EmsLctxetduyet> EmsLctxetduyets { get; set; }
        public virtual DbSet<EmsLoaiPhieu> EmsLoaiPhieus { get; set; }
        public virtual DbSet<EmsNguoiDuyet> EmsNguoiDuyets { get; set; }
        public virtual DbSet<EmsNguyenNhanLoi> EmsNguyenNhanLois { get; set; }
        public virtual DbSet<HiddenUnit> HiddenUnits { get; set; }
        public virtual DbSet<HoaDonGiaoNhan> HoaDonGiaoNhans { get; set; }
        public virtual DbSet<KhoPhieuDieuChuyen> KhoPhieuDieuChuyens { get; set; }
        public virtual DbSet<KhoPhieuNhapXuat> KhoPhieuNhapXuats { get; set; }
        public virtual DbSet<KhoPhieuNhapXuatChiTiet> KhoPhieuNhapXuatChiTiets { get; set; }
        public virtual DbSet<KhoTonDau> KhoTonDaus { get; set; }
        public virtual DbSet<KhoXuatNhapTon> KhoXuatNhapTons { get; set; }
        public virtual DbSet<LogBaoHanhOnline> LogBaoHanhOnlines { get; set; }
        public virtual DbSet<LogBaoHanhSuaChua> LogBaoHanhSuaChuas { get; set; }
        public virtual DbSet<LogChuyenChiNhanhGiaoHo> LogChuyenChiNhanhGiaoHos { get; set; }
        public virtual DbSet<LogDeleteActicleDoc> LogDeleteActicleDocs { get; set; }
        public virtual DbSet<LogDuyetDinhMucLuong> LogDuyetDinhMucLuongs { get; set; }
        public virtual DbSet<LogDuyetThemSoLuongPhieu> LogDuyetThemSoLuongPhieus { get; set; }
        public virtual DbSet<LogDuyetVuotDinhMucVatTu> LogDuyetVuotDinhMucVatTus { get; set; }
        public virtual DbSet<LogNhanHangBaoHanhChiNhanh> LogNhanHangBaoHanhChiNhanhs { get; set; }
        public virtual DbSet<LogNvupdateGiaoHang> LogNvupdateGiaoHangs { get; set; }
        public virtual DbSet<LogPhieuDiGiaoHang> LogPhieuDiGiaoHangs { get; set; }
        public virtual DbSet<LogPrintNgoaiLeSbn> LogPrintNgoaiLeSbns { get; set; }
        public virtual DbSet<LogPrintThongTinSbn> LogPrintThongTinSbns { get; set; }
        public virtual DbSet<LogRunServiceDeliveryClientToCenter> LogRunServiceDeliveryClientToCenters { get; set; }
        public virtual DbSet<LogSendEmail> LogSendEmails { get; set; }
        public virtual DbSet<LogSerialInvoice> LogSerialInvoices { get; set; }
        public virtual DbSet<LogThaoTacSoPhieu> LogThaoTacSoPhieus { get; set; }
        public virtual DbSet<LogThucXuatD> LogThucXuatDs { get; set; }
        public virtual DbSet<LogTimeEmployee> LogTimeEmployees { get; set; }
        public virtual DbSet<LogTruHangBaoHanh> LogTruHangBaoHanhs { get; set; }
        public virtual DbSet<LogUserUse> LogUserUses { get; set; }
        public virtual DbSet<LogXacNhanCallPhieu> LogXacNhanCallPhieus { get; set; }
        public virtual DbSet<LogXacNhanCallPhieuThongTinBaoHanh> LogXacNhanCallPhieuThongTinBaoHanhs { get; set; }
        public virtual DbSet<LogXacNhanPhiPhatSinh> LogXacNhanPhiPhatSinhs { get; set; }
        public virtual DbSet<LogXeNhanVien> LogXeNhanViens { get; set; }
        public virtual DbSet<LogXuLyKhoTam> LogXuLyKhoTams { get; set; }
        public virtual DbSet<MnAutoSoPhu> MnAutoSoPhus { get; set; }
        public virtual DbSet<MnAutoStt> MnAutoStts { get; set; }
        public virtual DbSet<MnBoPhan> MnBoPhans { get; set; }
        public virtual DbSet<MnCfQuanHuyenGanXa> MnCfQuanHuyenGanXas { get; set; }
        public virtual DbSet<MnChiNhanhChuyenGiaoHo> MnChiNhanhChuyenGiaoHos { get; set; }
        public virtual DbSet<MnChuyenChiNhanhLayHang> MnChuyenChiNhanhLayHangs { get; set; }
        public virtual DbSet<MnChuyenSite> MnChuyenSites { get; set; }
        public virtual DbSet<MnConfigDeliveryToPo> MnConfigDeliveryToPos { get; set; }
        public virtual DbSet<MnConfigSiteDeliveryToSap> MnConfigSiteDeliveryToSaps { get; set; }
        public virtual DbSet<MnConnectAllSite> MnConnectAllSites { get; set; }
        public virtual DbSet<MnDinhMucLuong> MnDinhMucLuongs { get; set; }
        public virtual DbSet<MnDocumentTypeSap> MnDocumentTypeSaps { get; set; }
        public virtual DbSet<MnDongMoKyKiemKe> MnDongMoKyKiemKes { get; set; }
        public virtual DbSet<MnHuongXuLyBaoHanh> MnHuongXuLyBaoHanhs { get; set; }
        public virtual DbSet<MnItemList> MnItemLists { get; set; }
        public virtual DbSet<MnItemListThuHoi> MnItemListThuHois { get; set; }
        public virtual DbSet<MnKetQuaBaoHanhOnline> MnKetQuaBaoHanhOnlines { get; set; }
        public virtual DbSet<MnKhuVucGiaoHang> MnKhuVucGiaoHangs { get; set; }
        public virtual DbSet<MnKhungGio> MnKhungGios { get; set; }
        public virtual DbSet<MnLoaiDichVuBh> MnLoaiDichVuBhs { get; set; }
        public virtual DbSet<MnLoaiDichVuBhonline> MnLoaiDichVuBhonlines { get; set; }
        public virtual DbSet<MnLoaiHangBh> MnLoaiHangBhs { get; set; }
        public virtual DbSet<MnLoaiPhiLapDat> MnLoaiPhiLapDats { get; set; }
        public virtual DbSet<MnMaHangDichVuLapDat> MnMaHangDichVuLapDats { get; set; }
        public virtual DbSet<MnMaHangLapDat> MnMaHangLapDats { get; set; }
        public virtual DbSet<MnNVenDorEmail> MnNVenDorEmails { get; set; }
        public virtual DbSet<MnNcc> MnNccs { get; set; }
        public virtual DbSet<MnNccnganhHang> MnNccnganhHangs { get; set; }
        public virtual DbSet<MnNguonGocLoiBaoHanh> MnNguonGocLoiBaoHanhs { get; set; }
        public virtual DbSet<MnNhanPhieuBaoHanh> MnNhanPhieuBaoHanhs { get; set; }
        public virtual DbSet<MnNhanPhieuGiaoHo> MnNhanPhieuGiaoHos { get; set; }
        public virtual DbSet<MnNhanPhieuGiaoHoLoaiSp> MnNhanPhieuGiaoHoLoaiSps { get; set; }
        public virtual DbSet<MnNhanTuBh> MnNhanTuBhs { get; set; }
        public virtual DbSet<MnNhanVienTiepNhanBh> MnNhanVienTiepNhanBhs { get; set; }
        public virtual DbSet<MnPhiGiaoNhan> MnPhiGiaoNhans { get; set; }
        public virtual DbSet<MnPhieuBaoHanh> MnPhieuBaoHanhs { get; set; }
        public virtual DbSet<MnSapTrucTiep> MnSapTrucTieps { get; set; }
        public virtual DbSet<MnSapTrungGian> MnSapTrungGians { get; set; }
        public virtual DbSet<MnSendCcEmail> MnSendCcEmails { get; set; }
        public virtual DbSet<MnSendEmailName> MnSendEmailNames { get; set; }
        public virtual DbSet<MnSiteAutoUpdate> MnSiteAutoUpdates { get; set; }
        public virtual DbSet<MnSloc> MnSlocs { get; set; }
        public virtual DbSet<MnStandOpenPrint> MnStandOpenPrints { get; set; }
        public virtual DbSet<MnTheCao> MnTheCaos { get; set; }
        public virtual DbSet<MnThoiGianGiuHang> MnThoiGianGiuHangs { get; set; }
        public virtual DbSet<MnTienPhiLapDat> MnTienPhiLapDats { get; set; }
        public virtual DbSet<MnTinhTrangBh> MnTinhTrangBhs { get; set; }
        public virtual DbSet<MnUnit> MnUnits { get; set; }
        public virtual DbSet<MnVehicleCarId> MnVehicleCarIds { get; set; }
        public virtual DbSet<MnVersionApp> MnVersionApps { get; set; }
        public virtual DbSet<MnWard> MnWards { get; set; }
        public virtual DbSet<MnWrtDinhmucbh> MnWrtDinhmucbhs { get; set; }
        public virtual DbSet<MnWrtStation> MnWrtStations { get; set; }
        public virtual DbSet<NCfConfigConection> NCfConfigConections { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhiGiaoHang> PhiGiaoHangs { get; set; }
        public virtual DbSet<PhotoAppDelivery> PhotoAppDeliveries { get; set; }
        public virtual DbSet<QuanHuyen> QuanHuyens { get; set; }
        public virtual DbSet<SalesReceipt> SalesReceipts { get; set; }
        public virtual DbSet<SalesReceiptItemList> SalesReceiptItemLists { get; set; }
        public virtual DbSet<SalesReceiptPaymentList> SalesReceiptPaymentLists { get; set; }
        public virtual DbSet<SessionToken> SessionTokens { get; set; }
        public virtual DbSet<ShowDataCenter> ShowDataCenters { get; set; }
        public virtual DbSet<SmsConfigApp> SmsConfigApps { get; set; }
        public virtual DbSet<SmsLog> SmsLogs { get; set; }
        public virtual DbSet<SmsSend> SmsSends { get; set; }
        public virtual DbSet<StoNumber> StoNumbers { get; set; }
        public virtual DbSet<TblAdressMap> TblAdressMaps { get; set; }
        public virtual DbSet<TblAuthorization> TblAuthorizations { get; set; }
        public virtual DbSet<TblBaoHanhCall> TblBaoHanhCalls { get; set; }
        public virtual DbSet<TblBaoHanhGuiHang> TblBaoHanhGuiHangs { get; set; }
        public virtual DbSet<TblBaoHanhGuiHangDetail> TblBaoHanhGuiHangDetails { get; set; }
        public virtual DbSet<TblBaoHanhGuiNcc> TblBaoHanhGuiNccs { get; set; }
        public virtual DbSet<TblBaoHanhLuuY> TblBaoHanhLuuYs { get; set; }
        public virtual DbSet<TblBaoHanhNhatKy> TblBaoHanhNhatKies { get; set; }
        public virtual DbSet<TblBaoHanhNhatKyDoiMoiChuyenBan> TblBaoHanhNhatKyDoiMoiChuyenBans { get; set; }
        public virtual DbSet<TblBaoHanhOnline> TblBaoHanhOnlines { get; set; }
        public virtual DbSet<TblBaoHanhOnlineDetail> TblBaoHanhOnlineDetails { get; set; }
        public virtual DbSet<TblBaoHanhOnlineHuongXuLy> TblBaoHanhOnlineHuongXuLies { get; set; }
        public virtual DbSet<TblBaoHanhOnlineTinhPhi> TblBaoHanhOnlineTinhPhis { get; set; }
        public virtual DbSet<TblBilling> TblBillings { get; set; }
        public virtual DbSet<TblChapNhanGiaoSbn> TblChapNhanGiaoSbns { get; set; }
        public virtual DbSet<TblChiNhanhCuocPhi> TblChiNhanhCuocPhis { get; set; }
        public virtual DbSet<TblChiTietDichVu> TblChiTietDichVus { get; set; }
        public virtual DbSet<TblConfigConnect> TblConfigConnects { get; set; }
        public virtual DbSet<TblConnectIndexlivingmall> TblConnectIndexlivingmalls { get; set; }
        public virtual DbSet<TblDanhSachSoanHangChuanBiGiao> TblDanhSachSoanHangChuanBiGiaos { get; set; }
        public virtual DbSet<TblDichVu> TblDichVus { get; set; }
        public virtual DbSet<TblDoiHangLoiSto> TblDoiHangLoiStos { get; set; }
        public virtual DbSet<TblDuyetHuyGh> TblDuyetHuyGhs { get; set; }
        public virtual DbSet<TblGroup> TblGroups { get; set; }
        public virtual DbSet<TblGroupAuthorization> TblGroupAuthorizations { get; set; }
        public virtual DbSet<TblGroupUser> TblGroupUsers { get; set; }
        public virtual DbSet<TblGuiYeuCauLuuYrieng> TblGuiYeuCauLuuYriengs { get; set; }
        public virtual DbSet<TblHienThiNoiDungThongBao> TblHienThiNoiDungThongBaos { get; set; }
        public virtual DbSet<TblHinhAnh> TblHinhAnhs { get; set; }
        public virtual DbSet<TblIdtinhPhi> TblIdtinhPhis { get; set; }
        public virtual DbSet<TblInDuyetPhieu> TblInDuyetPhieus { get; set; }
        public virtual DbSet<TblInPhieu> TblInPhieus { get; set; }
        public virtual DbSet<TblItemName> TblItemNames { get; set; }
        public virtual DbSet<TblIteminMc> TblIteminMcs { get; set; }
        public virtual DbSet<TblKhoHangTam> TblKhoHangTams { get; set; }
        public virtual DbSet<TblKhoHangTamChiTiet> TblKhoHangTamChiTiets { get; set; }
        public virtual DbSet<TblKhoHangTamLog> TblKhoHangTamLogs { get; set; }
        public virtual DbSet<TblKiemKePhieuBienNhan> TblKiemKePhieuBienNhans { get; set; }
        public virtual DbSet<TblLapDatCenter> TblLapDatCenters { get; set; }
        public virtual DbSet<TblLockUser> TblLockUsers { get; set; }
        public virtual DbSet<TblLogPhiGiaoNhan> TblLogPhiGiaoNhans { get; set; }
        public virtual DbSet<TblLuongGiaoNhan> TblLuongGiaoNhans { get; set; }
        public virtual DbSet<TblMc> TblMcs { get; set; }
        public virtual DbSet<TblMenu> TblMenus { get; set; }
        public virtual DbSet<TblMenuForm> TblMenuForms { get; set; }
        public virtual DbSet<TblMenuGroup> TblMenuGroups { get; set; }
        public virtual DbSet<TblMileageMap> TblMileageMaps { get; set; }
        public virtual DbSet<TblModule> TblModules { get; set; }
        public virtual DbSet<TblNDauKyDinhMucGn> TblNDauKyDinhMucGns { get; set; }
        public virtual DbSet<TblNumberDistance> TblNumberDistances { get; set; }
        public virtual DbSet<TblOidmap> TblOidmaps { get; set; }
        public virtual DbSet<TblParamater> TblParamaters { get; set; }
        public virtual DbSet<TblPhanCa> TblPhanCas { get; set; }
        public virtual DbSet<TblPhiGiaoNhan> TblPhiGiaoNhans { get; set; }
        public virtual DbSet<TblPhiGiaoNhanLapDat> TblPhiGiaoNhanLapDats { get; set; }
        public virtual DbSet<TblPhiGiaoNhanPhatSinh> TblPhiGiaoNhanPhatSinhs { get; set; }
        public virtual DbSet<TblPhiGiaoNhanPhatSinhRieng> TblPhiGiaoNhanPhatSinhRiengs { get; set; }
        public virtual DbSet<TblPhiGiaoNhanVeSinhMayLanh> TblPhiGiaoNhanVeSinhMayLanhs { get; set; }
        public virtual DbSet<TblPhiGiaoNhanXeTai> TblPhiGiaoNhanXeTais { get; set; }
        public virtual DbSet<TblPhieuBaoHanhHang> TblPhieuBaoHanhHangs { get; set; }
        public virtual DbSet<TblPhieuNhanTien> TblPhieuNhanTiens { get; set; }
        public virtual DbSet<TblPhucHoiTrangThaiPhieu> TblPhucHoiTrangThaiPhieus { get; set; }
        public virtual DbSet<TblPosBillingInfo> TblPosBillingInfos { get; set; }
        public virtual DbSet<TblReviewWeb> TblReviewWebs { get; set; }
        public virtual DbSet<TblSiteWeb> TblSiteWebs { get; set; }
        public virtual DbSet<TblSoLanDiLog> TblSoLanDiLogs { get; set; }
        public virtual DbSet<TblSoLanDiXeMay> TblSoLanDiceseMay { get; set; }
        public virtual DbSet<TblSoLanDiXeTai> TblSoLanDiceseTai { get; set; }
        public virtual DbSet<TblSoLanDiXeTaiNhanVien> TblSoLanDiceseTaiNhanVien { get; set; }
        public virtual DbSet<TblSoTrangIn> TblSoTrangIns { get; set; }
        public virtual DbSet<TblThongTinBaoHanh> TblThongTinBaoHanhs { get; set; }
        public virtual DbSet<TblThongTinBaoHanhChungTu> TblThongTinBaoHanhChungTus { get; set; }
        public virtual DbSet<TblThongTinBaoHanhDetail> TblThongTinBaoHanhDetails { get; set; }
        public virtual DbSet<TblThongTinBaoHanhPhuKien> TblThongTinBaoHanhPhuKiens { get; set; }
        public virtual DbSet<TblThongTinBaoHanhRutSto> TblThongTinBaoHanhRutStos { get; set; }
        public virtual DbSet<TblThongTinBaoHanhSto> TblThongTinBaoHanhStos { get; set; }
        public virtual DbSet<TblThongTinBaoHanhStoDetail> TblThongTinBaoHanhStoDetails { get; set; }
        public virtual DbSet<TblThongTinBaoHanhXuatDieuChuyen> TblThongTinBaoHanhXuatDieuChuyens { get; set; }
        public virtual DbSet<TblTraHangBaoHanh> TblTraHangBaoHanhs { get; set; }
        public virtual DbSet<TblTruHangSap> TblTruHangSaps { get; set; }
        public virtual DbSet<TblTruHangSapChiTiet> TblTruHangSapChiTiets { get; set; }
        public virtual DbSet<TblTruHangSapChiTietSto> TblTruHangSapChiTietStos { get; set; }
        public virtual DbSet<TblTruHangSapNote> TblTruHangSapNotes { get; set; }
        public virtual DbSet<TblTruHangSapNoteSto> TblTruHangSapNoteStos { get; set; }
        public virtual DbSet<TblTruHangSapReturn> TblTruHangSapReturns { get; set; }
        public virtual DbSet<TblTruHangSapSto> TblTruHangSapStos { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUser1> TblUser1s { get; set; }
        public virtual DbSet<TblUserGroup> TblUserGroups { get; set; }
        public virtual DbSet<TblUserGroupMenu> TblUserGroupMenus { get; set; }
        public virtual DbSet<TblUserIsadmin> TblUserIsadmins { get; set; }
        public virtual DbSet<TblVersionService> TblVersionServices { get; set; }
        public virtual DbSet<TblXacNhanLapDatThanhCong> TblXacNhanLapDatThanhCongs { get; set; }
        public virtual DbSet<TcSo> TcSos { get; set; }
        public virtual DbSet<Temp8888> Temp8888s { get; set; }
        public virtual DbSet<TempBcgiaoHangChuaThanhCoc> TempBcgiaoHangChuaThanhCocs { get; set; }
        public virtual DbSet<TempReportBaoHanh> TempReportBaoHanhs { get; set; }
        public virtual DbSet<TempReportBaoHanhAll> TempReportBaoHanhAlls { get; set; }
        public virtual DbSet<ThamSo> ThamSos { get; set; }
        public virtual DbSet<ThanhCoc> ThanhCocs { get; set; }
        public virtual DbSet<TinhThanh> TinhThanhs { get; set; }
        public virtual DbSet<TmpRc> TmpRcs { get; set; }
        public virtual DbSet<TmpSo> TmpSos { get; set; }
        public virtual DbSet<ViewLocThongTinGiaoHo1> ViewLocThongTinGiaoHo1s { get; set; }
        public virtual DbSet<ViewShowDataCenter> ViewShowDataCenters { get; set; }
        public virtual DbSet<Viewtinhtienxetai> Viewtinhtienxetais { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }
        public virtual DbSet<XeNhanVien> XeNhanViens { get; set; }
        public virtual DbSet<XeNhanVienGh> XeNhanVienGhs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.1.177;Initial Catalog=DELIVERYCENTER_032014;persist security info=True;user=sa;password=SaNow@#$_)122018|;Connection Timeout=10000;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BaoTriXe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BaoTriXe");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LyDo).HasColumnType("ntext");

                entity.Property(e => e.MaSoXe).HasMaxLength(10);

                entity.Property(e => e.NgayBd)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NgayBD");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NgayKT");
            });

            modelBuilder.Entity<BarcodeBaoVeQuet>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK_Bacode_BaoVeQuet");

                entity.ToTable("Barcode_BaoVeQuet");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("true phiếu hợp lệ, false phiếu đã xóa nhập lại");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.ThoiGianDi).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TrangThai).HasComment("trạng thái giao hộ ( 0 giao tại chi nhánh , 1 Giao Hộ)");
            });

            modelBuilder.Entity<BarcodeSerial>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Barcode_Serial");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("true phiếu hợp lệ, false phiếu đã xóa nhập lại");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDelete).HasMaxLength(50);

                entity.Property(e => e.Serial).HasMaxLength(500);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.ThoiGianDi).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TrangThai).HasComment("trạng thái giao hộ ( 0 giao tại chi nhánh , 1 Giao Hộ)");
            });

            modelBuilder.Entity<BhLogTraHangChiNhanh>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("bh_Log_TraHangChiNhanh");

                entity.HasIndex(e => e.SoPhieu, "Idlog");

                entity.HasIndex(e => new { e.MaXacNhanTraHang, e.SoPhieu, e.Serial, e.CreateBy }, "NonClusteredIndex-20180814-155644");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaXacNhanTraHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Nsx)
                    .HasMaxLength(100)
                    .HasColumnName("NSX");

                entity.Property(e => e.Serial).HasMaxLength(100);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 tiep nhan, 1 tra ve chi nhanh");

                entity.Property(e => e.TenHang).HasMaxLength(500);

                entity.Property(e => e.TenHangPk)
                    .HasMaxLength(500)
                    .HasColumnName("TenHangPK");
            });

            modelBuilder.Entity<BhUserTraHang>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("BH_UserTraHang");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.BhUserTraHang)
                    .HasForeignKey<BhUserTraHang>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BH_UserTraHang_tbl_User");
            });

            modelBuilder.Entity<BienBanBanGiaoCuDoiMoi>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("BienBanBanGiaoCuDoiMoi");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DienThoai)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaNhanVien)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenChuongTrinh).HasMaxLength(150);

                entity.Property(e => e.TenKhachHang)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.TenSanPhamThuHoi)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ChiNhanh>(entity =>
            {
                entity.HasKey(e => e.MaChiNhanh);

                entity.ToTable("ChiNhanh");

                entity.Property(e => e.MaChiNhanh).HasMaxLength(50);

                entity.Property(e => e.ActiveChuyenTruSap).HasComment("true cho chuyen tru Hang Ton SAP");

                entity.Property(e => e.ActiveNghiemThu)
                    .HasDefaultValueSql("((0))")
                    .HasComment("= 1 hệ thống tự động thêm vào tbl_XacNhanLapDatThanhCong");

                entity.Property(e => e.ActiveNhanBaoHanh).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActiveTraPhieu)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 cho chuyển phiếu về chi nhánh, 0 không cho chuyển phiếu");

                entity.Property(e => e.ActiveTruSap).HasComment("true được trừ giữ hàng tự động");

                entity.Property(e => e.ActiveTttn)
                    .HasColumnName("ActiveTTTN")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Xử lý hộ thông tin bảo hành online TTTN (thông tin tiếp nhận)");

                entity.Property(e => e.ActivieRutHang9036)
                    .HasDefaultValueSql("((0))")
                    .HasComment("true được phép đẩy xin giá bán tại chi nhánh");

                entity.Property(e => e.AddressSite).HasMaxLength(150);

                entity.Property(e => e.AutoSoPhu)
                    .HasDefaultValueSql("((0))")
                    .HasComment("true auto update tự động, false bình thường");

                entity.Property(e => e.ConvertSo).HasColumnName("ConvertSO");

                entity.Property(e => e.Load8888Pos)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 cho load pos chi nhanh, 0 là không load vì là kho");

                entity.Property(e => e.MaQuanHuyen).HasMaxLength(50);

                entity.Property(e => e.MaTinhThanh).HasMaxLength(50);

                entity.Property(e => e.MobiphoneSmshonDa)
                    .HasMaxLength(12)
                    .HasColumnName("MobiphoneSMSHonDa");

                entity.Property(e => e.MobiphoneSmstai)
                    .HasMaxLength(12)
                    .HasColumnName("MobiphoneSMSTai");

                entity.Property(e => e.SiteIdSap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SitePhone).HasMaxLength(50);

                entity.Property(e => e.Sto)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("STO")
                    .HasComment("= STO thì show hiển thị lên chọn chi nhánh Tạo STO, Null thì bt (kèm theo Active = 1)");

                entity.Property(e => e.TenChiNhanh).HasMaxLength(50);

                entity.Property(e => e.TruHangTonPos).HasColumnName("TruHangTonPOS");

                entity.Property(e => e.WardId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("WardID");
            });

            modelBuilder.Entity<ChiPhi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChiPhi");

                entity.Property(e => e.DienGiai).HasColumnType("ntext");

                entity.Property(e => e.MaCp).HasColumnName("MaCP");

                entity.Property(e => e.MaSoXe).HasMaxLength(10);

                entity.Property(e => e.NgayUng).HasColumnType("smalldatetime");

                entity.Property(e => e.SoCt)
                    .HasMaxLength(10)
                    .HasColumnName("SoCT");

                entity.Property(e => e.SoKm)
                    .HasMaxLength(10)
                    .HasColumnName("SoKM");
            });

            modelBuilder.Entity<ChiTietGiaoNhan>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK_ChiTietGiaoNhan1");

                entity.ToTable("ChiTietGiaoNhan");

                entity.HasIndex(e => e.DiaChi, "Search_index");

                entity.HasIndex(e => e.Mahang, "SelectIndex");

                entity.HasIndex(e => new { e.SoChiTiet, e.Mahang, e.TenHang }, "idxChiTietGN");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.C).HasDefaultValueSql("((0))");

                entity.Property(e => e.D).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.DienThoai).HasMaxLength(30);

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.Hs)
                    .HasColumnType("decimal(18, 7)")
                    .HasColumnName("HS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HsxTt)
                    .HasColumnType("decimal(18, 7)")
                    .HasColumnName("HSxTT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mahang).HasMaxLength(50);

                entity.Property(e => e.R).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlocId).HasMaxLength(50);

                entity.Property(e => e.SoChiTiet)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TenHang).HasMaxLength(100);

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.Property(e => e.Tl)
                    .HasColumnType("decimal(18, 7)")
                    .HasColumnName("TL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tt)
                    .HasColumnType("decimal(18, 7)")
                    .HasColumnName("TT")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CskhBaoTriMayLanh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cskh_BaoTriMayLanh");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaHang).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SiteTransfer).HasMaxLength(50);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("1 đã điện, 2 đã chuyển thông tin,3 đã nhận thông tin,4đã cho đi bảo trì, 5 đã về, 6 đã bảo trì hoàn tất");

                entity.Property(e => e.TenHang).HasMaxLength(500);

                entity.Property(e => e.TransferDay).HasColumnType("datetime");
            });

            modelBuilder.Entity<CskhChatLuongPhucVu>(entity =>
            {
                entity.ToTable("cskh_ChatLuongPhucVu");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<CskhGoiPhieuHenKhach>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("cskh_GoiPhieuHenKhach");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateByHandling).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateDateHandling).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.Sbn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SiteIdHandling).HasMaxLength(50);

                entity.Property(e => e.StatusCall)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 chưa gọi, 1 đã gọi");
            });

            modelBuilder.Entity<CskhGoiThongTinLapDat>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("cskh_GoiThongTinLapDat");

                entity.HasIndex(e => e.SaleReceipt, "IdSearchRe");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Charging)
                    .HasColumnType("money")
                    .HasComment("Thu Phí");

                entity.Property(e => e.ComputerName).HasMaxLength(100);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Getdate()");

                entity.Property(e => e.CreateId)
                    .HasMaxLength(50)
                    .HasColumnName("CreateID");

                entity.Property(e => e.Dgnvbh)
                    .HasColumnName("DGNVBH")
                    .HasComment("A = 1, B = 2 , C = 3");

                entity.Property(e => e.Dgnvgn)
                    .HasColumnName("DGNVGN")
                    .HasComment("A = 1, B = 2 , C = 3");

                entity.Property(e => e.Dgnvtn)
                    .HasColumnName("DGNVTN")
                    .HasComment("A = 1, B = 2 , C = 3");

                entity.Property(e => e.EmployeeName).HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.ResultsFor)
                    .HasMaxLength(500)
                    .HasComment("Kết Quả Phục Vụ");

                entity.Property(e => e.SaleReceipt).HasMaxLength(50);

                entity.Property(e => e.Serial).HasMaxLength(500);

                entity.Property(e => e.Status).HasComment("1 gọi lắp đặt, 2 gọi Bảo hành");

                entity.Property(e => e.UserHandling)
                    .HasMaxLength(500)
                    .HasComment("Hương");
            });

            modelBuilder.Entity<CskhKetQuaPhucVu>(entity =>
            {
                entity.ToTable("cskh_KetQuaPhucVu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<CskhKqpvbaoHanh>(entity =>
            {
                entity.HasKey(e => e.KetQuaId);

                entity.ToTable("cskh_KQPVBaoHanh");

                entity.Property(e => e.KetQuaId)
                    .HasMaxLength(50)
                    .HasColumnName("KetQuaID");

                entity.Property(e => e.NoiDung).HasMaxLength(500);
            });

            modelBuilder.Entity<CskhMaCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cskh_MaCode");

                entity.Property(e => e.Computer).HasMaxLength(100);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaCode).HasMaxLength(50);

                entity.Property(e => e.TimeOff).HasColumnType("datetime");

                entity.Property(e => e.TimeOn).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<CskhNguonThongTin>(entity =>
            {
                entity.ToTable("cskh_NguonThongTin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasComment("Mô tả nguồn thông tin");
            });

            modelBuilder.Entity<CskhNhanThongTinKh>(entity =>
            {
                entity.HasKey(e => e.SoPhu)
                    .HasName("PK_tbl_NhanThongTinKH");

                entity.ToTable("cskh_NhanThongTinKH");

                entity.Property(e => e.SoPhu).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChi).HasMaxLength(80);

                entity.Property(e => e.DienThoai).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.Huongxuly).HasMaxLength(200);

                entity.Property(e => e.KetQua).HasMaxLength(200);

                entity.Property(e => e.MaCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaCN");

                entity.Property(e => e.MaHang)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NgayMua).HasColumnType("datetime");

                entity.Property(e => e.NgayNhan).HasColumnType("datetime");

                entity.Property(e => e.NguonThongTin).HasMaxLength(100);

                entity.Property(e => e.NoiDung).HasMaxLength(150);

                entity.Property(e => e.SoPhieu).HasMaxLength(15);

                entity.Property(e => e.TenHang).HasMaxLength(100);

                entity.Property(e => e.TenKhach).HasMaxLength(80);

                entity.Property(e => e.TenNv)
                    .HasMaxLength(100)
                    .HasColumnName("TenNV");

                entity.Property(e => e.TenNvgoi)
                    .HasMaxLength(50)
                    .HasColumnName("TenNVGoi");

                entity.Property(e => e.ThuPhi).HasColumnType("money");

                entity.Property(e => e.TinhTrangSp)
                    .HasMaxLength(250)
                    .HasColumnName("TinhTrangSP");
            });

            modelBuilder.Entity<CskhThongTinGoiKhach>(entity =>
            {
                entity.HasKey(e => e.IdCalling);

                entity.ToTable("cskh_ThongTinGoiKhach");

                entity.Property(e => e.IdCalling)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("idCalling");

                entity.Property(e => e.AddressCustomer)
                    .HasMaxLength(100)
                    .HasColumnName("addressCustomer");

                entity.Property(e => e.CellphoneCustomer)
                    .HasMaxLength(20)
                    .HasColumnName("cellphoneCustomer");

                entity.Property(e => e.CostDeliveryEmployee)
                    .HasColumnType("money")
                    .HasColumnName("costDeliveryEmployee");

                entity.Property(e => e.DateBuying)
                    .HasColumnType("datetime")
                    .HasColumnName("dateBuying");

                entity.Property(e => e.DateCalling)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCalling")
                    .HasComment("N");

                entity.Property(e => e.IdBranch)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("idBranch");

                entity.Property(e => e.IdProduct)
                    .HasMaxLength(20)
                    .HasColumnName("idProduct");

                entity.Property(e => e.IdSaleReceipt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("idSaleReceipt");

                entity.Property(e => e.NameCaller)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nameCaller");

                entity.Property(e => e.NameCustomer)
                    .HasMaxLength(100)
                    .HasColumnName("nameCustomer");

                entity.Property(e => e.NameDeliveryEmployee)
                    .HasMaxLength(100)
                    .HasColumnName("nameDeliveryEmployee");

                entity.Property(e => e.NameGift)
                    .HasMaxLength(100)
                    .HasColumnName("nameGift");

                entity.Property(e => e.NameProduct)
                    .HasMaxLength(100)
                    .HasColumnName("nameProduct");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .HasColumnName("note");

                entity.Property(e => e.PhoneCustomer)
                    .HasMaxLength(20)
                    .HasColumnName("phoneCustomer");

                entity.Property(e => e.ServiceDeliveryEmployee)
                    .HasMaxLength(200)
                    .HasColumnName("serviceDeliveryEmployee");

                entity.Property(e => e.TypeProduct)
                    .HasMaxLength(20)
                    .HasColumnName("typeProduct");
            });

            modelBuilder.Entity<CskhThongTinPhanHoiKh>(entity =>
            {
                entity.ToTable("cskh_ThongTinPhanHoiKH");

                entity.HasIndex(e => new { e.TenNvgoi, e.NgayGoi }, "<Name of Missing Index, sysname,>");

                entity.HasIndex(e => new { e.SoPhieu, e.TenKhach, e.DiaChi, e.DienThoai, e.NgayGoi, e.TenNvgoi }, "idx_Search");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CachXuLy).HasMaxLength(200);

                entity.Property(e => e.ChatLuongPv)
                    .HasMaxLength(50)
                    .HasColumnName("ChatLuongPV");

                entity.Property(e => e.Dgnvbh)
                    .HasColumnName("DGNVBH")
                    .HasComment("A+ = 1, A = 2 , B+ = 3 , B = 4");

                entity.Property(e => e.Dgnvgn)
                    .HasColumnName("DGNVGN")
                    .HasComment("A+ = 1, A = 2 , B+ = 3 , B = 4");

                entity.Property(e => e.Dgnvtn).HasColumnName("DGNVTN");

                entity.Property(e => e.DiaChi).HasMaxLength(80);

                entity.Property(e => e.DienThoai).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.KetQua).HasMaxLength(200);

                entity.Property(e => e.MaCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaCN");

                entity.Property(e => e.MaCode).HasMaxLength(50);

                entity.Property(e => e.NgayGoi).HasColumnType("datetime");

                entity.Property(e => e.NgayMua).HasColumnType("datetime");

                entity.Property(e => e.Serial).HasMaxLength(245);

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.StatusIndex).HasComment("0 & Null chợ lớn, 1 index");

                entity.Property(e => e.TenKhach).HasMaxLength(80);

                entity.Property(e => e.TenNv)
                    .HasMaxLength(100)
                    .HasColumnName("TenNV");

                entity.Property(e => e.TenNvgoi)
                    .HasMaxLength(50)
                    .HasColumnName("TenNVGoi")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ThuPhi)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CskhThongTinPhanHoiKhChiNhanh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cskh_ThongTinPhanHoiKH_ChiNhanh");

                entity.Property(e => e.CachXuLy).HasMaxLength(200);

                entity.Property(e => e.DiaChi).HasMaxLength(80);

                entity.Property(e => e.DienThoai).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Kdban).HasColumnName("KDBan");

                entity.Property(e => e.KetQua).HasMaxLength(200);

                entity.Property(e => e.MaCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaCN");

                entity.Property(e => e.NgayGoi).HasColumnType("datetime");

                entity.Property(e => e.NgayMua).HasColumnType("datetime");

                entity.Property(e => e.SanPham01).HasMaxLength(200);

                entity.Property(e => e.SanPham02).HasMaxLength(200);

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TenKhach).HasMaxLength(80);

                entity.Property(e => e.TenNv)
                    .HasMaxLength(100)
                    .HasColumnName("TenNV");

                entity.Property(e => e.TenNvgoi)
                    .HasMaxLength(50)
                    .HasColumnName("TenNVGoi");

                entity.Property(e => e.ThuPhi).HasColumnType("money");
            });

            modelBuilder.Entity<CskhXuLyTraHangChiNhanh>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("cskh_XuLyTraHangChiNhanh");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);
            });

            modelBuilder.Entity<DelDaXemSoanHang>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Del_DaXemSoanHang");

                entity.HasIndex(e => e.SoBienNhan, "SoBienNhan");

                entity.HasIndex(e => new { e.SiteId, e.Status, e.CreateDate }, "indSearch");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress).HasMaxLength(150);

                entity.Property(e => e.MaHang).HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 mặc định");
            });

            modelBuilder.Entity<DsGiuHangTaoSto>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Ds_GiuHangTaoSTO");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("true bình thường, false đã điều chuyển nơi lấy hủy con hàng đó.");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateByLoai).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateDateLoai).HasColumnType("datetime");

                entity.Property(e => e.KeyId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuayBan).HasMaxLength(50);

                entity.Property(e => e.SiteIdDelivery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteIdSap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("site Sap chi nhánh vs sitedelivery");

                entity.Property(e => e.SiteIdSto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteIdSTO")
                    .HasComment("SiteID gửi Tạo STO");

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SoChiTiet)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("0 trạng thái ban đầu để select tạo STO, 1 Đã Tạo STO, 2 Đã Trừ Hàng (Kế Thúc)");

                entity.Property(e => e.Sto)
                    .HasMaxLength(50)
                    .HasColumnName("STO");

                entity.Property(e => e.TenHang).HasMaxLength(150);
            });

            modelBuilder.Entity<EmsChungtuxd>(entity =>
            {
                entity.HasKey(e => e.MaGiaoDich)
                    .HasName("PK_A_CHUNGTUXD");

                entity.ToTable("EMS_CHUNGTUXD");

                entity.Property(e => e.MaGiaoDich).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.GoiDen).HasMaxLength(20);

                entity.Property(e => e.LoaiChungTu).HasMaxLength(12);

                entity.Property(e => e.Lydo).HasMaxLength(200);

                entity.Property(e => e.NgayGoi).HasColumnType("datetime");

                entity.Property(e => e.NgayThucHien).HasColumnType("datetime");

                entity.Property(e => e.SoChungTu).HasMaxLength(12);

                entity.Property(e => e.Status).HasComment("0 đang chờ xét duyệt, 1 duyệt cấp 1, 2 duyệt cấp 2, 100 duyệt hoàn thành 98 trả lại, 99 hủy");

                entity.Property(e => e.ThucHien).HasMaxLength(20);

                entity.Property(e => e.TongGiaTri)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThaiDuyet).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EmsDeNghiChinhSuaDuLieu>(entity =>
            {
                entity.HasKey(e => e.SoChungTu);

                entity.ToTable("EMS_DeNghiChinhSuaDuLieu");

                entity.Property(e => e.SoChungTu).HasMaxLength(12);

                entity.Property(e => e.ChungTuLq)
                    .HasMaxLength(50)
                    .HasColumnName("ChungTuLQ");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HinhThucChinhSua).HasMaxLength(100);

                entity.Property(e => e.LoaiChungTu).HasMaxLength(100);

                entity.Property(e => e.NguyeNhanLoi).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 mới khoi tao, 1 duyet cap 1, 2 dyet cap 2, 3 duyet cap 3... 100 chung tu da thuc hien, 99 hủy không duyệt");

                entity.Property(e => e.UrlAnh).HasMaxLength(200);
            });

            modelBuilder.Entity<EmsLctxetduyet>(entity =>
            {
                entity.HasKey(e => e.MaXetDuyet)
                    .HasName("PK_CTXETDUYET");

                entity.ToTable("EMS_LCTXETDUYET");

                entity.Property(e => e.MaXetDuyet).HasMaxLength(12);

                entity.Property(e => e.LoaiChungTu).HasMaxLength(12);

                entity.Property(e => e.MoTa).HasMaxLength(100);

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiTao).HasMaxLength(20);
            });

            modelBuilder.Entity<EmsLoaiPhieu>(entity =>
            {
                entity.HasKey(e => e.SoChungTu);

                entity.ToTable("EMS_LoaiPhieu");

                entity.Property(e => e.SoChungTu).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoaiPhieu).HasMaxLength(100);
            });

            modelBuilder.Entity<EmsNguoiDuyet>(entity =>
            {
                entity.ToTable("EMS_NguoiDuyet");

                entity.Property(e => e.Id)
                    .HasMaxLength(12)
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.DepartmenId).HasMaxLength(12);

                entity.Property(e => e.LoaiChungTu).HasMaxLength(12);

                entity.Property(e => e.Note).HasMaxLength(100);

                entity.Property(e => e.SiteId).HasMaxLength(12);

                entity.Property(e => e.UserId).HasMaxLength(20);
            });

            modelBuilder.Entity<EmsNguyenNhanLoi>(entity =>
            {
                entity.HasKey(e => e.SoChungTu);

                entity.ToTable("EMS_NguyenNhanLoi");

                entity.Property(e => e.SoChungTu).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoaiLoi).HasMaxLength(100);
            });

            modelBuilder.Entity<HiddenUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hidden_unit");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .HasColumnName("CustomerID");
            });

            modelBuilder.Entity<HoaDonGiaoNhan>(entity =>
            {
                entity.HasKey(e => e.SoBienNhan)
                    .IsClustered(false);

                entity.ToTable("HoaDonGiaoNhan");

                entity.HasIndex(e => new { e.TrangThaiGh, e.ChiNhanhGh, e.NgayGiaoNhan }, "IdSearch");

                entity.HasIndex(e => new { e.Status, e.TrangThaiGh, e.ChiNhanhGh, e.NgayTaoPhieu }, "IdSearch1");

                entity.HasIndex(e => new { e.Matx, e.NgayGiaoNhan, e.Status, e.SiteIdlayHang }, "IdSearch2");

                entity.HasIndex(e => new { e.TrangThaiGh, e.ThoiGianDi, e.Status, e.NgayTaoPhieu, e.Matx }, "IdSearchAct");

                entity.HasIndex(e => new { e.Status, e.TrangThaiGh, e.ChiNhanhGh, e.StatusSalesOrder }, "IdSearchGh");

                entity.HasIndex(e => e.DienThoai, "IdSearchPhone");

                entity.HasIndex(e => new { e.TienVeHet, e.ThoiGianVe, e.ChiNhanhGh, e.StatusCall, e.Serial }, "IdSearchSerial");

                entity.HasIndex(e => new { e.SiteIdlayHang, e.ThoiGianDi, e.Status }, "IdSearchSiteLayHang");

                entity.HasIndex(e => new { e.Status, e.LoaiXe }, "IdSearchStatus");

                entity.HasIndex(e => new { e.ChiNhanhGh, e.ThoiGianDi }, "IdSearchXeThue");

                entity.HasIndex(e => new { e.ChiNhanhGh, e.Status }, "IndSearch");

                entity.HasIndex(e => new { e.ChiNhanhGh, e.CreateDay }, "IndSearch2");

                entity.HasIndex(e => new { e.SiteId, e.TrangThaiGh, e.NgayTaoPhieu }, "IndSearchCall");

                entity.HasIndex(e => new { e.SiteIdlayHang, e.Matx, e.Status, e.NgayTaoPhieu }, "IndexSearch");

                entity.HasIndex(e => new { e.SiteId, e.NgayTaoPhieu, e.Matx }, "IndexSearch1");

                entity.HasIndex(e => new { e.Status, e.Matx }, "IndexSearch2");

                entity.HasIndex(e => new { e.SiteId, e.CreateDay }, "IndexSearch3");

                entity.HasIndex(e => new { e.SiteIdlayHang, e.Matx, e.Status, e.NgayTaoPhieu, e.MaNvbh }, "IndexSearch4");

                entity.HasIndex(e => e.NgayTaoPhieu, "IndexSearch5");

                entity.HasIndex(e => new { e.SiteId, e.NgayGiaoNhan, e.Status }, "IndexSearch6");

                entity.HasIndex(e => new { e.ThoiGianVe, e.TienVeHet, e.TrangThaiGh, e.Status, e.ChiNhanhGh }, "IndexSearch7");

                entity.HasIndex(e => e.NgayGiaoNhan, "IndexSearchNgayGiaoNhan");

                entity.HasIndex(e => e.ThoiGianVe, "IndexSearchThoigianve");

                entity.HasIndex(e => e.Serial, "IndexSerial");

                entity.HasIndex(e => e.StatusXinHang, "IndexStatusXinHang");

                entity.HasIndex(e => new { e.MaSoXe, e.Status, e.CreateDay }, "InxSelect");

                entity.HasIndex(e => e.Status, "IxdSearchStatus");

                entity.HasIndex(e => new { e.TienVeHet, e.ChiNhanhGh, e.Status, e.CreateDay }, "indSearch1");

                entity.Property(e => e.SoBienNhan).HasMaxLength(15);

                entity.Property(e => e.ActicleDoc)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChiNhanhGh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CMND");

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateDaySto)
                    .HasColumnType("datetime")
                    .HasColumnName("CreateDaySTO");

                entity.Property(e => e.CreateOutPutPbn)
                    .HasMaxLength(50)
                    .HasColumnName("CreateOutPutPBN");

                entity.Property(e => e.DanhGiaKhachHang).HasMaxLength(500);

                entity.Property(e => e.DiaChi).HasMaxLength(254);

                entity.Property(e => e.DienThoai).HasMaxLength(100);

                entity.Property(e => e.FiscalYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GiaoHangNhan)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 bình thương, 1 giao gấp");

                entity.Property(e => e.InvoiceNum).HasMaxLength(500);

                entity.Property(e => e.LoaiDichVu).HasMaxLength(100);

                entity.Property(e => e.LoaiXe).HasComment("0 Rong,1 Xe May, 2 Xe lon,3 xe may 1 xe,4 xe may 2 xe");

                entity.Property(e => e.LuuY).HasMaxLength(254);

                entity.Property(e => e.LuuYrieng)
                    .HasMaxLength(500)
                    .HasColumnName("LuuYRieng");

                entity.Property(e => e.MaKhungGio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.MaNhanVien2Xe).HasMaxLength(50);

                entity.Property(e => e.MaNvbh)
                    .HasMaxLength(50)
                    .HasColumnName("MaNVBH");

                entity.Property(e => e.MaSoXe).HasMaxLength(15);

                entity.Property(e => e.Matx)
                    .HasMaxLength(15)
                    .HasColumnName("MATX");

                entity.Property(e => e.NgayGiaoNhan).HasColumnType("datetime");

                entity.Property(e => e.NgayInPhieu).HasColumnType("datetime");

                entity.Property(e => e.NgayTaoPhieu).HasColumnType("datetime");

                entity.Property(e => e.NguoiTao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoiLayHang).HasMaxLength(150);

                entity.Property(e => e.NoteThongTinXhd)
                    .HasMaxLength(500)
                    .HasColumnName("NoteThongTinXHD");

                entity.Property(e => e.PhiHoSo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuanHuyen).HasMaxLength(50);

                entity.Property(e => e.Serial).HasMaxLength(100);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(20)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SiteIdlayHang)
                    .HasMaxLength(50)
                    .HasColumnName("SiteIDLayHang");

                entity.Property(e => e.SoChiTiet)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SoPhu)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasComment("0 giao hang chua ve,1 giao hang ve roi (Kết Thúc Phiếu),2 phieu bi huy,3 cap nhat so phu va in,5 Phiu tra hang, 6 tới nhà khách, 7 Phiếu Đẩy Online, 8 Đẩy Phiếu Giao Hộ, (9 Phiếu Nhân viên giao hàng Trả Lại,\r\n10 mobile Start, 11 mobile Tới Nhà Khách , 12 Tiếp nhận, 13 Xuất kho ==> ko Update) Mobile");

                entity.Property(e => e.StatusHoaDon).HasComment("1 PBN trả Hết Xuất Hóa Đơn, 2 PBN Trả Hết Không lấy HD, 3 PBN Cà Thẻ, 4 PBN Đặt cọc, 5 PBN TC Chuyển Khoảng");

                entity.Property(e => e.StatusOutPutPbn)
                    .HasColumnName("StatusOutPutPBN")
                    .HasDefaultValueSql("((0))")
                    .HasComment("1 trạng thái ra phiếu biên nhận, 0 chưa ra phiếu");

                entity.Property(e => e.StatusSalesOrder).HasComment("0 Bình Thường, 1 Sales Order, 3 Chuyển đổi SBN Sang SO");

                entity.Property(e => e.StatusXinHang)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 bình thường, 1 xin hàng");

                entity.Property(e => e.Stonumbers)
                    .HasMaxLength(50)
                    .HasColumnName("STONumbers");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TenKhachHang).HasMaxLength(150);

                entity.Property(e => e.TenNvbh)
                    .HasMaxLength(100)
                    .HasColumnName("TenNVBH");

                entity.Property(e => e.ThoiGianDi).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianVe).HasColumnType("datetime");

                entity.Property(e => e.ThuPhi).HasColumnType("money");

                entity.Property(e => e.TienDatCoc).HasColumnType("money");

                entity.Property(e => e.TienTraGop)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Ra phiếu trả góp 0 cọc, tiền cần phải thu góp");

                entity.Property(e => e.TienVeHet)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 tien chua ve het,1 tien ve het");

                entity.Property(e => e.TinhThanh).HasMaxLength(50);

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.Property(e => e.TrangThaiCskh)
                    .HasColumnName("TrangThaiCSKH")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 = Chua Duyet, 1 = Da Duyet");

                entity.Property(e => e.TrangThaiGh).HasComment("1 co giao ho,0 khong giao ho, 2 đợi duyệt lấy phiếu về");

                entity.Property(e => e.TrangThaiIn)
                    .HasMaxLength(50)
                    .HasColumnName("TrangThaiIN");

                entity.Property(e => e.WardId)
                    .HasMaxLength(12)
                    .HasColumnName("WardID");
            });

            modelBuilder.Entity<KhoPhieuDieuChuyen>(entity =>
            {
                entity.ToTable("Kho_PhieuDieuChuyen");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoLine)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FromSloc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemId).HasMaxLength(20);

                entity.Property(e => e.SoPhieu).HasMaxLength(30);

                entity.Property(e => e.ToSloc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.SoPhieuNavigation)
                    .WithMany(p => p.KhoPhieuDieuChuyens)
                    .HasForeignKey(d => d.SoPhieu)
                    .HasConstraintName("FK_Kho_PhieuDieuChuyen_Kho_PhieuNhapXuat");
            });

            modelBuilder.Entity<KhoPhieuNhapXuat>(entity =>
            {
                entity.HasKey(e => e.SoPhieu);

                entity.ToTable("Kho_PhieuNhapXuat");

                entity.HasIndex(e => new { e.MaChiNhanh, e.SoPo }, "IndexSearch1");

                entity.Property(e => e.SoPhieu).HasMaxLength(30);

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("true là phiếu chấp nhận, false phiếu loại bỏ");

                entity.Property(e => e.CreateBy).HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GhiChu).HasMaxLength(150);

                entity.Property(e => e.LoaiNx)
                    .HasMaxLength(1)
                    .HasColumnName("LoaiNX")
                    .HasComment("N Nhập , X Xuất");

                entity.Property(e => e.MaChiNhanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayPost).HasColumnType("date");

                entity.Property(e => e.SoPo)
                    .HasMaxLength(50)
                    .HasColumnName("SoPO");
            });

            modelBuilder.Entity<KhoPhieuNhapXuatChiTiet>(entity =>
            {
                entity.ToTable("Kho_PhieuNhapXuatChiTiet");

                entity.HasIndex(e => e.LoaiNx, "IndexSearch");

                entity.HasIndex(e => new { e.SoPhieu, e.LoaiNx }, "IndexSearch1");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.FromSloc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ItemName).HasMaxLength(150);

                entity.Property(e => e.LoaiNx)
                    .HasMaxLength(1)
                    .HasColumnName("LoaiNX")
                    .HasComment("N Nhập , X Xuất");

                entity.Property(e => e.MaPo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SlocSiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoLuong).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.Property(e => e.ToSloc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.SoPhieuNavigation)
                    .WithMany(p => p.KhoPhieuNhapXuatChiTiets)
                    .HasForeignKey(d => d.SoPhieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kho_PhieuNhapXuatChiTiet_Kho_PhieuNhapXuat");
            });

            modelBuilder.Entity<KhoTonDau>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.MaChiNhanh, e.SlocSiteId })
                    .HasName("PK_Kho_TonDau_1");

                entity.ToTable("Kho_TonDau");

                entity.Property(e => e.ItemId).HasMaxLength(20);

                entity.Property(e => e.MaChiNhanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlocSiteId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayTonDau).HasColumnType("date");

                entity.Property(e => e.SoLuong).HasColumnType("decimal(18, 1)");
            });

            modelBuilder.Entity<KhoXuatNhapTon>(entity =>
            {
                entity.HasKey(e => new { e.Ngay, e.Thang, e.Nam, e.ItemId, e.MaChiNhanh, e.SlocSiteId });

                entity.ToTable("Kho_XuatNhapTon");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(20)
                    .HasColumnName("ItemID");

                entity.Property(e => e.MaChiNhanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlocSiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhatSinhNhap).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.PhatSinhXuat).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.TonCuoi).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.TonDau).HasColumnType("decimal(18, 1)");
            });

            modelBuilder.Entity<LogBaoHanhOnline>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_BaoHanhOnline");

                entity.HasIndex(e => e.SoPhieu, "IndexSearch");

                entity.HasIndex(e => e.CreateBy, "IndexSearch1");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.KetQua).HasMaxLength(150);

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.SoPhieu).HasMaxLength(50);
            });

            modelBuilder.Entity<LogBaoHanhSuaChua>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_BaoHanhSuaChua");

                entity.HasIndex(e => e.Serial, "indserarch");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasMaxLength(50);

                entity.Property(e => e.MoTaLoi).HasMaxLength(500);

                entity.Property(e => e.NoiDung).HasMaxLength(500);

                entity.Property(e => e.Serial).HasMaxLength(100);

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.SoPhieu).HasMaxLength(500);

                entity.Property(e => e.TinhPhi).HasColumnType("money");
            });

            modelBuilder.Entity<LogChuyenChiNhanhGiaoHo>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_ChuyenChiNhanhGiaoHo");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LuuYcu)
                    .HasMaxLength(500)
                    .HasColumnName("LuuYCu");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.SiteChuyenDen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<LogDeleteActicleDoc>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Log_DeleteActicleDoc");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HuongXuLy).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 mặc định là đã gửi, 2 đã xác nhận duyệt");
            });

            modelBuilder.Entity<LogDuyetDinhMucLuong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("log_DuyetDinhMucLuong");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogDuyetThemSoLuongPhieu>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_DuyetThemSoLuongPhieu");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LogDuyetVuotDinhMucVatTu>(entity =>
            {
                entity.ToTable("log_DuyetVuotDinhMucVatTu");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.SlconLai)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("SLConLai");

                entity.Property(e => e.Slduyet).HasColumnName("SLDuyet");
            });

            modelBuilder.Entity<LogNhanHangBaoHanhChiNhanh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("log_NhanHangBaoHanhChiNhanh");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(20);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaHang).HasMaxLength(50);

                entity.Property(e => e.MoTaLoi).HasMaxLength(500);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Nsx)
                    .HasMaxLength(100)
                    .HasColumnName("NSX");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenHang).HasMaxLength(500);
            });

            modelBuilder.Entity<LogNvupdateGiaoHang>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_NVUpdateGiaoHang");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.DienThoai).HasMaxLength(500);

                entity.Property(e => e.LuuY).HasMaxLength(500);

                entity.Property(e => e.NgayGiaoNhan).HasColumnType("datetime");

                entity.Property(e => e.QuanHuyen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoBienNhan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenKhachHang).HasMaxLength(150);

                entity.Property(e => e.ThongTinXhd)
                    .HasMaxLength(500)
                    .HasColumnName("ThongTinXHD");

                entity.Property(e => e.TinhThanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<LogPhieuDiGiaoHang>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Log_PhieuDiGiaoHang");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KeyId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaNhanVien)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaSoXe)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LogPrintNgoaiLeSbn>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_PrintNgoaiLeSbn");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LogPrintThongTinSbn>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_PrintThongTinSBN");

                entity.HasIndex(e => new { e.SaleRecieptId, e.CreateDate, e.CreateBy }, "IdSearch");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SaleRecieptId)
                    .HasMaxLength(50)
                    .HasColumnName("SaleRecieptID");
            });

            modelBuilder.Entity<LogRunServiceDeliveryClientToCenter>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Log_RunServiceDeliveryClientToCenter");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateRun).HasColumnType("datetime");

                entity.Property(e => e.IpServer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LogSendEmail>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_SendEmail");

                entity.HasIndex(e => e.SoChungTu, "IndSearch");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cc)
                    .HasMaxLength(250)
                    .HasColumnName("CC");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.MaHang).HasMaxLength(50);

                entity.Property(e => e.MoTaLoi).HasMaxLength(250);

                entity.Property(e => e.Send).HasMaxLength(250);

                entity.Property(e => e.Serial).HasMaxLength(150);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SoChungTu).HasMaxLength(50);

                entity.Property(e => e.TenHang).HasMaxLength(150);
            });

            modelBuilder.Entity<LogSerialInvoice>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_Serial_Invoice");

                entity.HasIndex(e => e.SoBienNhan, "index_sbn");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer).HasMaxLength(100);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DanhGiaKhachHang).HasMaxLength(500);

                entity.Property(e => e.InvoiceNum).HasMaxLength(500);

                entity.Property(e => e.Serial).HasMaxLength(500);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);
            });

            modelBuilder.Entity<LogThaoTacSoPhieu>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__log_Thao__CA1EB6903DBE1285");

                entity.ToTable("log_ThaoTacSoPhieu");

                entity.HasIndex(e => new { e.MaSoXe, e.CreateDay }, "IndexSearch");

                entity.HasIndex(e => e.SoBienNhan, "index_sbn");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ma2Xe).HasMaxLength(50);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.MaSoXe).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.SoBienNhan)
                    .HasMaxLength(50)
                    .HasComment("= error là lỗi phát sinh khi đổ phiếu về.");

                entity.Property(e => e.Status).HasComment("In Phiếu Giao Hàng = ? số phiếu in");

                entity.Property(e => e.TrangThaiGh).HasColumnName("TrangThaiGH");
            });

            modelBuilder.Entity<LogThucXuatD>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_ThucXuatD");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Matx)
                    .HasMaxLength(50)
                    .HasColumnName("MATX");

                entity.Property(e => e.SalesReceiptId).HasMaxLength(50);
            });

            modelBuilder.Entity<LogTimeEmployee>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_TimeEmployee");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.StatusTime)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 nhan don 12 , 2 da lay hang 13, 3 dang giao  10, 4 toi nha khach 11");

                entity.Property(e => e.ThoiGian1)
                    .HasColumnType("datetime")
                    .HasComment("Tiếp Nhận");

                entity.Property(e => e.ThoiGian2)
                    .HasColumnType("datetime")
                    .HasComment("Xuất Kho");

                entity.Property(e => e.ThoiGian3)
                    .HasColumnType("datetime")
                    .HasComment("Bắt đầu giao");

                entity.Property(e => e.ThoiGian4)
                    .HasColumnType("datetime")
                    .HasComment("Tới nhà khách");

                entity.Property(e => e.ThoiGian5)
                    .HasColumnType("datetime")
                    .HasComment("Tới nhà khách");
            });

            modelBuilder.Entity<LogTruHangBaoHanh>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_TruHangBaoHanh");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ChungTuSap)
                    .HasMaxLength(50)
                    .HasColumnName("ChungTuSAP");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaHang).HasMaxLength(50);

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.TenHang).HasMaxLength(500);
            });

            modelBuilder.Entity<LogUserUse>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_User_Use");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer).HasMaxLength(100);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createby).HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("1 in phiếu đánh giá");
            });

            modelBuilder.Entity<LogXacNhanCallPhieu>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_XacNhanCallPhieu");

                entity.HasIndex(e => new { e.SiteId, e.CreateDate }, "IndexSearch");

                entity.HasIndex(e => e.CreateDate, "IndexSearch1");

                entity.HasIndex(e => e.SoBienNhan, "IxdSearch1");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.SoBienNhan).HasMaxLength(20);

                entity.Property(e => e.Status).HasComment("1 đã call , 3 Tự bấm số gọi, 0 bấm bỏ qua, null chưa gọi, 4 gọi lần 2");
            });

            modelBuilder.Entity<LogXacNhanCallPhieuThongTinBaoHanh>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_XacNhanCallPhieuThongTinBaoHanh");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.Point).HasComment("theo cấp độ 1-5");

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.SoPhieu).HasMaxLength(50);
            });

            modelBuilder.Entity<LogXacNhanPhiPhatSinh>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Log_XacNhanPhiPhatSinh");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 được tính phí, 1 đã tính phí");
            });

            modelBuilder.Entity<LogXeNhanVien>(entity =>
            {
                entity.ToTable("Log_Xe_NhanVien");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaId).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(150);
            });

            modelBuilder.Entity<LogXuLyKhoTam>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("log_XuLyKhoTam");

                entity.HasIndex(e => e.SoBienNhan, "NonClusteredIndex-20160219-110958");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StatusKhoTam).HasComment("1 Phiếu Nhập Kho, 2 Phiếu Xuất Kho, 3 Hoàn Kho Tổng");
            });

            modelBuilder.Entity<MnAutoSoPhu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MN_AutoSoPhu");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiteCnGiaoHo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MnAutoStt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mn_AutoSTT");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Stt).HasColumnName("STT");
            });

            modelBuilder.Entity<MnBoPhan>(entity =>
            {
                entity.HasKey(e => e.BoPhanId);

                entity.ToTable("MN_BoPhan");

                entity.Property(e => e.BoPhanId)
                    .HasMaxLength(50)
                    .HasColumnName("BoPhanID");

                entity.Property(e => e.LoaiHangId)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiHangID");

                entity.Property(e => e.TenBoPhan).HasMaxLength(500);
            });

            modelBuilder.Entity<MnCfQuanHuyenGanXa>(entity =>
            {
                entity.HasKey(e => new { e.DocumentId, e.SiteId })
                    .HasName("PK_MN_CF_QuanHuyenGanXa_1");

                entity.ToTable("MN_CF_QuanHuyenGanXa");

                entity.Property(e => e.DocumentId).HasMaxLength(12);

                entity.Property(e => e.SiteId).HasMaxLength(12);

                entity.Property(e => e.CreatedBy).HasMaxLength(12);

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DistrictId).HasMaxLength(12);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.WardId).HasMaxLength(12);
            });

            modelBuilder.Entity<MnChiNhanhChuyenGiaoHo>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.SiteChuyenId });

                entity.ToTable("MN_ChiNhanhChuyenGiaoHo");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SiteChuyenId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteChuyenID");

                entity.Property(e => e.TenChiNhanh)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<MnChuyenChiNhanhLayHang>(entity =>
            {
                entity.HasKey(e => e.SiteIdPos);

                entity.ToTable("MN_ChuyenChiNhanhLayHang");

                entity.Property(e => e.SiteIdPos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteIdDelivery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName).HasMaxLength(150);
            });

            modelBuilder.Entity<MnChuyenSite>(entity =>
            {
                entity.HasKey(e => new { e.SitePos, e.SiteDelivery });

                entity.ToTable("MN_ChuyenSite");

                entity.Property(e => e.SitePos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SitePOS");

                entity.Property(e => e.SiteDelivery)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteDELIVERY");

                entity.Property(e => e.TenChiNhanh).HasMaxLength(100);
            });

            modelBuilder.Entity<MnConfigDeliveryToPo>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.StoreId });

                entity.ToTable("MN_ConfigDeliveryToPos");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MnConfigSiteDeliveryToSap>(entity =>
            {
                entity.HasKey(e => e.SiteIdDelivery);

                entity.ToTable("MN_ConfigSiteDeliveryToSap");

                entity.Property(e => e.SiteIdDelivery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteIdToSap)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MnConnectAllSite>(entity =>
            {
                entity.HasKey(e => e.MaCn);

                entity.ToTable("MN_ConnectAllSite");

                entity.Property(e => e.MaCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaCN");

                entity.Property(e => e.ConnectType)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.EmailItSite).HasMaxLength(100);

                entity.Property(e => e.EmailKtHangHoaCn).HasMaxLength(150);

                entity.Property(e => e.ExecuteSql)
                    .HasColumnName("ExecuteSQL")
                    .HasComment("true dc phép execute - ko");

                entity.Property(e => e.ServerAdd).HasMaxLength(250);

                entity.Property(e => e.TenChiNhanh).HasMaxLength(50);
            });

            modelBuilder.Entity<MnDinhMucLuong>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.Status });

                entity.ToTable("MN_DinhMucLuong");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasComment("1 Nhân Viên, 2 Xe Tải");

                entity.Property(e => e.Kpi)
                    .HasColumnType("money")
                    .HasColumnName("KPI");

                entity.Property(e => e.LuongBaoHiem).HasColumnType("money");

                entity.Property(e => e.PcDienThoai).HasColumnType("money");

                entity.Property(e => e.PhanVung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhiGiaoThong).HasColumnType("money");

                entity.Property(e => e.TongThuNhap).HasColumnType("money");
            });

            modelBuilder.Entity<MnDocumentTypeSap>(entity =>
            {
                entity.ToTable("MN_DocumentType_SAP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Dcip)
                    .HasMaxLength(50)
                    .HasColumnName("DCIP");

                entity.Property(e => e.Note).HasMaxLength(50);
            });

            modelBuilder.Entity<MnDongMoKyKiemKe>(entity =>
            {
                entity.HasKey(e => new { e.KyKiemKe, e.SiteId });

                entity.ToTable("MN_DongMoKyKiemKe");

                entity.Property(e => e.KyKiemKe)
                    .HasMaxLength(50)
                    .HasComment("Thêm Mặc định 1 kỳ bất kỳ");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasComment("false là mở kỳ, true đóng kỳ để kiểm kê");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MnHuongXuLyBaoHanh>(entity =>
            {
                entity.HasKey(e => e.HuongXuLyId);

                entity.ToTable("MN_HuongXuLyBaoHanh");

                entity.Property(e => e.HuongXuLyId).HasMaxLength(50);

                entity.Property(e => e.HuongXuLy).HasMaxLength(150);
            });

            modelBuilder.Entity<MnItemList>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("MN_ItemList");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(20)
                    .HasColumnName("ItemID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.DateUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsSell).HasColumnName("isSell");

                entity.Property(e => e.ItemName).HasMaxLength(500);

                entity.Property(e => e.NganhHangId)
                    .HasMaxLength(50)
                    .HasColumnName("NganhHangID");

                entity.Property(e => e.OrderPrice).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.TheCaoId)
                    .HasMaxLength(50)
                    .HasComment("Tên loại thẻ cào");

                entity.Property(e => e.UnitId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.MnItemLists)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MN_ItemList_MN_Unit");
            });

            modelBuilder.Entity<MnItemListThuHoi>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("MN_ItemListThuHoi");

                entity.Property(e => e.ItemId).HasMaxLength(50);

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("true là ok, false đã loại");

                entity.Property(e => e.ItemName).HasMaxLength(150);
            });

            modelBuilder.Entity<MnKetQuaBaoHanhOnline>(entity =>
            {
                entity.HasKey(e => e.KetQuaId);

                entity.ToTable("MN_KetQuaBaoHanhOnline");

                entity.Property(e => e.KetQuaId).HasMaxLength(50);

                entity.Property(e => e.NoiDung).HasMaxLength(150);
            });

            modelBuilder.Entity<MnKhuVucGiaoHang>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.DistrictId });

                entity.ToTable("MN_KhuVucGiaoHang");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictId).HasMaxLength(50);
            });

            modelBuilder.Entity<MnKhungGio>(entity =>
            {
                entity.HasKey(e => e.MaKhungGio);

                entity.ToTable("mn_KhungGio");

                entity.Property(e => e.MaKhungGio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenKhungGio).HasMaxLength(50);
            });

            modelBuilder.Entity<MnLoaiDichVuBh>(entity =>
            {
                entity.HasKey(e => e.MaLoaiDichVu);

                entity.ToTable("MN_LoaiDichVuBH");

                entity.Property(e => e.MaLoaiDichVu).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.TenLoaiDichVu).HasMaxLength(500);
            });

            modelBuilder.Entity<MnLoaiDichVuBhonline>(entity =>
            {
                entity.HasKey(e => e.LoaiDichVuId);

                entity.ToTable("MN_LoaiDichVuBHOnline");

                entity.Property(e => e.LoaiDichVuId).HasMaxLength(50);

                entity.Property(e => e.TenLoaiDichVu).HasMaxLength(150);
            });

            modelBuilder.Entity<MnLoaiHangBh>(entity =>
            {
                entity.HasKey(e => e.LoaiHangId);

                entity.ToTable("MN_LoaiHangBH");

                entity.Property(e => e.LoaiHangId)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiHangID");

                entity.Property(e => e.GhiChu).HasMaxLength(245);

                entity.Property(e => e.KeyUpSerial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MCH");

                entity.Property(e => e.Samsung)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAMSUNG")
                    .HasComment("AV (Thiết bị nghe nhìn)\n\r\nACN (Máy lạnh)\n\r\nREF (Tủ lạnh)\n\r\nWSM (Máy Giặt)\r\n\nOthers (Mãy hút bụi, Lò vi sóng)\n\r\nQLED (Thiết bị nghe nhìn) \n\r\nWM (Máy Giặt)");

                entity.Property(e => e.TenLoaiHang).HasMaxLength(100);
            });

            modelBuilder.Entity<MnLoaiPhiLapDat>(entity =>
            {
                entity.HasKey(e => e.IdloaiMay);

                entity.ToTable("MN_LoaiPhiLapDat");

                entity.Property(e => e.IdloaiMay)
                    .HasMaxLength(50)
                    .HasColumnName("IDLoaiMay");

                entity.Property(e => e.Moneys).HasColumnType("money");

                entity.Property(e => e.NoiDung)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MnMaHangDichVuLapDat>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.ItemId });

                entity.ToTable("MN_MaHangDichVuLapDat");

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.ItemId).HasMaxLength(50);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemName).HasMaxLength(150);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.UnitId).HasMaxLength(50);
            });

            modelBuilder.Entity<MnMaHangLapDat>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("MN_MaHangLapDat");

                entity.HasIndex(e => new { e.ItemName, e.IdloaiMay }, "idxSearch");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .HasColumnName("ItemID");

                entity.Property(e => e.IdloaiMay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IDLoaiMay");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MnNVenDorEmail>(entity =>
            {
                entity.HasKey(e => e.VendorId);

                entity.ToTable("MN_N_VenDorEmail");

                entity.Property(e => e.VendorId).HasMaxLength(12);

                entity.Property(e => e.Mc)
                    .HasMaxLength(50)
                    .HasColumnName("MC");

                entity.Property(e => e.VendorName).HasMaxLength(100);
            });

            modelBuilder.Entity<MnNcc>(entity =>
            {
                entity.HasKey(e => e.Nccid);

                entity.ToTable("MN_NCC");

                entity.Property(e => e.Nccid)
                    .HasMaxLength(50)
                    .HasColumnName("NCCID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nccname)
                    .HasMaxLength(500)
                    .HasColumnName("NCCName");

                entity.Property(e => e.NganhHangId)
                    .HasMaxLength(50)
                    .HasColumnName("NganhHangID");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .HasComment("Tram co chi nhanh bao hanh");

                entity.Property(e => e.TienPhiCongTac)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VerdorPosCenter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((157))");

                entity.Property(e => e.WardId)
                    .HasMaxLength(12)
                    .HasColumnName("WardID");

                entity.HasOne(d => d.NganhHang)
                    .WithMany(p => p.MnNccs)
                    .HasForeignKey(d => d.NganhHangId)
                    .HasConstraintName("FK_MN_NCC_MN_NCCNganhHang");
            });

            modelBuilder.Entity<MnNccnganhHang>(entity =>
            {
                entity.HasKey(e => e.NganhHangId);

                entity.ToTable("MN_NCCNganhHang");

                entity.Property(e => e.NganhHangId)
                    .HasMaxLength(50)
                    .HasColumnName("NganhHangID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NganhHangName).HasMaxLength(500);

                entity.Property(e => e.Note).HasMaxLength(500);
            });

            modelBuilder.Entity<MnNguonGocLoiBaoHanh>(entity =>
            {
                entity.HasKey(e => e.NguonGocLoiId);

                entity.ToTable("MN_NguonGocLoiBaoHanh");

                entity.Property(e => e.NguonGocLoiId).HasMaxLength(50);

                entity.Property(e => e.DienGiai)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<MnNhanPhieuBaoHanh>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("MN_NhanPhieuBaoHanh");

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.Active).HasComment("true kiểm tra số lượng phiếu trong ngày, false là không kiểm tra ");

                entity.Property(e => e.NumberMax).HasComment("lớn hơn sẽ không được đẩy ngoại trừ trường hợp ngoại lệ");

                entity.Property(e => e.NumberMin).HasComment("dưới hoặc bằng số lượng thì đẩy bình thường, lớn hơn phải có duyệt và những con hàng A,U,B");

                entity.Property(e => e.NumberSum).HasComment("lớn hơn max và nhỏ hơn sum thì trường hợp ngoại lệ, lớn hơn sum là không thể đẩy");
            });

            modelBuilder.Entity<MnNhanPhieuGiaoHo>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("MN_NhanPhieuGiaoHo");

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.Active).HasComment("true kiểm tra số lượng phiếu trong ngày, false là không kiểm tra ");

                entity.Property(e => e.NumberMax).HasComment("lớn hơn sẽ không được đẩy ngoại trừ trường hợp ngoại lệ");

                entity.Property(e => e.NumberMin).HasComment("dưới hoặc bằng số lượng thì đẩy bình thường, lớn hơn phải có duyệt và những con hàng A,U,B");

                entity.Property(e => e.NumberSum).HasComment("lớn hơn max và nhỏ hơn sum thì trường hợp ngoại lệ, lớn hơn sum là không thể đẩy");
            });

            modelBuilder.Entity<MnNhanPhieuGiaoHoLoaiSp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MN_NhanPhieuGiaoHo_LoaiSP");

                entity.Property(e => e.LoaiSp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LoaiSP");
            });

            modelBuilder.Entity<MnNhanTuBh>(entity =>
            {
                entity.HasKey(e => e.MaThongTin);

                entity.ToTable("MN_NhanTuBH");

                entity.Property(e => e.MaThongTin).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.TenThongTin).HasMaxLength(150);
            });

            modelBuilder.Entity<MnNhanVienTiepNhanBh>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK_MN_NhanVienTiepNhanBH_1");

                entity.ToTable("MN_NhanVienTiepNhanBH");

                entity.HasIndex(e => new { e.MaNhanVien, e.TenNhanVien, e.SiteId }, "idx-search");

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.TenNhanVien)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MnPhiGiaoNhan>(entity =>
            {
                entity.HasKey(e => e.SoChungTu);

                entity.ToTable("MN_PhiGiaoNhan");

                entity.Property(e => e.SoChungTu).HasMaxLength(12);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NhomHang).HasMaxLength(12);

                entity.Property(e => e.PhiGiaoGan).HasColumnType("money");

                entity.Property(e => e.PhiGiaoXa).HasColumnType("money");

                entity.Property(e => e.PhiLapDat).HasColumnType("money");
            });

            modelBuilder.Entity<MnPhieuBaoHanh>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("MN_PhieuBaoHanh");

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.Active).HasComment("true kiểm tra số lượng phiếu trong ngày, false là không kiểm tra ");

                entity.Property(e => e.NumberMax).HasComment("lớn hơn sẽ không được đẩy ngoại trừ trường hợp ngoại lệ");

                entity.Property(e => e.NumberMin).HasComment("dưới hoặc bằng số lượng thì đẩy bình thường, lớn hơn phải có duyệt và những con hàng A,U,B");

                entity.Property(e => e.NumberSum).HasComment("lớn hơn max và nhỏ hơn sum thì trường hợp ngoại lệ, lớn hơn sum là không thể đẩy");
            });

            modelBuilder.Entity<MnSapTrucTiep>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.SiteIdLayHang })
                    .HasName("PK_MN_SAP_TrucThuoc");

                entity.ToTable("MN_SAP_TrucTiep");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .HasComment("Siteid delivery");

                entity.Property(e => e.SiteIdLayHang).HasMaxLength(50);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Note)
                    .HasMaxLength(150)
                    .HasComment("Tồn tại thì UB ngược lại thì UD");
            });

            modelBuilder.Entity<MnSapTrungGian>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.SiteIdTrungGian });

                entity.ToTable("MN_SAP_TrungGian");

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.SiteIdTrungGian).HasMaxLength(50);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Note).HasMaxLength(150);
            });

            modelBuilder.Entity<MnSendCcEmail>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("MN_SendCcEmail");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailBaoHanhHang).HasMaxLength(500);

                entity.Property(e => e.EmailCc)
                    .HasMaxLength(500)
                    .HasColumnName("EmailCC");
            });

            modelBuilder.Entity<MnSendEmailName>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("MN_SendEmailName");

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.DieuPhoiCskh)
                    .HasMaxLength(250)
                    .HasColumnName("DieuPhoi_Cskh");

                entity.Property(e => e.Hcns).HasMaxLength(250);

                entity.Property(e => e.It).HasMaxLength(250);

                entity.Property(e => e.KeToan).HasMaxLength(250);

                entity.Property(e => e.Kho).HasMaxLength(250);

                entity.Property(e => e.KinhDoanh).HasMaxLength(250);

                entity.Property(e => e.KinhDoanhOnline).HasMaxLength(250);

                entity.Property(e => e.Management).HasMaxLength(250);

                entity.Property(e => e.ThuNgan).HasMaxLength(250);

                entity.HasOne(d => d.Site)
                    .WithOne(p => p.MnSendEmailName)
                    .HasForeignKey<MnSendEmailName>(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MN_SendEmailName_ChiNhanh");
            });

            modelBuilder.Entity<MnSiteAutoUpdate>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("MN_SiteAutoUpdate");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MnSloc>(entity =>
            {
                entity.HasKey(e => new { e.SiteDelivery, e.SiteIdSap, e.FromSloc });

                entity.ToTable("MN_Sloc");

                entity.Property(e => e.SiteDelivery)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteIdSap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromSloc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 đang sử dụng, 0 không sử dụng");

                entity.Property(e => e.SlocName).HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("1 kho chính , 2 Quầy KM, 3 Quầy Bán Hàng, 4 dùng cho bảo hành");

                entity.Property(e => e.ToSloc)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MnStandOpenPrint>(entity =>
            {
                entity.HasKey(e => e.StandId);

                entity.ToTable("MN_StandOpenPrint");

                entity.Property(e => e.StandId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StandID")
                    .HasComment("Quầy hàng");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Note).HasMaxLength(100);
            });

            modelBuilder.Entity<MnTheCao>(entity =>
            {
                entity.HasKey(e => e.TheCaoId);

                entity.ToTable("MN_TheCao");

                entity.Property(e => e.TheCaoId)
                    .HasMaxLength(50)
                    .HasComment("Tên loại thẻ cào");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TenTheCao)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<MnThoiGianGiuHang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MN_ThoiGianGiuHang");
            });

            modelBuilder.Entity<MnTienPhiLapDat>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.IdloaiMay });

                entity.ToTable("MN_TienPhiLapDat");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdloaiMay)
                    .HasMaxLength(50)
                    .HasColumnName("IDLoaiMay");

                entity.Property(e => e.MoneyDichVu).HasColumnType("money");

                entity.Property(e => e.Moneys).HasColumnType("money");
            });

            modelBuilder.Entity<MnTinhTrangBh>(entity =>
            {
                entity.HasKey(e => e.TinhTrangId);

                entity.ToTable("MN_TinhTrangBH");

                entity.Property(e => e.TinhTrangId)
                    .HasMaxLength(50)
                    .HasColumnName("TinhTrangID");

                entity.Property(e => e.TinhTrang).HasMaxLength(200);
            });

            modelBuilder.Entity<MnUnit>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("MN_Unit");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(200);
            });

            modelBuilder.Entity<MnVehicleCarId>(entity =>
            {
                entity.HasKey(e => new { e.VehicleId, e.CarIdVietmap });

                entity.ToTable("MN_Vehicle_CarID");

                entity.Property(e => e.VehicleId)
                    .HasMaxLength(50)
                    .HasColumnName("VehicleID");

                entity.Property(e => e.CarIdVietmap)
                    .HasMaxLength(50)
                    .HasColumnName("CarID_VIETMAP");

                entity.Property(e => e.Oke)
                    .HasMaxLength(10)
                    .HasColumnName("OKE")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MnVersionApp>(entity =>
            {
                entity.HasKey(e => e.VersionId);

                entity.ToTable("MN_VersionApp");

                entity.Property(e => e.VersionId).HasMaxLength(50);

                entity.Property(e => e.LinkUpdate).HasMaxLength(150);

                entity.Property(e => e.VersionNo)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<MnWard>(entity =>
            {
                entity.HasKey(e => e.WardId);

                entity.ToTable("MN_Ward");

                entity.Property(e => e.WardId)
                    .HasMaxLength(12)
                    .HasColumnName("WardID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DistrictId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Mã quận/huyện");

                entity.Property(e => e.WardName).HasMaxLength(300);
            });

            modelBuilder.Entity<MnWrtDinhmucbh>(entity =>
            {
                entity.HasKey(e => e.Documentid);

                entity.ToTable("MN_WRT_DINHMUCBH");

                entity.Property(e => e.Documentid)
                    .HasMaxLength(50)
                    .HasColumnName("DOCUMENTID")
                    .HasComment("Ma chung tu");

                entity.Property(e => e.Brandid)
                    .HasMaxLength(50)
                    .HasColumnName("BRANDID")
                    .HasComment("THUONG HIEU");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Documentrequest)
                    .HasMaxLength(500)
                    .HasColumnName("DOCUMENTREQUEST")
                    .HasComment("Chứng từ yêu cầu phải có");

                entity.Property(e => e.Idtrttimeofsale)
                    .HasColumnName("IDTRTTIMEOFSALE")
                    .HasComment("thoi gian dc hang doi tra tinh tu ngay ban don tinh ngay");

                entity.Property(e => e.Idtrttimeofsloc)
                    .HasColumnName("IDTRTTIMEOFSLOC")
                    .HasComment("so ngay dc doi tra doi voi hang loi trong kho don vi tren ngay");

                entity.Property(e => e.Industryid)
                    .HasMaxLength(50)
                    .HasColumnName("INDUSTRYID")
                    .HasComment("MA NGANH HANG");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .HasComment("Mã hàng");

                entity.Property(e => e.UserName).HasMaxLength(200);

                entity.Property(e => e.Vendorid)
                    .HasMaxLength(50)
                    .HasColumnName("VENDORID")
                    .HasComment("MA NHA CUNG CAP");

                entity.Property(e => e.Warrantytime)
                    .HasColumnName("WARRANTYTIME")
                    .HasComment("thoi gian bao hanh tren thang");
            });

            modelBuilder.Entity<MnWrtStation>(entity =>
            {
                entity.HasKey(e => e.DucumentId);

                entity.ToTable("MN_WRT_Station");

                entity.Property(e => e.DucumentId)
                    .HasMaxLength(12)
                    .HasComment("Mã trạm bảo hành");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .HasComment("địa chỉ");

                entity.Property(e => e.CreaetedBy).HasMaxLength(20);

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(1000)
                    .HasComment("Email hãng");

                entity.Property(e => e.Mchs)
                    .HasMaxLength(1000)
                    .HasComment("Mã ngành hàng áp dụng cho trạm");

                entity.Property(e => e.Note).HasComment("Ghi chú");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasComment("điện thoại");

                entity.Property(e => e.VendorIds)
                    .HasMaxLength(1000)
                    .HasComment("Danh sách VendorId áp dụng cho trạm");

                entity.Property(e => e.WrtstationName)
                    .HasMaxLength(100)
                    .HasColumnName("WRTStationName")
                    .HasComment("Tên TRẠM BẢO HÀNH");
            });

            modelBuilder.Entity<NCfConfigConection>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("N_CF_ConfigConection");

                entity.Property(e => e.DocumentId).HasMaxLength(12);

                entity.Property(e => e.Connection).HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.ServerName).HasMaxLength(100);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK_NhanVien_1");

                entity.ToTable("NhanVien");

                entity.HasIndex(e => new { e.TenNhanVien, e.MaChiNhanh }, "NonClusteredIndex-20160324-103743");

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartMentId).HasMaxLength(50);

                entity.Property(e => e.DepartMentName).HasMaxLength(150);

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.DienThoai).HasMaxLength(50);

                entity.Property(e => e.LuuY).HasMaxLength(254);

                entity.Property(e => e.MaBaCodeId)
                    .HasMaxLength(20)
                    .HasColumnName("MaBaCodeID");

                entity.Property(e => e.MaChiNhanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgoaiLeDinhMucLuong)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 ko ngoại lệ, 1 ngoại lệ");

                entity.Property(e => e.StatusDichVu)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 bình thường, 1 là dịch vụ");

                entity.Property(e => e.StatusOwe)
                    .HasDefaultValueSql("((1))")
                    .HasComment("true bắt gàn buột nợ phiếu, false không gàn buột");

                entity.Property(e => e.Stt)
                    .HasColumnName("stt")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TenNhanVien).HasMaxLength(50);

                entity.Property(e => e.UserTao).HasMaxLength(20);
            });

            modelBuilder.Entity<PhiGiaoHang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PhiGiaoHang");

                entity.Property(e => e.BienPhi).HasMaxLength(20);

                entity.Property(e => e.GiaTri).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Stt)
                    .HasColumnName("stt")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<PhotoAppDelivery>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("PhotoAppDelivery");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasMaxLength(50);

                entity.Property(e => e.Folder).HasMaxLength(250);

                entity.Property(e => e.PhotoId).HasMaxLength(50);

                entity.Property(e => e.PhotoName).HasMaxLength(150);

                entity.Property(e => e.PhotoUuid).HasMaxLength(250);

                entity.Property(e => e.PhotoUuidFull).HasMaxLength(250);

                entity.Property(e => e.SaleReceiptId).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuanHuyen>(entity =>
            {
                entity.ToTable("QuanHuyen");

                entity.Property(e => e.QuanHuyenId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("QuanHuyenID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CityId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CityID");

                entity.Property(e => e.DistrictIdEms)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DistrictId_Ems");

                entity.Property(e => e.QuanHuyenName).HasMaxLength(100);

                entity.Property(e => e.SlugNameEms)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Slug_Name_Ems");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.QuanHuyens)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_QuanHuyen1_TinhThanh1");
            });

            modelBuilder.Entity<SalesReceipt>(entity =>
            {
                entity.ToTable("SalesReceipt");

                entity.Property(e => e.SalesReceiptId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SalesReceiptID");

                entity.Property(e => e.CashierId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CashierID");

                entity.Property(e => e.CashierName).HasMaxLength(50);

                entity.Property(e => e.ChangeAmt).HasColumnType("money");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreditCardId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CreditCardID");

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.DelivererId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DelivererID");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(500);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(254);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.FccardDiscPercent).HasColumnName("FCCardDiscPercent");

                entity.Property(e => e.FccardId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FCCardID");

                entity.Property(e => e.HelpSubUnitId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("HelpSubUnitID");

                entity.Property(e => e.PaymentAmount).HasColumnType("money");

                entity.Property(e => e.PaymentConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentModeId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PaymentModeID");

                entity.Property(e => e.PaymentName).HasMaxLength(50);

                entity.Property(e => e.RecipientId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RecipientID");

                entity.Property(e => e.RejectAmount).HasColumnType("money");

                entity.Property(e => e.RejectDate).HasColumnType("datetime");

                entity.Property(e => e.Rejectname).HasMaxLength(50);

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ShiftID");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.StandId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StandID");

                entity.Property(e => e.Status).HasComment("0 giao hang chua ve,1 giao hang ve roi,2 phieu bi huy");

                entity.Property(e => e.StorehouseId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StorehouseID");

                entity.Property(e => e.SubUnitId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SubUnitID");

                entity.Property(e => e.SysExportedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Sys_ExportedDate");

                entity.Property(e => e.SysExportedUserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Sys_ExportedUserID");

                entity.Property(e => e.SysImportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Sys_ImportDate");

                entity.Property(e => e.SysImportFrom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sys_ImportFrom");

                entity.Property(e => e.SysImportUserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Sys_ImportUserID");

                entity.Property(e => e.SysStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sys_Status");

                entity.Property(e => e.TotalAmount).HasColumnType("money");
            });

            modelBuilder.Entity<SalesReceiptItemList>(entity =>
            {
                entity.ToTable("SalesReceiptItemList");

                entity.Property(e => e.SalesReceiptItemListId)
                    .HasColumnName("SalesReceiptItemListID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActualIssuedQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Số lượng thực xuất");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID");

                entity.Property(e => e.DiscPercent).HasComment("Chiết khấu");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.ItemId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ItemID")
                    .HasComment("Mã hàng");

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.ItemPrice)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Giá lấy lên từ chính sách");

                entity.Property(e => e.Notes)
                    .HasMaxLength(254)
                    .HasComment("Thông tin ghi chú thêm");

                entity.Property(e => e.Ordinal).HasComment("Số thứ tự");

                entity.Property(e => e.Quantity).HasComment("Số lượng hàng mua");

                entity.Property(e => e.RejectQty)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("Số lượng bị trả lại");

                entity.Property(e => e.ReservedStorehouseId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ReservedStorehouseID")
                    .HasComment("Kho hàng dùng để dành riêng hàng");

                entity.Property(e => e.SalesReceiptId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SalesReceiptID")
                    .HasComment("Mã phiếu biên nhận");

                entity.Property(e => e.StandName).HasMaxLength(50);

                entity.Property(e => e.StorehouseId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StorehouseID")
                    .HasComment("Kho xuất hàng");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("money")
                    .HasComment("Đơn giá");
            });

            modelBuilder.Entity<SalesReceiptPaymentList>(entity =>
            {
                entity.HasKey(e => e.SalesReceiptPaymentId);

                entity.ToTable("SalesReceiptPaymentList");

                entity.Property(e => e.SalesReceiptPaymentId)
                    .HasColumnName("SalesReceiptPaymentID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CashDrawerId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CashDrawerID")
                    .HasComment("M? qu?y thu ngân = ComputerName");

                entity.Property(e => e.CashierId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CashierID")
                    .HasComment("M? nhân viên thu ngân");

                entity.Property(e => e.ExchangeRate).HasColumnType("money");

                entity.Property(e => e.ForgCurrAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Số tiền nguyên tệ mà khách hàng trả");

                entity.Property(e => e.ForgCurrId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ForgCurrID");

                entity.Property(e => e.LocalCurrAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Số tiền thanh toán nội địa");

                entity.Property(e => e.Ordinal).HasComment("Số thứ tự lần thanh toán");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày thanh toán");

                entity.Property(e => e.SalesReceiptId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SalesReceiptID");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ShiftID")
                    .HasComment("Ca bán hàng");

                entity.Property(e => e.TrangThaiThanhCoc).HasComment("0 chua lay ve, 1 da lay ve");
            });

            modelBuilder.Entity<SessionToken>(entity =>
            {
                entity.ToTable("SessionToken");

                entity.Property(e => e.Token).IsRequired();
            });

            modelBuilder.Entity<ShowDataCenter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ShowDataCenter");

                entity.Property(e => e.ChiNhanhGh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LuuY).HasMaxLength(254);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.MaSoXe).HasMaxLength(15);

                entity.Property(e => e.NgayGiaoNhan).HasColumnType("datetime");

                entity.Property(e => e.NgayTaoPhieu).HasColumnType("datetime");

                entity.Property(e => e.NhomNhanVien).HasMaxLength(255);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SoChiTiet)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SoPhu).HasMaxLength(75);

                entity.Property(e => e.TenKhachHang).HasMaxLength(150);

                entity.Property(e => e.TenNhanVien).HasMaxLength(50);

                entity.Property(e => e.ThoiGianDi).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianVe).HasColumnType("datetime");

                entity.Property(e => e.TienDatCoc).HasColumnType("money");

                entity.Property(e => e.TongTien).HasColumnType("money");
            });

            modelBuilder.Entity<SmsConfigApp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sms_ConfigApp");

                entity.Property(e => e.LinkSms).HasComment("NumberPhone thay thế số điện thoại, MessagesSend thông tin send");

                entity.Property(e => e.MessagesSend).HasComment("SoPhut  sẽ thay thế bằng số khi send");
            });

            modelBuilder.Entity<SmsLog>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("SMS_log");

                entity.HasIndex(e => new { e.Active, e.CreateDay }, "IndexSearch");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhoneNumber).HasMaxLength(12);

                entity.Property(e => e.Status).HasComment("0 gán nv đi - 1 gán nv về - 3 lỗi phát sinh, 4 sendsmspublic, 5 sms bảo hành");
            });

            modelBuilder.Entity<SmsSend>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("SMS_Send");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active).HasComment("true cho phép gửi, false ngược lại");

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.Property(e => e.TreeTop)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sto_Number");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .HasColumnName("ItemID");

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.Stonumbers)
                    .HasMaxLength(50)
                    .HasColumnName("STONumbers");

                entity.Property(e => e.ToSiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAdressMap>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_AdressMap");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("(newid)");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.District).HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.OnOff).HasComment("0 mở, 1 tắt");

                entity.Property(e => e.TimeGps).HasColumnName("TimeGPS");

                entity.Property(e => e.Way).HasMaxLength(100);
            });

            modelBuilder.Entity<TblAuthorization>(entity =>
            {
                entity.HasKey(e => e.AuthorizationId);

                entity.ToTable("tbl_Authorizations");

                entity.Property(e => e.AuthorizationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AuthorizationID")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã function, mã tự phát sinh để quản lý.");

                entity.Property(e => e.Description).HasComment("Các ghi chú, diễn giải khác của hàm.");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasComment("Mã FunctionGroup, xác định hàm này thuộc về FunctionGroup nào.");

                entity.Property(e => e.Title).HasComment("Tên hiển thị của hàm xử lý, dùng hiển thị trên giao diện người dùng. Phân biệt theo đa ngôn ngữ.");
            });

            modelBuilder.Entity<TblBaoHanhCall>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_BaoHanhCall");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.NgayGhi).HasColumnType("datetime");

                entity.Property(e => e.NoiDung).HasMaxLength(500);

                entity.Property(e => e.SoPhieu).HasMaxLength(50);

                entity.HasOne(d => d.SoPhieuNavigation)
                    .WithMany(p => p.TblBaoHanhCalls)
                    .HasForeignKey(d => d.SoPhieu)
                    .HasConstraintName("FK_tbl_BaoHanhCall_tbl_ThongTinBaoHanh");
            });

            modelBuilder.Entity<TblBaoHanhGuiHang>(entity =>
            {
                entity.HasKey(e => e.SoPhieu);

                entity.ToTable("tbl_BaoHanhGuiHang");

                entity.HasIndex(e => new { e.Active, e.Status, e.CreateDay }, "IdStatus");

                entity.HasIndex(e => new { e.Active, e.Status }, "IndexSearch");

                entity.HasIndex(e => new { e.MaNhanVien, e.Active, e.Status }, "IndexSearch1");

                entity.Property(e => e.SoPhieu).HasMaxLength(50);

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("false đã xóa, true bình thường");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(20);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.DienThoai).HasMaxLength(50);

                entity.Property(e => e.ErrorKhac).HasMaxLength(150);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID")
                    .HasComment("size chi nhánh xử lý");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("1 đã đi, 2 đã về");

                entity.Property(e => e.StatusLoiKt).HasColumnName("StatusLoiKT");

                entity.Property(e => e.TenTramBaoHanh).HasMaxLength(100);

                entity.Property(e => e.ThoiGianDi).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianVe).HasColumnType("datetime");

                entity.Property(e => e.TienPhiCtac)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblBaoHanhGuiHangDetail>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_BaoHanhGuiHangDetail");

                entity.HasIndex(e => e.SoPhieu, "IdSearchGuiHang");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MaHang).HasMaxLength(50);

                entity.Property(e => e.Serial).HasMaxLength(50);

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StatusLoaiPhieu).HasComment("1 Gửi hàng Bảo Hành, 2 Nhận Hàng Bảo Hành");

                entity.Property(e => e.TenHang).HasMaxLength(100);
            });

            modelBuilder.Entity<TblBaoHanhGuiNcc>(entity =>
            {
                entity.HasKey(e => e.MaGuiNcc);

                entity.ToTable("tbl_BaoHanhGuiNCC");

                entity.HasIndex(e => new { e.TenNcc, e.NoiDung, e.GhiChu, e.MaNvgui, e.CreateBy }, "idxNcc");

                entity.Property(e => e.MaGuiNcc)
                    .HasMaxLength(50)
                    .HasColumnName("MaGuiNCC");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.MaNvgui)
                    .HasMaxLength(50)
                    .HasColumnName("MaNVGui");

                entity.Property(e => e.NgayGui).HasColumnType("date");

                entity.Property(e => e.NoiDung).HasMaxLength(500);

                entity.Property(e => e.Status).HasComment("0 NCC, 1 Kỹ Thuật CN");

                entity.Property(e => e.TenNcc)
                    .HasMaxLength(500)
                    .HasColumnName("TenNCC");
            });

            modelBuilder.Entity<TblBaoHanhLuuY>(entity =>
            {
                entity.HasKey(e => e.LuuYid);

                entity.ToTable("tbl_BaoHanhLuuY");

                entity.Property(e => e.LuuYid)
                    .HasMaxLength(50)
                    .HasColumnName("LuuYID");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.NgayGhi).HasColumnType("datetime");

                entity.Property(e => e.NoiDung).HasMaxLength(500);

                entity.Property(e => e.SoPhieu).HasMaxLength(50);

                entity.Property(e => e.Stt)
                    .HasMaxLength(100)
                    .HasColumnName("STT");

                entity.HasOne(d => d.SoPhieuNavigation)
                    .WithMany(p => p.TblBaoHanhLuuYs)
                    .HasForeignKey(d => d.SoPhieu)
                    .HasConstraintName("FK_tbl_BaoHanhLuuY_tbl_ThongTinBaoHanh");
            });

            modelBuilder.Entity<TblBaoHanhNhatKy>(entity =>
            {
                entity.HasKey(e => e.MaNhatKyBh);

                entity.ToTable("tbl_BaoHanhNhatKy");

                entity.HasIndex(e => new { e.TienThuKh, e.CreateDay }, "IdSp");

                entity.Property(e => e.MaNhatKyBh)
                    .HasMaxLength(50)
                    .HasColumnName("MaNhatKyBH");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.MaHang).HasMaxLength(50);

                entity.Property(e => e.NgayNhan).HasColumnType("date");

                entity.Property(e => e.NoiDung).HasMaxLength(500);

                entity.Property(e => e.Nsx)
                    .HasMaxLength(500)
                    .HasColumnName("NSX");

                entity.Property(e => e.Nvnhan)
                    .HasMaxLength(50)
                    .HasColumnName("NVNhan");

                entity.Property(e => e.Serial).HasMaxLength(100);

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("0 bình thường, 1 Đổi Hàng Mới");

                entity.Property(e => e.Stt)
                    .HasMaxLength(100)
                    .HasColumnName("STT");

                entity.Property(e => e.TenHang).HasMaxLength(500);

                entity.Property(e => e.TienThuKh)
                    .HasColumnType("money")
                    .HasColumnName("TienThuKH");

                entity.Property(e => e.TienThuNcc)
                    .HasColumnType("money")
                    .HasColumnName("TienThuNCC");

                entity.Property(e => e.TienTraKh)
                    .HasColumnType("money")
                    .HasColumnName("TienTraKH");

                entity.Property(e => e.TienTraNcc)
                    .HasColumnType("money")
                    .HasColumnName("TienTraNCC");

                entity.Property(e => e.TinhTrangId)
                    .HasMaxLength(50)
                    .HasColumnName("TinhTrangID");

                entity.HasOne(d => d.SoPhieuNavigation)
                    .WithMany(p => p.TblBaoHanhNhatKies)
                    .HasForeignKey(d => d.SoPhieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BaoHanhNhatKy_tbl_ThongTinBaoHanh");

                entity.HasOne(d => d.TinhTrang)
                    .WithMany(p => p.TblBaoHanhNhatKies)
                    .HasForeignKey(d => d.TinhTrangId)
                    .HasConstraintName("FK_tbl_BaoHanhNhatKy_MN_TinhTrangBH");
            });

            modelBuilder.Entity<TblBaoHanhNhatKyDoiMoiChuyenBan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_BaoHanhNhatKyDoiMoiChuyenBan");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .HasComment("User xác nhận hoàn thành");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày xác nhận bảo hành hoàn thành");

                entity.Property(e => e.CreateDateSto).HasColumnType("datetime");

                entity.Property(e => e.CreateSto).HasMaxLength(50);

                entity.Property(e => e.MaNhatKyBh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaNhatKyBH");

                entity.Property(e => e.NoteSto).HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .HasComment("Chi nhánh nhận sto điều chuyển");

                entity.Property(e => e.Status).HasComment("0 chưa tạo STO, 1 đã tạo STO");

                entity.Property(e => e.Sto)
                    .HasMaxLength(50)
                    .HasColumnName("STO");

                entity.Property(e => e.SttlinkDetail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("STTLinkDetail");
            });

            modelBuilder.Entity<TblBaoHanhOnline>(entity =>
            {
                entity.HasKey(e => e.SoPhieu);

                entity.ToTable("tbl_BaoHanhOnline");

                entity.HasIndex(e => new { e.Status, e.SiteId, e.Active, e.CreateDay }, "<tblBanHangOnline_IDX, sysname,>");

                entity.HasIndex(e => new { e.SiteId, e.Active }, "INDEXSEARCH2");

                entity.HasIndex(e => new { e.SiteId, e.MaThongTin, e.Active, e.CreateDay }, "IdSearchSiteId");

                entity.HasIndex(e => new { e.SoBienNhan, e.TenKhachHang, e.DiaChi, e.DienThoai, e.SiteId, e.SiteCn, e.MaThongTin, e.CreateDay, e.MaNhanVien, e.KetQuaId, e.SoPhieu, e.LoaiHangId }, "Idx-Search");

                entity.HasIndex(e => new { e.SiteId, e.Active }, "IndSearch");

                entity.HasIndex(e => e.SiteIdSbn, "IndSearch1");

                entity.HasIndex(e => new { e.SiteId, e.Active }, "IndexSearch");

                entity.HasIndex(e => new { e.DienThoai, e.Active }, "IndexSearch1");

                entity.HasIndex(e => new { e.Active, e.CreateDay }, "IndexSearch3");

                entity.HasIndex(e => new { e.Active, e.CreateBy, e.Status, e.NgayGioXuLy }, "IndexSearch4");

                entity.HasIndex(e => new { e.Active, e.ThoiGianDi, e.TienPhiCtac }, "IndexSearch5");

                entity.Property(e => e.SoPhieu).HasMaxLength(50);

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("false đã xóa, true bình thường");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(20);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.DienThoai).HasMaxLength(50);

                entity.Property(e => e.GhiChuChuyen).HasMaxLength(250);

                entity.Property(e => e.IdTicketRequest)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Ticket_Request");

                entity.Property(e => e.KetQuaId).HasMaxLength(50);

                entity.Property(e => e.LoaiDichVuId).HasMaxLength(50);

                entity.Property(e => e.LoaiHangId)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiHangID");

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.MaThongTin).HasMaxLength(50);

                entity.Property(e => e.NgayGioXuLy).HasColumnType("datetime");

                entity.Property(e => e.NgayMuaHang).HasColumnType("datetime");

                entity.Property(e => e.NgayNhan).HasColumnType("datetime");

                entity.Property(e => e.Point).HasComment("Số điểm gọi khách");

                entity.Property(e => e.SiteCn)
                    .HasMaxLength(15)
                    .HasColumnName("SiteCN")
                    .HasComment("size chi nhánh nhập hàng");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(15)
                    .HasColumnName("SiteID")
                    .HasComment("size chi nhánh xử lý");

                entity.Property(e => e.SiteIdSbn).HasMaxLength(50);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.SoKm).HasColumnName("SoKM");

                entity.Property(e => e.SoLanIn).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 mới nhập, 1 đã đi - 2 đã về công tác, 3 Xác Nhận Kết Quả, 4 Chuyển Chi Nhánh");

                entity.Property(e => e.StatusBaoHanh)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 ko check, 1 có check");

                entity.Property(e => e.StatusChuyenVeTtbh)
                    .HasColumnName("StatusChuyenVeTTBH")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 bình thường, 1 chuyển về ttbh, 2 Vệ Sinh");

                entity.Property(e => e.StatusSuaChuaTaiNha).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusSuaLai).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusTinhPhi).HasDefaultValueSql("((0))");

                entity.Property(e => e.TenKhachHang).HasMaxLength(100);

                entity.Property(e => e.ThoiGianChapNhanBaoHanh)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ThoiGianDi).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianVe).HasColumnType("datetime");

                entity.Property(e => e.TienPhiCtac)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TinhTrang).HasMaxLength(500);

                entity.Property(e => e.TrangThaiSend)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 bình thường, 1 đã thêm hướng xử lý, 2 đã xử lý");
            });

            modelBuilder.Entity<TblBaoHanhOnlineDetail>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_BaoHanhOnlineDetail");

                entity.HasIndex(e => new { e.SoPhieu, e.Nccid }, "idx_BaoHanhOnlineDetail");

                entity.HasIndex(e => e.Nccid, "tblbaohanhonline_idx, sysname,>");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mc)
                    .HasMaxLength(500)
                    .HasColumnName("MC");

                entity.Property(e => e.Mcname)
                    .HasMaxLength(500)
                    .HasColumnName("MCName");

                entity.Property(e => e.Nccid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NCCID");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenHang)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.VendorId).HasMaxLength(100);

                entity.Property(e => e.VendorMail).HasMaxLength(500);

                entity.Property(e => e.VendorName).HasMaxLength(500);

                entity.HasOne(d => d.Ncc)
                    .WithMany(p => p.TblBaoHanhOnlineDetails)
                    .HasForeignKey(d => d.Nccid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BaoHanhOnlineDetail_MN_NCC");

                entity.HasOne(d => d.SoPhieuNavigation)
                    .WithMany(p => p.TblBaoHanhOnlineDetails)
                    .HasForeignKey(d => d.SoPhieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BaoHanhOnlineDetail_tbl_BaoHanhOnline1");
            });

            modelBuilder.Entity<TblBaoHanhOnlineHuongXuLy>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_BaoHanhOnlineHuongXuLy");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(20);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(15)
                    .HasColumnName("SiteID")
                    .HasComment("size chi nhánh xử lý");

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 chưa xử lý, 1 đã xử lý");
            });

            modelBuilder.Entity<TblBaoHanhOnlineTinhPhi>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_BaoHanhOnlineTinhPhi");

                entity.HasIndex(e => new { e.MaNhanVien, e.CreateDuyetPhi, e.TimeEnd }, "IndexSearch");

                entity.HasIndex(e => new { e.Active, e.TimeEnd, e.NumberKm }, "IndexSearch1");

                entity.HasIndex(e => new { e.Active, e.NumberKm }, "IndexSearch2");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 tính phí - 0 ko tính phí");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(20);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateDayDuyet).HasColumnType("datetime");

                entity.Property(e => e.CreateDuyetPhi).HasMaxLength(50);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StatusXacNhan)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 bình thường, 1 đã xác nhận , 2 đã loại");

                entity.Property(e => e.TienPhi)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeEnd).HasColumnType("datetime");

                entity.Property(e => e.TimeStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBilling>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Billing");

                entity.HasIndex(e => new { e.BillingId, e.SerialNo, e.InvoiceNum, e.SaleRecieptId, e.BillingDate, e.Status, e.SiteId }, "ClusteredIndex-20181221-163712")
                    .IsClustered();

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.BillingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BillingId)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDaySend)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.Property(e => e.InvoiceNum)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(100);

                entity.Property(e => e.PaymentForm).HasMaxLength(50);

                entity.Property(e => e.SaleRecieptId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasComment("0:binh thuong,1 cancel");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToTalAfterVat)
                    .HasColumnType("money")
                    .HasColumnName("ToTalAfterVAT");

                entity.Property(e => e.TotalBeforVat)
                    .HasColumnType("money")
                    .HasColumnName("TotalBeforVAT");

                entity.Property(e => e.TotalVat)
                    .HasColumnType("money")
                    .HasColumnName("TotalVAT");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblChapNhanGiaoSbn>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_ChapNhanGiaoSBN");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note).HasMaxLength(150);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblChiNhanhCuocPhi>(entity =>
            {
                entity.HasKey(e => e.MaChiNhanh);

                entity.ToTable("tbl_ChiNhanhCuocPhi");

                entity.Property(e => e.MaChiNhanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenChiNhanh).HasMaxLength(50);
            });

            modelBuilder.Entity<TblChiTietDichVu>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK_tbl_ChiTietPhieuThu");

                entity.ToTable("tbl_ChiTietDichVu");

                entity.HasIndex(e => e.SoPhieuThu, "IdSearchPt");

                entity.HasIndex(e => e.SoPhieuThu, "IdSearchSpt");

                entity.HasIndex(e => e.SoPhieuThu, "Idct");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CheckRaBn)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 phiếu bình thường, 1 check để ra biên nhận từ pos");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.Mahang).HasMaxLength(50);

                entity.Property(e => e.SoPhieuThu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenHang).HasMaxLength(150);

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblConfigConnect>(entity =>
            {
                entity.HasKey(e => e.SiteId)
                    .HasName("PK_tblConfigConnect_1");

                entity.ToTable("tblConfigConnect");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DatabaseNameDelivery).HasMaxLength(100);

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblConnectIndexlivingmall>(entity =>
            {
                entity.HasKey(e => e.MaChiNhanh);

                entity.ToTable("tbl_ConnectIndexlivingmall");

                entity.Property(e => e.MaChiNhanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDanhSachSoanHangChuanBiGiao>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_DanhSachSoanHangChuanBiGiao");

                entity.HasIndex(e => e.StatusSoanHang, "INdexSearch");

                entity.HasIndex(e => e.StatusSoanHang, "IndexSearch1");

                entity.HasIndex(e => new { e.SoBienNhan, e.StatusSoanHang }, "IndexSearch2");

                entity.HasIndex(e => new { e.Status, e.SiteId, e.LoaiXe }, "SearchIndex");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoaiXe).HasComment("0 xe máy, 1 xe tai");

                entity.Property(e => e.Note).HasMaxLength(100);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("0 mới nhập vào, 1 đã gán xe");

                entity.Property(e => e.StatusSoanHang)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 mặc định kho chưa xác định soạn hàng, 1 đã soạn hàng oke, 2 chuyển xuống kho soạn hàng");
            });

            modelBuilder.Entity<TblDichVu>(entity =>
            {
                entity.HasKey(e => e.SoPhieuThu)
                    .HasName("PK_tbl_PhieuThu");

                entity.ToTable("tbl_DichVu");

                entity.HasIndex(e => new { e.SiteDeliveryId, e.StatusSaleReciept, e.SoBienNhanCu }, "IndexSearch");

                entity.Property(e => e.SoPhieuThu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckHelp)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 bình thường, 1 ra dịch vụ hộ");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Createby)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiaChi).HasMaxLength(254);

                entity.Property(e => e.DienThoai).HasMaxLength(100);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.NgayInPhieu).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .HasComment("N'thông tin ghi chú phiếu dịch vụ'");

                entity.Property(e => e.QuanHuyen).HasMaxLength(50);

                entity.Property(e => e.SaleRecieptId)
                    .HasMaxLength(50)
                    .HasColumnName("SaleRecieptID");

                entity.Property(e => e.SiteDeliveryId)
                    .HasMaxLength(50)
                    .HasComment("chi nhánh được đánh hộ.");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .HasColumnName("SiteID")
                    .HasComment("Chi Nhánh đánh phiếu dịch vụ");

                entity.Property(e => e.SiteIdPos).HasMaxLength(50);

                entity.Property(e => e.SoBienNhanCu).HasMaxLength(15);

                entity.Property(e => e.Status).HasComment("0 lập Phiếu, 1 In Phiếu, 2 Hủy Phiếu");

                entity.Property(e => e.StatusSaleReciept)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 chưa ra biên nhận, 1 đã ra biên nhận");

                entity.Property(e => e.TenKhachHang).HasMaxLength(150);

                entity.Property(e => e.ThuPhi).HasColumnType("money");

                entity.Property(e => e.TinhThanh).HasMaxLength(50);

                entity.Property(e => e.TongTien).HasColumnType("money");
            });

            modelBuilder.Entity<TblDoiHangLoiSto>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_DoiHangLoiSto");

                entity.Property(e => e.Stt)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STT")
                    .HasComment("Số thứ tự insert key");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateSite).HasMaxLength(50);

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.SiteBan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SiteBaoHanh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SiteLayHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("0 mới khởi tạo, 1 đã tạo STO");

                entity.Property(e => e.StatusSto)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 chưa duyệt sto, 1 đã duyệt");

                entity.Property(e => e.StoNumber).HasMaxLength(50);

                entity.Property(e => e.TenHang)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblDuyetHuyGh>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_DuyetHuyGH");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.Createby).HasMaxLength(50);

                entity.Property(e => e.NgayDuyetPhieu)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note).HasMaxLength(245);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoPhieuBienNhan).HasMaxLength(15);
            });

            modelBuilder.Entity<TblGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("tbl_Groups");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã nhóm người dùng.");

                entity.Property(e => e.GroupName).HasComment("Tên hiển thị trên giao diện người dùng của Nhóm người dùng, có phân biệt theo đa ngôn ngữ.");

                entity.Property(e => e.IsAdmin).HasComment("Quản lý nhóm người dùng này có thuộc quyền Admin hay không. 1: Quyền admin, 0: Không phải quyền Admin.");

                entity.Property(e => e.Note).HasComment("Các diễn giải, ghi chú khác của Nhóm người dùng này.");
            });

            modelBuilder.Entity<TblGroupAuthorization>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.AuthorizationId });

                entity.ToTable("tbl_GroupAuthorization");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GroupID")
                    .HasComment("Mã nhóm người dùng.");

                entity.Property(e => e.AuthorizationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AuthorizationID")
                    .HasComment("Mã function.");
            });

            modelBuilder.Entity<TblGroupUser>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.LoginId });

                entity.ToTable("tbl_GroupUser");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GroupID")
                    .HasComment("Mã nhóm người dùng.");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(20)
                    .HasColumnName("LoginID")
                    .HasComment("Tên đăng nhập của Người dùng.");
            });

            modelBuilder.Entity<TblGuiYeuCauLuuYrieng>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_GuiYeuCauLuuYRieng");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateByDuyet).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateDateDuyet).HasColumnType("datetime");

                entity.Property(e => e.Flag)
                    .HasDefaultValueSql("((0))")
                    .HasComment("1 khách chủ động gọi, 2 nv gọi xác nhận giao, 3 giao hàng không thành công");

                entity.Property(e => e.KhungGio).HasMaxLength(50);

                entity.Property(e => e.NgayGioGiao).HasColumnType("date");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 bình thường, 1 đã duyệt (ĐÃ GỌI)");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<TblHienThiNoiDungThongBao>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_HienThiNoiDungThongBao");

                entity.Property(e => e.Stt)
                    .HasColumnName("stt")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblHinhAnh>(entity =>
            {
                entity.HasKey(e => e.SoBienNhan);

                entity.ToTable("tblHinhAnh");

                entity.Property(e => e.SoBienNhan).HasMaxLength(15);

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.Createby).HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateGiao).HasColumnType("datetime");

                entity.Property(e => e.HinhAnh).HasColumnType("image");

                entity.Property(e => e.Note).HasMaxLength(245);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.Status).HasComment("0 chưa giao, 1 đã đi giao");
            });

            modelBuilder.Entity<TblIdtinhPhi>(entity =>
            {
                entity.HasKey(e => new { e.Stt, e.IdthongTin });

                entity.ToTable("tbl_IDTinhPhi");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.IdthongTin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDThongTin");

                entity.Property(e => e.TenThongTin).HasMaxLength(250);
            });

            modelBuilder.Entity<TblInDuyetPhieu>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_InDuyetPhieu");

                entity.HasIndex(e => e.SoPhieuBienNhan, "index_sbn");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.ComputerNameUser).HasMaxLength(50);

                entity.Property(e => e.Createby).HasMaxLength(20);

                entity.Property(e => e.CreatebyUser).HasMaxLength(20);

                entity.Property(e => e.NgayHuyPhieu)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayInPhieu).HasColumnType("datetime");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoPhieuBienNhan).HasMaxLength(15);
            });

            modelBuilder.Entity<TblInPhieu>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_InPhieu");

                entity.HasIndex(e => e.Createby, "IndexSearch");

                entity.HasIndex(e => e.CreateDay, "indSearch");

                entity.HasIndex(e => e.SoBienNhan, "index_sbn");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createby)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NgayInPhieu)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SoLanIn).HasComment("In sẽ tăng dần lên sau mổi lần in");

                entity.Property(e => e.Status).HasComment("0 bình thường, 1 lần 2....");
            });

            modelBuilder.Entity<TblItemName>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("tbl_ItemName");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ItemID")
                    .HasComment("Mã hàng");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Mã barcode");

                entity.Property(e => e.Buy).HasComment("Cho Bán (true) else False");

                entity.Property(e => e.CategoryId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID")
                    .HasComment("Mã Loại Hàng");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(500)
                    .HasComment("Tên Hàng");

                entity.Property(e => e.ItemOrService).HasComment("Loại hàng dịch vụ");

                entity.Property(e => e.Note)
                    .HasMaxLength(400)
                    .HasComment("Ghi Chú");

                entity.Property(e => e.NumberId)
                    .HasColumnName("NumberID")
                    .HasComment("Số Thứ Tự");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("money")
                    .HasComment("Gía bán");

                entity.Property(e => e.Sell).HasComment("1.cho bán;0.không cho bán");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Tên Đơn Vị");

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Đơn vị tiền");

                entity.Property(e => e.Vatid)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("VATID");
            });

            modelBuilder.Entity<TblIteminMc>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("tbl_IteminMC");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(25)
                    .HasColumnName("ItemID");

                entity.Property(e => e.BrandId)
                    .HasMaxLength(50)
                    .HasColumnName("BrandID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Mcid)
                    .HasMaxLength(25)
                    .HasColumnName("MCID");

                entity.Property(e => e.NganhHang).HasMaxLength(60);

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VendorId)
                    .HasMaxLength(10)
                    .HasColumnName("VendorID");
            });

            modelBuilder.Entity<TblKhoHangTam>(entity =>
            {
                entity.HasKey(e => e.KeyIdKhoTam);

                entity.ToTable("tbl_KhoHangTam");

                entity.HasIndex(e => new { e.SiteId, e.StatusDieuPhoi, e.Active }, "IndSearch");

                entity.HasIndex(e => e.SoBienNhan, "NonClusteredIndex-20160219-111046");

                entity.Property(e => e.KeyIdKhoTam)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("true phiếu bình thường, false phiếu hủy");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GhiChuXeTaiGui).HasMaxLength(150);

                entity.Property(e => e.GhiChuXeTaiLay).HasMaxLength(150);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.NhanVienXeGui)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NhanVienXeLay).HasMaxLength(50);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StatusDieuPhoi).HasComment("0 nhập vào, 1 kết thúc");

                entity.Property(e => e.StatusKhoTam).HasComment("1 Phiếu Nhập Kho, 2 Phiếu Xuất Kho, 3 Hoàn Kho Tổng");

                entity.Property(e => e.StatusPrint).HasDefaultValueSql("((0))");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ThoiGianGui).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianLay)
                    .HasColumnType("datetime")
                    .HasComment("StatusKhoTam = 3 là thời gian hoàn kho 9");

                entity.Property(e => e.TrangThai).HasComment("0 xe máy, 1 xe tải");
            });

            modelBuilder.Entity<TblKhoHangTamChiTiet>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_KhoHangTamChiTiet");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("false là đã xóa, true con hàng còn trong kho");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.KeyIdKhoTam)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenHang)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ThanhTien).HasColumnType("money");
            });

            modelBuilder.Entity<TblKhoHangTamLog>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_KhoHangTamLog");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipadress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAdress");

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);
            });

            modelBuilder.Entity<TblKiemKePhieuBienNhan>(entity =>
            {
                entity.HasKey(e => new { e.SoBienNhan, e.InventoryPeriod, e.SiteId });

                entity.ToTable("tbl_KiemKePhieuBienNhan");

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.InventoryPeriod)
                    .HasMaxLength(50)
                    .HasComment("Kỳ Kiểm Kê");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<TblLapDatCenter>(entity =>
            {
                entity.HasKey(e => e.Idlapdat);

                entity.ToTable("tbl_LapDatCenter");

                entity.HasIndex(e => e.ItemId, "IdSearchld");

                entity.HasIndex(e => e.CreationDate, "IndSearch");

                entity.HasIndex(e => new { e.SiteId, e.Status, e.CreationDate }, "IndexSearch");

                entity.HasIndex(e => e.StatusBaoCong, "IndexSearch1");

                entity.HasIndex(e => new { e.SalesReceiptArising, e.SalesReceiptId, e.SiteId, e.EmployeeDeliveryName, e.IdloaiMay, e.CreationDate, e.Createby, e.Status }, "idx_lapdat");

                entity.Property(e => e.Idlapdat)
                    .HasMaxLength(50)
                    .HasColumnName("IDLAPDAT")
                    .HasComment("Liên kết vs tbl_ChiTietDichVu - SoPhieuThu");

                entity.Property(e => e.ArisingMoney).HasColumnType("money");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Createby)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeDeliveryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IdloaiMay)
                    .HasMaxLength(50)
                    .HasColumnName("IDLoaiMay");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .HasColumnName("ItemID");

                entity.Property(e => e.ItemName).HasMaxLength(500);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SalesReceiptArising)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReceiptId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesReceiptID");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.Status).HasComment("null trạng thái chưa duyệt - 1 chấp nhận tính lương - 2 hủy không tính lương");

                entity.Property(e => e.StatusBaoCong).HasComment("0 tính công bt, 1 bao công lắp đặt");

                entity.Property(e => e.StatusCall)
                    .HasDefaultValueSql("((0))")
                    .HasComment("= 0 chưa call, 1 đã call ");

                entity.Property(e => e.StatusDichVu)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 nhân viên lắp đặt, 1 dịch vụ lắp đặt, 2 xác nhận lắp đặt từ App");

                entity.Property(e => e.StatusHcKiemTra)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 chưa kiểm tra, 1 đã kiểm tra");

                entity.Property(e => e.StatusTruKho).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.WagesMoney).HasColumnType("money");
            });

            modelBuilder.Entity<TblLockUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_LockUser");

                entity.Property(e => e.LockedUser).HasComment("lockedUser = 3 ");

                entity.Property(e => e.MaChiNhanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenDangNhap).HasMaxLength(20);
            });

            modelBuilder.Entity<TblLogPhiGiaoNhan>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_LogPhiGiaoNhan");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createby).HasMaxLength(20);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);
            });

            modelBuilder.Entity<TblLuongGiaoNhan>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("tblLuongGiaoNhan");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.MayLocNuoc).HasColumnType("money");

                entity.Property(e => e.Site1)
                    .HasColumnType("money")
                    .HasColumnName("site1");

                entity.Property(e => e.Site10)
                    .HasColumnType("money")
                    .HasColumnName("site10");

                entity.Property(e => e.Site11)
                    .HasColumnType("money")
                    .HasColumnName("site11");

                entity.Property(e => e.Site12)
                    .HasColumnType("money")
                    .HasColumnName("site12");

                entity.Property(e => e.Site13)
                    .HasColumnType("money")
                    .HasColumnName("site13");

                entity.Property(e => e.Site14)
                    .HasColumnType("money")
                    .HasColumnName("site14");

                entity.Property(e => e.Site15)
                    .HasColumnType("money")
                    .HasColumnName("site15");

                entity.Property(e => e.Site16)
                    .HasColumnType("money")
                    .HasColumnName("site16");

                entity.Property(e => e.Site17)
                    .HasColumnType("money")
                    .HasColumnName("site17");

                entity.Property(e => e.Site18)
                    .HasColumnType("money")
                    .HasColumnName("site18");

                entity.Property(e => e.Site19)
                    .HasColumnType("money")
                    .HasColumnName("site19");

                entity.Property(e => e.Site2)
                    .HasColumnType("money")
                    .HasColumnName("site2");

                entity.Property(e => e.Site20)
                    .HasColumnType("money")
                    .HasColumnName("site20");

                entity.Property(e => e.Site3)
                    .HasColumnType("money")
                    .HasColumnName("site3");

                entity.Property(e => e.Site4)
                    .HasColumnType("money")
                    .HasColumnName("site4");

                entity.Property(e => e.Site5)
                    .HasColumnType("money")
                    .HasColumnName("site5");

                entity.Property(e => e.Site6)
                    .HasColumnType("money")
                    .HasColumnName("site6");

                entity.Property(e => e.Site7)
                    .HasColumnType("money")
                    .HasColumnName("site7");

                entity.Property(e => e.Site8)
                    .HasColumnType("money")
                    .HasColumnName("site8");

                entity.Property(e => e.Site9)
                    .HasColumnType("money")
                    .HasColumnName("site9");

                entity.Property(e => e.XeTai)
                    .HasColumnType("money")
                    .HasComment("1 phiếu giao hàng");
            });

            modelBuilder.Entity<TblMc>(entity =>
            {
                entity.HasKey(e => e.Mcid);

                entity.ToTable("tbl_MC");

                entity.Property(e => e.Mcid)
                    .HasMaxLength(20)
                    .HasColumnName("MCID");

                entity.Property(e => e.Mch)
                    .HasMaxLength(10)
                    .HasColumnName("MCH");

                entity.Property(e => e.Mch1)
                    .HasMaxLength(18)
                    .HasColumnName("MCH1");

                entity.Property(e => e.Mchname)
                    .HasMaxLength(50)
                    .HasColumnName("MCHNAME");

                entity.Property(e => e.Mchname1)
                    .HasMaxLength(50)
                    .HasColumnName("MCHNAME1");

                entity.Property(e => e.Mcname)
                    .HasMaxLength(100)
                    .HasColumnName("MCNAME");
            });

            modelBuilder.Entity<TblMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.ToTable("tbl_Menu");

                entity.Property(e => e.MenuId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MenuID")
                    .HasComment("Mã menu, mã tự phát sinh để quản lý.");

                entity.Property(e => e.FormName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Tên form trong chương trình, dùng xác định xem Menu này chỉ đến Form nào.");

                entity.Property(e => e.MenuFiliationId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MenuFiliationID")
                    .HasComment("Mã Menu cha, dùng xác định xem Menu này có thuộc một menu nào khác hay không.");

                entity.Property(e => e.MenuPosition).HasComment("Số định danh để xác định vị trí chính xác của Menu.");

                entity.Property(e => e.MenuValue).HasComment("Nội dung hiển thị của Menu, xác định theo đa ngôn ngữ.");
            });

            modelBuilder.Entity<TblMenuForm>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.ToTable("tbl_MenuForm");

                entity.Property(e => e.MenuId)
                    .HasMaxLength(50)
                    .HasColumnName("MenuID");

                entity.Property(e => e.MenuName).HasMaxLength(100);

                entity.Property(e => e.Tag).HasMaxLength(50);
            });

            modelBuilder.Entity<TblMenuGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.MenuId, e.LoginId });

                entity.ToTable("tbl_MenuGroup");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GroupID")
                    .HasComment("Mã Nhóm người dùng.");

                entity.Property(e => e.MenuId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MenuID")
                    .HasComment("Mã menu.");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(20)
                    .HasColumnName("LoginID")
                    .HasComment("Tên đăng nhập của Người dùng.");
            });

            modelBuilder.Entity<TblMileageMap>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_MileageMap");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FromDay).HasColumnType("datetime");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.ToDay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("tbl_Modules");

                entity.Property(e => e.ModuleId)
                    .ValueGeneratedNever()
                    .HasColumnName("ModuleID")
                    .HasComment("Mã Module, là mã phát sinh để quản lý.");

                entity.Property(e => e.ModuleName).HasComment("Tên module, tên hiển thị của Module để xác định trên giao diện người dùng.");

                entity.Property(e => e.Note).HasComment("Các miêu tả, ghi chú khác của Module.");
            });

            modelBuilder.Entity<TblNDauKyDinhMucGn>(entity =>
            {
                entity.ToTable("tbl_N_DauKyDinhMucGN");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Createtiondate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.SiteId).HasMaxLength(50);
            });

            modelBuilder.Entity<TblNumberDistance>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_NumberDistance");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasMaxLength(50);

                entity.Property(e => e.SaleRecieptId).HasMaxLength(50);
            });

            modelBuilder.Entity<TblOidmap>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("tbl_OIDMap");

                entity.Property(e => e.Oid)
                    .ValueGeneratedNever()
                    .HasColumnName("OID");

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeviceSerial).HasMaxLength(50);

                entity.Property(e => e.DiviceName).HasMaxLength(100);

                entity.Property(e => e.Gbrsenable).HasColumnName("GBRSEnable");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.Plate).HasMaxLength(15);

                entity.Property(e => e.RemoteId)
                    .HasMaxLength(100)
                    .HasColumnName("RemoteID");

                entity.Property(e => e.Smsenable).HasColumnName("SMSEnable");

                entity.Property(e => e.TrackingMode).HasMaxLength(100);
            });

            modelBuilder.Entity<TblParamater>(entity =>
            {
                entity.HasKey(e => e.ParaId);

                entity.ToTable("tblParamater");

                entity.Property(e => e.ParaId)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(200);
            });

            modelBuilder.Entity<TblPhanCa>(entity =>
            {
                entity.HasKey(e => e.MaPhanCa);

                entity.ToTable("tbl_PhanCa");

                entity.Property(e => e.MaPhanCa).HasMaxLength(50);

                entity.Property(e => e.DienGiai).HasMaxLength(100);
            });

            modelBuilder.Entity<TblPhiGiaoNhan>(entity =>
            {
                entity.HasKey(e => e.SoBienNhan);

                entity.ToTable("tbl_PhiGiaoNhan");

                entity.HasIndex(e => new { e.SiteId, e.CreationDate }, "IDX_PHIgn");

                entity.HasIndex(e => new { e.Active, e.CreationDate }, "IndexSearch");

                entity.Property(e => e.SoBienNhan).HasMaxLength(15);

                entity.Property(e => e.Active).HasComment("false ko tính tiền, 1 Tính tiền");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Createby)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdthongTin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDThongTin");

                entity.Property(e => e.Mahang).HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .HasColumnName("SiteID");

                entity.Property(e => e.StatusDinhMuc)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 bình thường, 1 đã trừ định mức");

                entity.Property(e => e.TenHang).HasMaxLength(100);

                entity.Property(e => e.TienNhanVien).HasColumnType("money");

                entity.Property(e => e.TrangThaiGh)
                    .HasColumnName("TrangThaiGH")
                    .HasComment("0 client, giao hộ");
            });

            modelBuilder.Entity<TblPhiGiaoNhanLapDat>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tblPhiGiaoNhanLapDat");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("false ko tính tiền, 1 Tính tiền");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.Createby).HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiaChi).HasMaxLength(245);

                entity.Property(e => e.Mahang).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(245);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan).HasMaxLength(15);

                entity.Property(e => e.TenHang).HasMaxLength(100);

                entity.Property(e => e.TenKhachHang).HasMaxLength(245);

                entity.Property(e => e.TenNhanVien).HasMaxLength(245);
            });

            modelBuilder.Entity<TblPhiGiaoNhanPhatSinh>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_PhiGiaoNhanPhatSinh");

                entity.HasIndex(e => new { e.Active, e.CreationDate }, "IndexSearch");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("false ko tính tiền, 1 Tính tiền");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Createby)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.Mahang).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(245);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TenHang).HasMaxLength(100);

                entity.Property(e => e.TrangThaiGh).HasColumnName("TrangThaiGH");
            });

            modelBuilder.Entity<TblPhiGiaoNhanPhatSinhRieng>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_PhiGiaoNhanPhatSinhRieng");

                entity.HasIndex(e => new { e.Active, e.CreationDate }, "IndSearch");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("false ko tính tiền, 1 Tính tiền");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.Createby).HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiaChi).HasMaxLength(245);

                entity.Property(e => e.Mahang).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(245);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan).HasMaxLength(15);

                entity.Property(e => e.TenHang).HasMaxLength(100);

                entity.Property(e => e.TenKhachHang).HasMaxLength(245);

                entity.Property(e => e.TenNhanVien).HasMaxLength(245);
            });

            modelBuilder.Entity<TblPhiGiaoNhanVeSinhMayLanh>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tblPhiGiaoNhanVeSinhMayLanh");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("false ko tính tiền, 1 Tính tiền");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.Createby).HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiaChi).HasMaxLength(245);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.Mahang).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(245);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan).HasMaxLength(15);

                entity.Property(e => e.TenHang).HasMaxLength(100);

                entity.Property(e => e.TenKhachHang).HasMaxLength(245);
            });

            modelBuilder.Entity<TblPhiGiaoNhanXeTai>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_PhiGiaoNhanXeTai");

                entity.HasIndex(e => e.MaNhanVien, "IndexSearch");

                entity.HasIndex(e => e.SiteId, "IndexSearch1");

                entity.HasIndex(e => e.SoBienNhan, "id_Search");

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày duyệt");

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.TienNhanVien).HasColumnType("money");
            });

            modelBuilder.Entity<TblPhieuBaoHanhHang>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_PhieuBaoHanhHang");

                entity.HasIndex(e => new { e.MaGuiNcc, e.MaNccHang, e.MaHang, e.Nccid, e.SiteId, e.Sttdetail }, "NonClusteredIndex-20211209-111218");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.MaGuiNcc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaGuiNCC");

                entity.Property(e => e.MaHang).HasMaxLength(50);

                entity.Property(e => e.MaNccHang).HasMaxLength(50);

                entity.Property(e => e.Nccid)
                    .HasMaxLength(50)
                    .HasColumnName("NCCID");

                entity.Property(e => e.NgayNhan).HasColumnType("date");

                entity.Property(e => e.Serial).HasMaxLength(150);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sttdetail)
                    .HasMaxLength(500)
                    .HasColumnName("STTDetail");

                entity.Property(e => e.TenHang).HasMaxLength(150);
            });

            modelBuilder.Entity<TblPhieuNhanTien>(entity =>
            {
                entity.HasKey(e => e.MaPhieu);

                entity.ToTable("tbl_PhieuNhanTien");

                entity.Property(e => e.MaPhieu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(100)
                    .HasColumnName("CMND");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateDayCmnd)
                    .HasColumnType("date")
                    .HasColumnName("CreateDayCMND");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.Createday)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LyDo).HasMaxLength(500);

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SiteIdnhan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteIDNhan");

                entity.Property(e => e.SoTien).HasColumnType("money");
            });

            modelBuilder.Entity<TblPhucHoiTrangThaiPhieu>(entity =>
            {
                entity.ToTable("tbl_PhucHoiTrangThaiPhieu");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer).HasMaxLength(100);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.TrangThai).HasComment("0 giao tại cn, 1 giao hộ");
            });

            modelBuilder.Entity<TblPosBillingInfo>(entity =>
            {
                entity.HasKey(e => e.SaleRecieptId);

                entity.ToTable("tbl_POS_BillingInfo");

                entity.Property(e => e.SaleRecieptId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SaleRecieptID");

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerAddress).HasMaxLength(500);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.PaymentType).HasMaxLength(50);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblReviewWeb>(entity =>
            {
                entity.HasKey(e => e.SoBienNhan);

                entity.ToTable("tbl_ReviewWeb");

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.Reviewid).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSiteWeb>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("tbl_SiteWeb");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mả chi nhánh sẽ được nhập vào");

                entity.Property(e => e.Active).HasComment("1 kích hoạt, 0 không kích hoạt");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("Địa chỉ(chỉ nhạp số nhà đường,phường xã)");

                entity.Property(e => e.CityId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Mã tỉnh thành");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã code để tạo mã cho chi nhánh");

                entity.Property(e => e.DistrictId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Mã Quận,huyện");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasComment("Địa chỉ Email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsFixedLength(true)
                    .HasComment("Các số fax cách nhau bỡi dấu “,”");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Các số điện thoại cách nhau bỡi dấu “,”");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("Tên chi nhánh");

                entity.Property(e => e.SiteVoucherId).HasColumnName("SiteVoucherID");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSoLanDiLog>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tblSoLanDi_LOG");

                entity.HasIndex(e => new { e.SoBienNhan, e.SiteId, e.Createby, e.CreateDay, e.Note, e.Status }, "IdSearch");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createby).HasMaxLength(20);

                entity.Property(e => e.Note).HasMaxLength(245);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan).HasMaxLength(15);

                entity.Property(e => e.Status).HasComment("o xóa phiếu bình thường, 1 duyệt hủy phiếu");
            });

            modelBuilder.Entity<TblSoLanDiXeMay>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tblSoLanDiXeMay");

                entity.HasIndex(e => e.SiteId, "IndexSearch");

                entity.HasIndex(e => e.MaNhanVien, "idSearch");

                entity.HasIndex(e => new { e.SoBienNhan, e.MaNhanVien, e.SiteId }, "idx_Search");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createby).HasMaxLength(20);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(15)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan).HasMaxLength(15);

                entity.Property(e => e.TrangThaiGh).HasComment("0 bình thường , 1 giao hộ");
            });

            modelBuilder.Entity<TblSoLanDiXeTai>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tblSoLanDiXeTai");

                entity.HasIndex(e => e.SiteId, "IndexSearch1");

                entity.HasIndex(e => e.MaSoXe, "idSearch");

                entity.HasIndex(e => new { e.SoBienNhan, e.MaSoXe, e.SiteId }, "idx_Search");

                entity.HasIndex(e => e.CreateDay, "indexSearch");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createby).HasMaxLength(20);

                entity.Property(e => e.MaSoXe).HasMaxLength(15);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(15)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan).HasMaxLength(15);

                entity.Property(e => e.TrangThaiGh).HasComment("0 bình thường , 1 giao hộ");
            });

            modelBuilder.Entity<TblSoLanDiXeTaiNhanVien>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tblSoLanDiXeTai_NhanVien");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createby)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.MaNhanVien)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaSoXe).HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblSoTrangIn>(entity =>
            {
                entity.HasKey(e => e.MaChiNhanh);

                entity.ToTable("tbl_SoTrangIn");

                entity.Property(e => e.MaChiNhanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.A4a5)
                    .HasColumnName("A4A5")
                    .HasComment("true in A5, False A4");

                entity.Property(e => e.Active).HasComment("false - 0 in tự động số Trang Mặt định, 1 - True User được quyền Tự động lựa chọn số trang");

                entity.Property(e => e.CheckedA4).HasComment("false không hiển thị in A4, True hiển thị in A4");

                entity.Property(e => e.StatusBacode).HasComment("0 - False bình thường, 1 - True  Phải Bắn Bacode");

                entity.Property(e => e.TenChiNhanh).HasMaxLength(50);
            });

            modelBuilder.Entity<TblThongTinBaoHanh>(entity =>
            {
                entity.HasKey(e => e.SoPhieu);

                entity.ToTable("tbl_ThongTinBaoHanh");

                entity.HasIndex(e => new { e.Active, e.CreateDay }, "IdCreate");

                entity.HasIndex(e => e.NhanTu, "IndSearch");

                entity.HasIndex(e => new { e.SoPhieu, e.NhanVienNhan, e.NhanTu, e.MaGuiNcc, e.SiteId, e.SiteCn, e.LoaiHangId, e.NgayNhanHangGuiCn }, "searchAll");

                entity.Property(e => e.SoPhieu).HasMaxLength(50);

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(20);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.DienThoai).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.LoaiHangId)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiHangID");

                entity.Property(e => e.MaGuiNcc)
                    .HasMaxLength(50)
                    .HasColumnName("MaGuiNCC");

                entity.Property(e => e.MaLoaiBaoHanh).HasMaxLength(100);

                entity.Property(e => e.NgayNhan).HasColumnType("datetime");

                entity.Property(e => e.NgayNhanHangGuiCn)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayNhanHangGuiCN")
                    .HasComment("chi nhánh thì ngày gửi NCC, còn BHNB H001 hiển thị ngày nhận ");

                entity.Property(e => e.NgayTaoPhieu).HasColumnType("date");

                entity.Property(e => e.NgayTra).HasColumnType("datetime");

                entity.Property(e => e.NgayTraBh)
                    .HasColumnType("date")
                    .HasColumnName("NgayTraBH");

                entity.Property(e => e.NhanTu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NhanVienNhan).HasMaxLength(50);

                entity.Property(e => e.NoiDung).HasMaxLength(500);

                entity.Property(e => e.SiteCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteCN")
                    .HasComment("size chi nhánh nhập hàng");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID")
                    .HasComment("size chi nhánh xử lý");

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.SoLanIn).HasComment("Số Lần in phiếu biên nhận bảo hành");

                entity.Property(e => e.Status).HasComment("1 tiếp nhận -  đợi sửa chữa bảo hành, 2 sữa chữa bảo hành, 5 theo giỏi trả khách, 4 Hoàn thành phiếu, 3 Trả cho Chi Nhánh,6 Gửi Cho Quận 5, 7 gửi trả về cho chi nhánh");

                entity.Property(e => e.TenKhachHang).HasMaxLength(100);

                entity.Property(e => e.TenLoaiBaoHanh).HasMaxLength(500);
            });

            modelBuilder.Entity<TblThongTinBaoHanhChungTu>(entity =>
            {
                entity.HasKey(e => e.SctnhapXuat);

                entity.ToTable("tbl_ThongTinBaoHanhChungTu");

                entity.Property(e => e.SctnhapXuat)
                    .HasMaxLength(50)
                    .HasColumnName("SCTNhapXuat");

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 phiếu khởi tạo, 1 phiếu đã nhập");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateDateXuLy).HasColumnType("datetime");

                entity.Property(e => e.CreateUserBy).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("1 nhập, 2 xuất");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<TblThongTinBaoHanhDetail>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_ThongTinBaoHanhDetail");

                entity.HasIndex(e => new { e.StatusDetail, e.TrangThai, e.SiteNhanBaoHanh, e.ActiveDetail, e.SlocBaoHanh }, "IdSearch");

                entity.HasIndex(e => new { e.StatusDetail, e.SiteNhanBaoHanh, e.ActiveDetail, e.SlocBaoHanh, e.TinhTrangId }, "IdSearch1");

                entity.HasIndex(e => new { e.StatusDetail, e.SiteNhanBaoHanh, e.ActiveDetail, e.SlocBaoHanh, e.TinhTrangId }, "IdSearch2");

                entity.HasIndex(e => new { e.Serial, e.ActiveDetail }, "IndSearch");

                entity.HasIndex(e => new { e.TrangThai, e.SiteNhanBaoHanh, e.ActiveDetail, e.TrangThaiGui }, "IndSearch1");

                entity.HasIndex(e => new { e.StatusDetail, e.ActiveDetail, e.TinhTrangId }, "IndSearch2");

                entity.HasIndex(e => new { e.StatusDetail, e.TrangThai, e.ActiveDetail }, "IndSearch3");

                entity.HasIndex(e => new { e.StatusDetail, e.ActiveDetail, e.TinhTrangId }, "IndexSearch");

                entity.HasIndex(e => new { e.StatusDetail, e.ActiveDetail, e.SlocBaoHanh, e.TinhTrangId }, "IndexSearch1");

                entity.HasIndex(e => new { e.StatusDetail, e.SiteNhanBaoHanh, e.ActiveDetail, e.TinhTrangId }, "Index_Search");

                entity.HasIndex(e => new { e.SoPhieu, e.MaHang, e.LoaiDv, e.MaGuiNcc, e.TinhTrangId, e.SiteNhanBaoHanh, e.SiteNhapBaoHanh, e.SlocBaoHanh, e.NguonGocLoiId }, "NonClusteredIndex-20180814-155843");

                entity.HasIndex(e => new { e.StatusDetail, e.TrangThai, e.ActiveDetail, e.SlocBaoHanh }, "SearchIndex");

                entity.HasIndex(e => new { e.Serial, e.TenHang }, "idxSerial");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActiveDetail)
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 đã hủy, 1 mặc định là ok");

                entity.Property(e => e.CreateDateDetail)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HuongXuLyId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idbb)
                    .HasMaxLength(12)
                    .HasColumnName("IDBB");

                entity.Property(e => e.KinhDoanhGhiChu).HasMaxLength(500);

                entity.Property(e => e.LoaiDv)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiDV");

                entity.Property(e => e.MaGuiNcc)
                    .HasMaxLength(50)
                    .HasColumnName("MaGuiNCC");

                entity.Property(e => e.MaHang).HasMaxLength(50);

                entity.Property(e => e.Mc)
                    .HasMaxLength(500)
                    .HasColumnName("MC");

                entity.Property(e => e.Mcname)
                    .HasMaxLength(500)
                    .HasColumnName("MCName");

                entity.Property(e => e.MoTaLoi).HasMaxLength(500);

                entity.Property(e => e.NgayGuiHangBaoHanh).HasColumnType("datetime");

                entity.Property(e => e.NgayNhanHangBaoHanh)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayNhanVeTuHang).HasColumnType("datetime");

                entity.Property(e => e.NgayTemCty).HasColumnType("datetime");

                entity.Property(e => e.NgayTemNsx)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayTemNSX");

                entity.Property(e => e.NgayTraBh)
                    .HasColumnType("date")
                    .HasColumnName("NgayTraBH");

                entity.Property(e => e.NguonGocLoiId).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Nsx)
                    .HasMaxLength(100)
                    .HasColumnName("NSX");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Giá bán sản phẩm");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SiteNhanBaoHanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNhapBaoHanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SlocBaoHanh).HasMaxLength(50);

                entity.Property(e => e.Slxuat)
                    .HasColumnName("SLXuat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SoPhieuSto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SoPhieuSTO");

                entity.Property(e => e.StatusCapNhatGiaBan)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 mới, 1 đã gửi xin giá bán, 2 đã up giá bán");

                entity.Property(e => e.StatusDetail)
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 mặc định , 1 đã chấp nhận");

                entity.Property(e => e.StatusDieuChuyen)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Status điều chuyển Sloc bảo hành 9800-->9036,9047");

                entity.Property(e => e.StatusEmail)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 chưa send Email, 1 Đã send Email");

                entity.Property(e => e.StatusHangKyThuat)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 trạng thái mặc định, 1 Gửi hãng, 2 Kỹ Thuật xử lý");

                entity.Property(e => e.StatusRutSto)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 chưa rút sto, 1 đã rút sto");

                entity.Property(e => e.StatusXacNhan)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 Chưa Xác Nhận Trừ Hàng, 1 Đã Xác Nhận Trừ Hàng");

                entity.Property(e => e.TenHang).HasMaxLength(500);

                entity.Property(e => e.TinhTrangId)
                    .HasMaxLength(50)
                    .HasColumnName("TinhTrangID");

                entity.Property(e => e.TrangThai)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 tiếp nhận -  đợi sửa chữa bảo hành, 2 sữa chữa bảo hành, 5 theo giỏi trả khách, 4 Hoàn thành phiếu, 3 Trả cho Chi Nhánh,6 Gửi Cho Quận 5, 7 gửi trả về cho chi nhánh, 8 hàng dư theo bảng kê chi nhánh gửi lên");

                entity.Property(e => e.TrangThaiGui)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 trạng thái bình thường, 1 đã gửi yêu cầu Tạo STO theo danh sách,  2 đã tạo STO và kết thúc sang trạng thái bảo hành hoàn thành để trừ hàng");

                entity.Property(e => e.VendorId).HasMaxLength(100);

                entity.Property(e => e.VendorMail).HasMaxLength(500);

                entity.Property(e => e.VendorName).HasMaxLength(500);

                entity.HasOne(d => d.LoaiDvNavigation)
                    .WithMany(p => p.TblThongTinBaoHanhDetails)
                    .HasForeignKey(d => d.LoaiDv)
                    .HasConstraintName("FK_tbl_ThongTinBaoHanhDetail_MN_LoaiDichVuBH");

                entity.HasOne(d => d.SoPhieuNavigation)
                    .WithMany(p => p.TblThongTinBaoHanhDetails)
                    .HasForeignKey(d => d.SoPhieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ThongTinBaoHanhDetail_tbl_ThongTinBaoHanh");
            });

            modelBuilder.Entity<TblThongTinBaoHanhPhuKien>(entity =>
            {
                entity.ToTable("tbl_ThongTinBaoHanhPhuKien");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaHang).HasMaxLength(50);

                entity.Property(e => e.NhaSx)
                    .HasMaxLength(500)
                    .HasColumnName("NhaSX");

                entity.Property(e => e.Serial).HasMaxLength(100);

                entity.Property(e => e.SoPhieu).HasMaxLength(50);

                entity.Property(e => e.TenHang).HasMaxLength(100);

                entity.HasOne(d => d.SoPhieuNavigation)
                    .WithMany(p => p.TblThongTinBaoHanhPhuKiens)
                    .HasForeignKey(d => d.SoPhieu)
                    .HasConstraintName("FK_tbl_ThongTinBaoHanhPhuKien_tbl_ThongTinBaoHanh");
            });

            modelBuilder.Entity<TblThongTinBaoHanhRutSto>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_ThongTinBaoHanhRutSto");

                entity.Property(e => e.Stt)
                    .ValueGeneratedNever()
                    .HasColumnName("STT");

                entity.Property(e => e.ActicleDoc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 loại, 1 chấp nhận");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiteFrom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("size chi nhánh xử lý");

                entity.Property(e => e.SiteTo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("size chi nhánh nhập hàng");

                entity.Property(e => e.Sloc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusXuatHang).HasComment("0 chưa xuất hàng, 1 đã xuất hàng");

                entity.Property(e => e.Sto)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblThongTinBaoHanhSto>(entity =>
            {
                entity.HasKey(e => e.SoPhieu);

                entity.ToTable("tbl_ThongTinBaoHanhSto");

                entity.HasIndex(e => new { e.SiteId, e.CreateDay }, "IdSearch");

                entity.Property(e => e.SoPhieu).HasMaxLength(50);

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 bình thường, 1 đã duyệt cho chuyển Sto, 2 Đã Loại");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(20);

                entity.Property(e => e.CreateDateSo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateDayNgayDuyet).HasColumnType("datetime");

                entity.Property(e => e.LyDoLoai).HasMaxLength(250);

                entity.Property(e => e.MaSoXe).HasMaxLength(50);

                entity.Property(e => e.NhanTu).HasMaxLength(50);

                entity.Property(e => e.NoiDung).HasMaxLength(500);

                entity.Property(e => e.SiteCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteCN")
                    .HasComment("size chi nhánh nhập hàng");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID")
                    .HasComment("size chi nhánh xử lý");

                entity.Property(e => e.StatusSto)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 chưa tạo, 1 đã tạo sto, 2 đã nhập vào danh sách bảo hành");

                entity.Property(e => e.Sto).HasMaxLength(50);
            });

            modelBuilder.Entity<TblThongTinBaoHanhStoDetail>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_ThongTinBaoHanhStoDetail");

                entity.HasIndex(e => e.SoPhieu, "IndexSearchSp");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Idbbsto)
                    .HasMaxLength(12)
                    .HasColumnName("IDBBSto");

                entity.Property(e => e.LoaiDv)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiDV");

                entity.Property(e => e.MaHang).HasMaxLength(50);

                entity.Property(e => e.MoTaLoi).HasMaxLength(500);

                entity.Property(e => e.NgayTemCty).HasColumnType("datetime");

                entity.Property(e => e.NgayTemNsx)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayTemNSX");

                entity.Property(e => e.NguonGocLoiId).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Nsx)
                    .HasMaxLength(100)
                    .HasColumnName("NSX");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SlocBaoHanh).HasMaxLength(50);

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StatusDetail)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 trạng thái mới khởi tạo hoặc là loại nếu active đã duyệt, 1 trạng thái được duyệt để chuyển sang STO");

                entity.Property(e => e.TenHang).HasMaxLength(500);
            });

            modelBuilder.Entity<TblThongTinBaoHanhXuatDieuChuyen>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_ThongTinBaoHanhXuatDieuChuyen");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 bình thường, 0 đã hủy");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .HasComment("Mã chi nhánh điều chuyển");

                entity.Property(e => e.SiteIdNhap)
                    .HasMaxLength(50)
                    .HasComment("Mã chi nhánh nhập");

                entity.Property(e => e.SoChungTuSap)
                    .HasMaxLength(50)
                    .HasColumnName("SoChungTuSAP");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 Chuyển Sloc, 1 Xuất Trả hãng (Thu Mua Tạo PO), 3 Chuyển Cho Chi Nhánh Khác (Tạo STO)");

                entity.Property(e => e.StatusKhoiTao)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 mới khởi tạo, 1 đã tạo Chứng Từ");

                entity.Property(e => e.Sttdetail)
                    .HasMaxLength(200)
                    .HasColumnName("STTDetail");
            });

            modelBuilder.Entity<TblTraHangBaoHanh>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_TraHangBaoHanh");

                entity.HasIndex(e => e.CreateDay, "IdSearchTHBH");

                entity.HasIndex(e => new { e.SoPhieu, e.MaNhanVienTra, e.SbnkhachTra }, "NonClusteredIndex-20180814-155545");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Computer).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LyDo).HasMaxLength(500);

                entity.Property(e => e.MaNhanVienTra).HasMaxLength(50);

                entity.Property(e => e.NgayTra).HasColumnType("date");

                entity.Property(e => e.SbnkhachTra)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SBNKhachTra");

                entity.Property(e => e.SoPhieu).HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("0 chưa Thanh Toán, 1 đã thanh toán");

                entity.Property(e => e.ThoiGianBaoHanh).HasComment("tháng");

                entity.Property(e => e.TienThuKhac).HasColumnType("money");

                entity.Property(e => e.TongTienThu).HasColumnType("money");

                entity.HasOne(d => d.SoPhieuNavigation)
                    .WithMany(p => p.TblTraHangBaoHanhs)
                    .HasForeignKey(d => d.SoPhieu)
                    .HasConstraintName("FK_tbl_TraHangBaoHanh_tbl_ThongTinBaoHanh");
            });

            modelBuilder.Entity<TblTruHangSap>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Tbl_TruHangSap");

                entity.HasIndex(e => new { e.SiteIdDieuChuyen, e.CreateDate }, "IdSearch");

                entity.HasIndex(e => new { e.Status, e.SiteIdDieuChuyen }, "IdSearch1");

                entity.HasIndex(e => new { e.Status, e.SiteIdDieuChuyen, e.CreateDate }, "IdSearch2");

                entity.HasIndex(e => new { e.Status, e.SiteId, e.CreateDate }, "IdSearch3");

                entity.HasIndex(e => e.SoBienNhan, "IdSearch4");

                entity.HasIndex(e => new { e.Status, e.CreateDate }, "IdSearch5");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActicleDoc)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FiscalYear)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KeyId).HasMaxLength(50);

                entity.Property(e => e.Note).IsRequired();

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteIdDieuChuyen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("1 Trừ Hàng, 2 Chuyển Trừ Hàng, 3 Phiếu Trả Hàng - Duyệt Hủy ActDoc Chuyển từ Kho Giữ Hàng về Kho Chính, 4 Duyệt Hủy ActicleDoc, 5 kế toán tự hủy vì lý do");

                entity.Property(e => e.StatusTruHangNhan)
                    .HasDefaultValueSql("((1))")
                    .HasComment("trạng thái mặc định 1 nếu # 1 thì chi nhánh nhận đã trừ hàng loại khỏi hệ thống");
            });

            modelBuilder.Entity<TblTruHangSapChiTiet>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Tbl_TruHangSapChiTiet");

                entity.HasIndex(e => new { e.Status, e.KeyId }, "<Name of Missing Index, sysname,>");

                entity.HasIndex(e => e.Status, "IdSearch");

                entity.HasIndex(e => e.Status, "IdSearch1");

                entity.HasIndex(e => new { e.SoBienNhan, e.Status }, "IdSearch2");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FromSloc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.KeyId).HasMaxLength(50);

                entity.Property(e => e.KeyIdKhoTam)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("1 trừ hàng, 2 không trừ hàng sap");

                entity.Property(e => e.ToSloc)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTruHangSapChiTietSto>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Tbl_TruHangSapChiTietSto");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FromSloc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.KeyId).HasMaxLength(50);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("1 trừ hàng, 2 không trừ hàng sap");

                entity.Property(e => e.ToSloc)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTruHangSapNote>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Tbl_TruHangSapNote");

                entity.HasIndex(e => new { e.SoBienNhan, e.CreateDate, e.CreateBy, e.IpAddress }, "SearchSbn");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.StatusSto)
                    .HasDefaultValueSql("((1))")
                    .HasComment("=1 đã thêm lưu ý, 2 đã chuyển sang tạo STO");
            });

            modelBuilder.Entity<TblTruHangSapNoteSto>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Tbl_TruHangSapNoteSto");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.StatusSto)
                    .HasDefaultValueSql("((1))")
                    .HasComment("=1 đã thêm lưu ý, 2 đã chuyển sang tạo STO");
            });

            modelBuilder.Entity<TblTruHangSapReturn>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Tbl_TruHangSapReturn");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActicleDoc)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FiscalYear)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KeyId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTruHangSapSto>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Tbl_TruHangSapSto");

                entity.Property(e => e.Stt).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActicleDoc)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FiscalYear)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KeyId).HasMaxLength(50);

                entity.Property(e => e.Note).IsRequired();

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteIdDieuChuyen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("1 đang giữ hàng trong Sloc, 2 đã trừ khỏi kho");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.TenDangNhap)
                    .HasName("PK_tbl_User_1");

                entity.ToTable("tbl_User");

                entity.Property(e => e.TenDangNhap).HasMaxLength(20);

                entity.Property(e => e.ActiveNutNganhHangNcc)
                    .HasDefaultValueSql("((0))")
                    .HasComment("1 được quyền, 0 ngược lại");

                entity.Property(e => e.Agent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoPhanId)
                    .HasMaxLength(50)
                    .HasColumnName("BoPhanID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DienThoai).HasMaxLength(15);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.HostEmail).HasMaxLength(50);

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.Ipserver)
                    .HasMaxLength(50)
                    .HasColumnName("IPServer")
                    .HasDefaultValueSql("(N'192.168.190.58')");

                entity.Property(e => e.IsAdmins)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 user bình thường, 1 quản lý nhóm");

                entity.Property(e => e.KtSoLanNhapXe)
                    .HasDefaultValueSql("((1))")
                    .HasComment("false ko kiểm tra số lần nhập xe nhanh, true là kiểm tra số lần nhập nợ xe");

                entity.Property(e => e.LoaiHangId)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiHangID")
                    .HasComment("ALL nhìn thấy được các phiếu bảo hành, DIDONG thấy được hàng di động, CONLAI mặt hàng còn lại ngoài DiDong, TT1000004 Kế Toán");

                entity.Property(e => e.LockedDate).HasColumnType("date");

                entity.Property(e => e.LoginActive)
                    .HasDefaultValueSql("((1))")
                    .HasComment("true or 1 sử dụng bình thường, 0 or false out user");

                entity.Property(e => e.MaChiNhanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassEmail).HasMaxLength(50);

                entity.Property(e => e.PassPhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PassWebSevicePhone)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'4f50d543d71566e3f6f4e744b2eeloteriaeesdfdfd')");

                entity.Property(e => e.PhanCa).HasMaxLength(20);

                entity.Property(e => e.PhoneServerPort)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1101))");

                entity.Property(e => e.SoTrangInPhieuGiaoHang)
                    .HasDefaultValueSql("((0))")
                    .HasComment("=0 in mặc định theo cấu hình trang in, >0 và cấu hình trang in active = false");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 or NULL ko cho phep dang nhap gọi callcenter, 1 cho phep");

                entity.Property(e => e.StatusLogin)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 là chưa sử dụng, 1 đang sử dụng");

                entity.Property(e => e.TenNguoiDung).HasMaxLength(50);

                entity.Property(e => e.UserNamePhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserNameWebservicePhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'tasclick2')");

                entity.Property(e => e.VersionNew).HasMaxLength(50);

                entity.Property(e => e.Versions).HasMaxLength(50);
            });

            modelBuilder.Entity<TblUser1>(entity =>
            {
                entity.HasKey(e => e.TenDangNhap)
                    .HasName("PK_tbl_User");

                entity.ToTable("tbl_User1");

                entity.Property(e => e.TenDangNhap).HasMaxLength(20);

                entity.Property(e => e.MaChiNhanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pass).HasMaxLength(20);

                entity.Property(e => e.PhanCa).HasMaxLength(20);

                entity.Property(e => e.PhanQuyen).HasMaxLength(20);

                entity.Property(e => e.Stt).ValueGeneratedOnAdd();

                entity.Property(e => e.TenNguoiDung).HasMaxLength(50);
            });

            modelBuilder.Entity<TblUserGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId });

                entity.ToTable("tbl_User_Group");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GroupID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TblUserGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_User_Group_tbl_Groups");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblUserGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_User_Group_tbl_User");
            });

            modelBuilder.Entity<TblUserGroupMenu>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_User_Group_Menu");

                entity.HasIndex(e => e.GroupId, "IdG");

                entity.HasIndex(e => e.MenuId, "IdSearchMenu");

                entity.Property(e => e.Stt)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("(newID())");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GroupID");

                entity.Property(e => e.MenuId)
                    .HasMaxLength(50)
                    .HasColumnName("MenuID");

                entity.Property(e => e.Status).HasComment("0 MenuForm,1 MenuNode");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TblUserGroupMenus)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_tbl_User_Group_Menu_tbl_Groups");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.TblUserGroupMenus)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_tbl_User_Group_Menu_tbl_MenuForm");
            });

            modelBuilder.Entity<TblUserIsadmin>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SiteId });

                entity.ToTable("tbl_User_ISADMIN");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblVersionService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_VersionService");

                entity.Property(e => e.Versions)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblXacNhanLapDatThanhCong>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("tbl_XacNhanLapDatThanhCong");

                entity.HasIndex(e => e.CreateDate, "IndSearch");

                entity.HasIndex(e => new { e.SoBienNhan, e.CreateByNghe, e.CreateDateNghe, e.NoteNghe }, "IndSearch1");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateByNghe).HasMaxLength(50);

                entity.Property(e => e.CreateByStatus).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateDateNghe).HasMaxLength(50);

                entity.Property(e => e.CreateDateStatus).HasColumnType("datetime");

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.NoteNghe)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoBienNhan).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 trạng thái mặc định, 1 điều phối đã xác nhận hoàn tất lắp đặt");

                entity.Property(e => e.StatusCall)
                    .HasDefaultValueSql("((0))")
                    .HasComment("1 đã call");

                entity.Property(e => e.TienLapDat)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Nhân Viên Call sẽ nhập vào");
            });

            modelBuilder.Entity<TcSo>(entity =>
            {
                entity.ToTable("tc_SO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sonumber)
                    .HasMaxLength(12)
                    .HasColumnName("SONumber");

                entity.Property(e => e.TongTien).HasColumnType("money");
            });

            modelBuilder.Entity<Temp8888>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("Temp_8888");

                entity.HasIndex(e => new { e.SiteId, e.Status }, "IndexSearch");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName).HasMaxLength(150);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SoBienNhan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasComment("= 1 SAP, 2 POS");
            });

            modelBuilder.Entity<TempBcgiaoHangChuaThanhCoc>(entity =>
            {
                entity.HasKey(e => new { e.Stt, e.SalesReceiptId });

                entity.ToTable("Temp_BCGiaoHangChuaThanhCoc");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SalesReceiptId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("SalesReceiptID");

                entity.Property(e => e.GioNap).HasColumnType("datetime");

                entity.Property(e => e.StandId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StandID");
            });

            modelBuilder.Entity<TempReportBaoHanh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempReportBaoHanh");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sloc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempReportBaoHanhAll>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("TempReportBaoHanhAll");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FromSloc).HasMaxLength(50);

                entity.Property(e => e.ItemId).HasMaxLength(50);

                entity.Property(e => e.SiteId).HasMaxLength(50);
            });

            modelBuilder.Entity<ThamSo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ThamSo");

                entity.Property(e => e.Bien)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GiaTri)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ThanhCoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ThanhCoc");

                entity.Property(e => e.CashDrawerId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CashDrawerID")
                    .HasComment("M? qu?y thu ngân = ComputerName");

                entity.Property(e => e.CashierId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CashierID")
                    .HasComment("M? nhân viên thu ngân");

                entity.Property(e => e.ExchangeRate).HasColumnType("money");

                entity.Property(e => e.ForgCurrAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Số tiền nguyên tệ mà khách hàng trả");

                entity.Property(e => e.ForgCurrId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ForgCurrID");

                entity.Property(e => e.LocalCurrAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Số tiền thanh toán nội địa");

                entity.Property(e => e.Ordinal).HasComment("Số thứ tự lần thanh toán");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày thanh toán");

                entity.Property(e => e.SalesReceiptId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SalesReceiptID");

                entity.Property(e => e.SalesReceiptPaymentId)
                    .HasColumnName("SalesReceiptPaymentID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ShiftID")
                    .HasComment("Ca bán hàng");
            });

            modelBuilder.Entity<TinhThanh>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK_TinhThanh1");

                entity.ToTable("TinhThanh");

                entity.Property(e => e.CityId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CityID");

                entity.Property(e => e.CityName).HasMaxLength(100);

                entity.Property(e => e.CodeEms)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlugNameEms)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Slug_Name_Ems");
            });

            modelBuilder.Entity<TmpRc>(entity =>
            {
                entity.HasKey(e => e.SaleReceiptId);

                entity.ToTable("tmp_RC");

                entity.Property(e => e.SaleReceiptId).HasMaxLength(15);
            });

            modelBuilder.Entity<TmpSo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_So");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sbn)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewLocThongTinGiaoHo1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LocThongTinGiaoHo1");

                entity.Property(e => e.ChiNhanhGh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LuuY).HasMaxLength(254);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.MaSoXe).HasMaxLength(15);

                entity.Property(e => e.NgayGiaoNhan).HasColumnType("datetime");

                entity.Property(e => e.NgayTaoPhieu).HasColumnType("datetime");

                entity.Property(e => e.NhomNhanVien).HasMaxLength(255);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SoChiTiet)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SoPhu).HasMaxLength(75);

                entity.Property(e => e.TenKhachHang).HasMaxLength(150);

                entity.Property(e => e.TenNhanVien).HasMaxLength(50);

                entity.Property(e => e.ThoiGianDi).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianVe).HasColumnType("datetime");

                entity.Property(e => e.TienDatCoc).HasColumnType("money");

                entity.Property(e => e.TongTien).HasColumnType("money");
            });

            modelBuilder.Entity<ViewShowDataCenter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ShowDataCenter");

                entity.Property(e => e.ChiNhanhGh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LuuY).HasMaxLength(254);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.MaSoXe).HasMaxLength(15);

                entity.Property(e => e.NgayGiaoNhan).HasColumnType("datetime");

                entity.Property(e => e.NgayTaoPhieu).HasColumnType("datetime");

                entity.Property(e => e.NhomNhanVien).HasMaxLength(255);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SoChiTiet)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SoPhu).HasMaxLength(75);

                entity.Property(e => e.TenKhachHang).HasMaxLength(150);

                entity.Property(e => e.TenNhanVien).HasMaxLength(50);

                entity.Property(e => e.ThoiGianDi).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianVe).HasColumnType("datetime");

                entity.Property(e => e.TienDatCoc).HasColumnType("money");

                entity.Property(e => e.TongTien).HasColumnType("money");
            });

            modelBuilder.Entity<Viewtinhtienxetai>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewtinhtienxetai");

                entity.Property(e => e.ChiNhanhGh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityName).HasMaxLength(100);

                entity.Property(e => e.DiaChi).HasMaxLength(254);

                entity.Property(e => e.DienThoai).HasMaxLength(100);

                entity.Property(e => e.MaSoXe).HasMaxLength(15);

                entity.Property(e => e.Mahang).HasMaxLength(50);

                entity.Property(e => e.NgayGiaoNhan).HasColumnType("datetime");

                entity.Property(e => e.NhomNhanVien).HasMaxLength(255);

                entity.Property(e => e.QuanHuyenName).HasMaxLength(100);

                entity.Property(e => e.SoBienNhan)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TenHang).HasMaxLength(100);

                entity.Property(e => e.TenKhachHang).HasMaxLength(150);

                entity.Property(e => e.ThoiGianVe).HasColumnType("datetime");

                entity.Property(e => e.TienDatCoc).HasColumnType("money");

                entity.Property(e => e.TongTien).HasColumnType("money");
            });

            modelBuilder.Entity<Xe>(entity =>
            {
                entity.HasKey(e => e.MaSoXe)
                    .HasName("PK_Xe_1");

                entity.ToTable("Xe");

                entity.HasIndex(e => new { e.MaSoXe, e.TenXe }, "idxXe");

                entity.Property(e => e.MaSoXe).HasMaxLength(15);

                entity.Property(e => e.DienGiai).HasMaxLength(254);

                entity.Property(e => e.LoaiXe).HasComment("1 xe tải, 2 xe ford");

                entity.Property(e => e.MaChiNhanh).HasMaxLength(15);

                entity.Property(e => e.MaNhanVien).HasMaxLength(50);

                entity.Property(e => e.MaVachId)
                    .HasMaxLength(50)
                    .HasColumnName("MaVachID");

                entity.Property(e => e.NgayMua).HasColumnType("datetime");

                entity.Property(e => e.NgayNhan).HasColumnType("datetime");

                entity.Property(e => e.NguoiTao).HasMaxLength(20);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.StatusOwe)
                    .HasDefaultValueSql("((1))")
                    .HasComment("true bắt gàn buột nợ phiếu, false không gàn buột");

                entity.Property(e => e.Stt)
                    .HasColumnName("stt")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.TenXe).HasMaxLength(50);

                entity.Property(e => e.TinhTrangXe)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 Xe công ty, 1 xe thuê");
            });

            modelBuilder.Entity<XeNhanVien>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK_XeNhanVien_1");

                entity.ToTable("XeNhanVien");

                entity.HasIndex(e => e.SoChiTiet, "<xenhanvienidx, sysname,>");

                entity.HasIndex(e => new { e.MaXe, e.SoChiTiet, e.NhomNhanVien }, "NonClusteredIndex-20160201-163123");

                entity.Property(e => e.Stt)
                    .HasColumnName("stt")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GhiChu).HasMaxLength(254);

                entity.Property(e => e.MaNhanVien2Xe).HasMaxLength(50);

                entity.Property(e => e.MaXe).HasMaxLength(20);

                entity.Property(e => e.NhomNhanVien).HasMaxLength(255);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(20)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoChiTiet).HasMaxLength(50);
            });

            modelBuilder.Entity<XeNhanVienGh>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("XeNhanVienGH");

                entity.Property(e => e.Stt)
                    .HasColumnName("stt")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.GhiChu).HasMaxLength(254);

                entity.Property(e => e.MaNhanVien2Xe).HasMaxLength(50);

                entity.Property(e => e.MaXe)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NhomNhanVien).HasMaxLength(255);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(20)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SoChiTiet).HasMaxLength(50);

                entity.Property(e => e.Uuu)
                    .HasMaxLength(50)
                    .HasColumnName("uuu");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
