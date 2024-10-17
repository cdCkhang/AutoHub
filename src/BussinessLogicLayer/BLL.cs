using DataAccessLayer.Entities;
using System.Data;
namespace BussinessLogicLayer
{
    public class BLL
    {                
        public static List<Account> getAccountName()
        {
            return DataAccessLayer.GetData.LayDSAcc();
        }
        public static List<Account> DSAcc() {return DataAccessLayer.GetData.LayDSAcc(); }         
        public static (DataTable dt, int soKH) LayKhachHang()
        {
            return DataAccessLayer.GetData.LayKhachHang();
        }
        public static (DataTable dt, int soxe, double tb, double myear) LayXe()
        {
            return DataAccessLayer.GetData.LayXe();
        }
        public static DataTable LayNSX()
        {
            return DataAccessLayer.GetData.LayNSX();
        }
        public static DataTable LayNV() { return DataAccessLayer.GetData.LayNhanVien(); }
        public static DataTable LayGD() { return DataAccessLayer.GetData.LayGiaoDich(); }        
        public static (DataTable dt, int SoGd, double TongGT, double TongDT) LayThongKeGD() { return DataAccessLayer.GetData.LayThongKeGiaoDich(); }
        public static (DataTable dt, int soxe) ThongKeXe() { return DataAccessLayer.GetData.LayThongKeXe(); }
        public static DataTable LayXeTheoID(string maxe) { return DataAccessLayer.GetData.LayXeTheoMa(maxe); }
        public static DataTable LayGDTheoID(string magd) { return DataAccessLayer.GetData.LayGDtheoMaGD(magd); }

        // Customers
        public class KhachHang
        {
            public string makh { get; set; }
            public string ten { get; set; }
            public string sothe { get; set; }
            public string sdt { get; set; }
            public string mail { get; set; }
            public string diachi { get; set; }
            public KhachHang(string makh, string ten, string sothe, string sdt, string mail, string diachi)
            {
                this.makh = makh;
                this.ten = ten;
                this.sothe = sothe;
                this.sdt = sdt;
                this.mail = mail;
                this.diachi = diachi;
            }
        }
        public static void ThemKhach(string ma, string ten, string sothe, string sdt, string mail, string diachi) => DataAccessLayer.GetData.ThemKhachHang(ma, ten, sothe, sdt, mail, diachi);
        public static void SuaThongTinKhach(string ma, string ten, string sothe, string sdt, string mail, string diachi) => DataAccessLayer.GetData.SuaKhachHang(ma, ten, sothe, sdt, mail, diachi);
        public static bool XoaThongTinKhach(string ma) => DataAccessLayer.GetData.XoaKhachHang(ma);
        // Salers
        public class NhanVien
        {
            public string manv { get; set; }
            public string ten { get; set; }
            public string sdt { get; set; }
            public string mail { get; set; }
            public string diachi { get; set; }
            public int luong { get; set; }
            public NhanVien(string manv, string ten, string sdt, string mail, string diachi, int luong)
            {
                this.manv = manv;
                this.ten = ten;
                this.sdt = sdt;
                this.mail = mail;
                this.diachi = diachi;
                this.luong = luong;
            }
        }
        public static void ThemNhanVien(string ma, string ten, string sdt, string mail, string diachi, int luong) => DataAccessLayer.GetData.ThemNhanVien(ma, ten, sdt, mail, diachi,luong);
        public static void SuaThongTinNhanVien(string ma, string ten, string sdt, string mail, string diachi, int luong) => DataAccessLayer.GetData.SuaNhanVien(ma, ten, sdt, mail, diachi, luong);
        public static bool XoaThongTinNhanVien(string ma) => DataAccessLayer.GetData.XoaNhanVien(ma);
        //Cars
        public class Xe
        {
            public string maxe { get; set; }
            public string ten { get; set; }
            public string mansx { get; set; }
            public int nam { get; set; }
            public string mauxe { get; set; }
            public int gia { get; set; }
            public Xe(string maxe, string ten, string mansx, int nam, string mauxe, int gia)
            {
                this.maxe = maxe;
                this.ten = ten;
                this.mansx = mansx;
                this.nam = nam;
                this.mauxe = mauxe;
                this.gia = gia;
            }
        }
        
        public static void ThemXe(string maxe, string ten, string mansx, int nam, string mauxe, int gia) => DataAccessLayer.GetData.ThemXe(maxe, ten, mansx, nam, mauxe, gia);
        public static void SuaThongTinXe(string maxe, string ten, string mansx, int nam, string mauxe, int gia) => DataAccessLayer.GetData.SuaXe(maxe, ten, mansx, nam, mauxe, gia);
        public static bool XoaThongTinXe(string ma) => DataAccessLayer.GetData.XoaXe(ma);
        //Manus
        public class NSX
        {
            public string ma { get; set; }
            public string ten {  get; set; }
            public string diachi {  get; set; }
            public NSX(string ma, string ten, string diachi)
            {
                this.ma = ma;
                this.ten = ten;
                this.diachi = diachi;
            }
        }
        public static void ThemNSX(string mansx, string ten, string diachi) => DataAccessLayer.GetData.ThemNSX(mansx, ten, diachi);
        public static void SuaNSX(string mansx, string ten, string diachi) => DataAccessLayer.GetData.SuaNSX(mansx, ten, diachi);
        public static bool XoaNSX(string mansx) => DataAccessLayer.GetData.XoaNSX(mansx);
        //Trans
        public class GiaoDich
        {
            public string magd { get; set; }
            public string makh {  get; set; }
            public string manv {  get; set; }
            public string maxe {  get; set; }
            public int thue {  get; set; }            
            public GiaoDich(string magd, string makh, string manv, string maxe, int thue)
            {
                this.magd = magd;
                this.makh = makh;
                this.manv = manv;
                this.maxe = maxe;
                this.thue = thue;
            }
        }
        public static void ThemGiaoDich(string magd, string makh,string manv,  string maxe, int thue) => DataAccessLayer.GetData.ThemGiaoDich(magd, makh, manv,  maxe, thue);
        public static void SuaGiaoDich(string magd, string makh, string manv, string maxe, int thue) => DataAccessLayer.GetData.SuaGiaoDich(magd, makh, manv, maxe, thue);
        public static bool XoaGiaoDich(string magd) => DataAccessLayer.GetData.XoaGiaoDich(magd);
    }
}