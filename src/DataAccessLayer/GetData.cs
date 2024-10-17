using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GetData
    {        
        public static List<Account> LayDSAcc()
        {
            List<Account> list = null;
            using (DataAccess db = new DataAccess())
            {
                list = db.DSAccount.ToList();
            }
            return list;
        }
        public static (DataTable dt, int soKH )LayKhachHang()
        {
            using(DataAccess db =new DataAccess())
            {
                var customers = db.DSCustomer.ToList();
                DataTable dt = new DataTable();
                foreach(var prop in typeof(Customer).GetProperties())
                {
                    dt.Columns.Add(prop.Name, prop.PropertyType);
                }
                foreach(var customer in customers)
                {
                    DataRow dr = dt.NewRow();
                    foreach(var prop in typeof (Customer).GetProperties())
                    {
                        dr[prop.Name] = prop.GetValue(customer);
                    }
                    dt.Rows.Add(dr);
                }
                int soKH = customers.Count();
                return (dt,soKH);
            }
        }
        public static (DataTable dt, int soxe, double tb, double myear )LayXe()
        {
            using(DataAccess db = new DataAccess())
            {
                var cars = db.DSCar.ToList();
                DataTable dt = new DataTable();
                foreach(var prop in typeof(Car).GetProperties())
                {
                    dt.Columns.Add(prop.Name, prop.PropertyType);
                }
                foreach(var car in cars)
                {
                    DataRow dr = dt.NewRow();
                    foreach( var prop in typeof(Car).GetProperties())
                    {
                        dr[prop.Name]= prop.GetValue(car);
                    }
                    dt.Rows.Add(dr);
                }
                double tb = 0;
                tb = cars.Average(Car => Car.Price);
                double y = 0;
                y = cars.Average(Car => Car.Model_Year);
                int soxe = cars.Count();
                return (dt,soxe, tb, y);
            }
        }
        public static DataTable LayXeTheoMa (string maxe)
        {
            using (DataAccess db = new DataAccess())
            {
                var cars = db.DSCar.Where(Car => Car.Car_ID.Trim().Equals(maxe.Trim())).ToList();
                DataTable dt = new DataTable();
                foreach (var prop in typeof(Car).GetProperties())
                {
                    dt.Columns.Add(prop.Name, prop.PropertyType);
                }
                foreach (var car in cars)
                {
                    DataRow dr = dt.NewRow();
                    foreach (var prop in typeof(Car).GetProperties())
                    {
                        dr[prop.Name] = prop.GetValue(car);
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
        }
        public static DataTable LayNSX()
        {
            using(DataAccess db = new DataAccess())
            {
                var manus = db.DSManu.ToList();
                DataTable dt = new DataTable();
                foreach(var prop in typeof(Manufacturer).GetProperties())
                {
                    dt.Columns.Add(prop.Name,prop.PropertyType);
                }
                foreach(var manu in manus)
                {
                    DataRow dr = dt.NewRow();
                    foreach(var prop in typeof(Manufacturer).GetProperties())
                    {
                        dr[prop.Name] = prop.GetValue(manu);
                    }
                    dt.Rows.Add(dr );
                }
                return dt;
            }
        }
        public static DataTable LayNhanVien()
        {
            using(DataAccess db = new DataAccess())
            {
                var nhanviens = db.DSSaler.ToList();
                DataTable dt = new DataTable();
                foreach(var prop in typeof(Saler).GetProperties())
                {
                    dt.Columns.Add(prop.Name,prop.PropertyType);
                }
                foreach(var nhanvien in nhanviens)
                {
                    DataRow dr = dt.NewRow();
                    foreach(var prop in typeof(Saler).GetProperties())
                    {
                        dr[prop.Name] = prop.GetValue(nhanvien);
                    }
                    dt.Rows.Add(dr );
                }
                return dt;
            }
        }
        public static DataTable LayGiaoDich()
        {
            using (DataAccess db = new DataAccess())
            {
                var giaodichs = db.DSTrans.ToList();
                DataTable dt = new DataTable();
                foreach (var prop in typeof(Transaction).GetProperties())
                {
                    dt.Columns.Add(prop.Name, prop.PropertyType);
                }
                dt.Columns.Add("Price",typeof(double));
                foreach (var giaodich in giaodichs)
                {
                    DataRow dr = dt.NewRow();
                    foreach (var prop in typeof(Transaction).GetProperties())
                    {
                        dr[prop.Name] = prop.GetValue(giaodich);
                    }
                    var carinfo = db.DSCar.FirstOrDefault(car => car.Car_ID== giaodich.Car_ID);
                    if(carinfo != null)
                    {
                        double tong = carinfo.Price + (carinfo.Price * giaodich.Taxes_Fees * 0.01);
                        dr["Price"] = tong;
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
        }
        public static DataTable LayGDtheoMaGD(string ID)
        {
            using (DataAccess db = new DataAccess())
            {
                var giaodichs = db.DSTrans.Where(Transaction => Transaction.Transaction_ID.Trim().Equals(ID.Trim())).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaGD", typeof(string));
                dt.Columns.Add("MaKH", typeof(string));
                dt.Columns.Add("Price", typeof(double));
                foreach (var giaodich in giaodichs)
                {
                    DataRow dr = dt.NewRow();
                    var carInfo = db.DSCar.FirstOrDefault(car => car.Car_ID == giaodich.Car_ID);
                    if (carInfo!=null)
                    {
                        double tong = carInfo.Price + (carInfo.Price * giaodich.Taxes_Fees * 0.01);                       
                        dr["MaGD"] = giaodich.Transaction_ID;
                        dr["MaKH"] = giaodich.Customer_ID;
                        dr["Price"] = tong;
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
        }
        public static (DataTable dt, int SoGD, double TongGT, double TongDT ) LayThongKeGiaoDich()
        {
            using (DataAccess db = new DataAccess())
            {
                var giaodichs = db.DSTrans.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Price", typeof(double));
                dt.Columns.Add("MaGD", typeof(string));
                dt.Columns.Add("MaKH", typeof(string));
                double TongGT = 0;
                double TongDT = 0;
                foreach (var giaodich in giaodichs)
                {
                    DataRow dr = dt.NewRow();                                                         
                    var carInfo = db.DSCar.FirstOrDefault(car => car.Car_ID == giaodich.Car_ID);
                    if (carInfo != null)
                    {                        
                        double tong = carInfo.Price + (carInfo.Price * giaodich.Taxes_Fees * 0.01);
                        TongDT += tong - carInfo.Price;
                        TongGT += tong;
                        dr["Price"] = tong;                        
                        dr["MaGD"] = giaodich.Transaction_ID;
                        dr["MaKH"] = giaodich.Customer_ID;
                    }
                    
                    dt.Rows.Add(dr);
                }                             
                int SoGD = giaodichs.Count();
                return (dt, SoGD, TongGT, TongDT);
            }
        }
        public static (DataTable dt, int soxe ) LayThongKeXe()
        {
            using (DataAccess db = new DataAccess())
            {
                var cars = db.DSCar.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaXe", typeof(string));
                dt.Columns.Add("TenXe", typeof(string));
                dt.Columns.Add("MaNSX", typeof(string));
                foreach(var car in cars)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaXe"] = car.Car_ID;
                    dr["TenXe"] = car.Model_Name;
                    dr["MaNSX"] = car.Man_ID;
                    dt.Rows.Add(dr);
                }                
                int soxe = cars.Count();
                return (dt, soxe);
            }
        }
        //Customers
        public static void ThemKhachHang(string MaKH,string TenKH,string Sothe,string SDT,string email,string DiaChi)
        {
            using(DataAccess db = new DataAccess())
            {
                Customer KhachHang = new Customer
                {
                    Customer_ID = MaKH,
                    FullName = TenKH,
                    CreditCardNumber = Sothe,
                    Contact_Number  = SDT,
                    Email = email,
                    Info_Address = DiaChi
                };
                db.DSCustomer.Add(KhachHang);
                db.SaveChanges();
            }
        }
        public static void SuaKhachHang(string MaKH, string TenKH, string Sothe, string SDT, string email, string DiaChi)
        {
            using (DataAccess db = new DataAccess())
            {
                Customer KhachHang = db.DSCustomer.Find(MaKH);

                if (KhachHang != null)
                {
                    KhachHang.FullName = TenKH;
                    KhachHang.CreditCardNumber = Sothe;
                    KhachHang.Contact_Number = SDT;
                    KhachHang.Email = email;
                    KhachHang.Info_Address = DiaChi;
                    db.SaveChanges();
                }
            }
        }

        public static bool XoaKhachHang(string MaKH)
        {
            using (DataAccess db = new DataAccess())
            {
                Customer KhachHang = db.DSCustomer.Find(MaKH);

                if (KhachHang != null)
                {
                    bool isUsedInTransactions = db.DSTrans.Any(x => x.Customer_ID == MaKH);
                    if (!isUsedInTransactions)
                    {
                        db.DSCustomer.Remove(KhachHang);
                        db.SaveChanges();
                        return true;
                    }                    
                }
            }
            return false;
        }
        //Salers
        public static void ThemNhanVien(string MaNV,string TenNV,string SDT,string Email,string DiaChi,int Luong)
        {
            using (DataAccess db = new DataAccess())
            {
                Saler NhanVien = new Saler()
                {           
                    SalesPerson_ID = MaNV,
                    FullName = TenNV,
                    ContactNumber = SDT,
                    Email = Email,
                    Info_Address = DiaChi,
                    Salary = Luong,
                };
                db.DSSaler.Add(NhanVien);
                db.SaveChanges();
            }
        }
        public static void SuaNhanVien(string MaNV, string TenNV, string SDT, string Email, string DiaChi, int Luong)
        {
            using (DataAccess db = new DataAccess())
            {
                Saler NhanVien = db.DSSaler.Find(MaNV);

                if (NhanVien != null)
                {
                    NhanVien.SalesPerson_ID = MaNV;
                    NhanVien.FullName = TenNV;
                    NhanVien.ContactNumber = SDT;
                    NhanVien.Email = Email;
                    NhanVien.Info_Address = DiaChi;
                    NhanVien.Salary = Luong;
                    db.SaveChanges();
                }
            }
        }

        public static bool XoaNhanVien(string MaNV)
        {
            using (DataAccess db = new DataAccess())
            {
                Saler NhanVien = db.DSSaler.Find(MaNV);

                if (NhanVien != null)
                {
                    bool isUsedInTransactions = db.DSTrans.Any(x => x.SalesPerson_ID == MaNV);
                    if (!isUsedInTransactions)
                    {
                        db.DSSaler.Remove(NhanVien);
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            return false;
        }
        //Cars
        public static void ThemXe(string MaXe, string TenXe, string MaNSX, int Nam, string MauXe, int Gia)
        {
            using (DataAccess db = new DataAccess())
            {
                Car Xe = new Car()
                {
                    Car_ID = MaXe,
                    Model_Name = TenXe,
                    Man_ID = MaNSX,
                    Model_Year = Nam,
                    PaintColor = MauXe,
                    Price = Gia,
                };
                db.DSCar.Add(Xe);
                db.SaveChanges();
            }
        }
        public static void SuaXe(string MaXe, string TenXe, string MaNSX, int Nam, string MauXe, int Gia)
        {
            using (DataAccess db = new DataAccess())
            {
                Car Xe = db.DSCar.Find(MaXe);

                if (Xe != null)
                {
                    Xe.Model_Name = TenXe;
                    Xe.Man_ID = MaNSX;
                    Xe.Model_Year = Nam;
                    Xe.PaintColor = MauXe;
                    Xe.Price = Gia;
                    db.SaveChanges();
                }
            }
        }

        public static bool XoaXe(string MaXe)
        {
            using (DataAccess db = new DataAccess())
            {
                Car Xe = db.DSCar.Find(MaXe);

                if (Xe != null)
                {
                    bool isUsedInTransactions = db.DSTrans.Any(x => x.Car_ID == MaXe);
                    if (!isUsedInTransactions)
                    {
                        db.DSCar.Remove(Xe);
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            return false;
        }
        //Manu
        public static void ThemNSX(string MaNSX, string TenNSX, string Diachi)
        {
            using (DataAccess db = new DataAccess())
            {
                Manufacturer NSX = new Manufacturer()
                {
                    Man_ID = MaNSX,
                    Man_Name = TenNSX,
                    Man_Location = Diachi,
                };
                db.DSManu.Add(NSX);
                db.SaveChanges();
            }
        }
        public static void SuaNSX(string MaNSX, string TenNSX, string Diachi)
        {
            using (DataAccess db = new DataAccess())
            {
                Manufacturer NSX = db.DSManu.Find(MaNSX);

                if (NSX != null)
                {                    
                    NSX.Man_Name = TenNSX;
                    NSX.Man_Location = Diachi;
                    db.SaveChanges();
                }
            }
        }

        public static bool XoaNSX(string MaNSX)
        {
            using (DataAccess db = new DataAccess())
            {
                Manufacturer NSX = db.DSManu.Find(MaNSX);

                if (NSX != null)
                {                    
                    List<Car> manufacturerCars = db.DSCar.Where(c => c.Man_ID == MaNSX).ToList();                    
                    bool isUsedInTransactions = db.DSTrans.AsEnumerable().Any(t => manufacturerCars.Any(c => c.Car_ID == t.Car_ID));
                    if (!isUsedInTransactions)
                    {                        
                        db.DSCar.RemoveRange(manufacturerCars);                        
                        db.DSManu.Remove(NSX);                        
                        db.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
        }
        //Trans
        public static void ThemGiaoDich(string MaGD, string MaKH, string MaNV, string MaXe,int thue)
        {
            using(DataAccess db = new DataAccess())
            {
                Transaction GiaoDich = new Transaction()
                {                     
                    Transaction_ID = MaGD,
                    SalesPerson_ID = MaNV,
                    Customer_ID = MaKH,
                    Car_ID = MaXe,
                    Taxes_Fees = thue,
                };
                db.DSTrans.Add(GiaoDich);
                db.SaveChanges();
            }
        }
        public static void SuaGiaoDich(string MaGD, string MaKH,string MaNV,  string MaXe, int thue)
        {
            using (DataAccess db = new DataAccess())
            {
                Transaction GiaoDich = db.DSTrans.Find(MaGD);

                if (GiaoDich != null)
                {
                    GiaoDich.Transaction_ID = MaGD;
                    GiaoDich.SalesPerson_ID = MaNV;
                    GiaoDich.Customer_ID = MaKH;
                    GiaoDich.Car_ID = MaXe;
                    GiaoDich.Taxes_Fees = thue;
                    db.SaveChanges();
                }
            }
        }

        public static bool XoaGiaoDich(string MaGD)
        {
            using (DataAccess db = new DataAccess())
            {
                Transaction GiaoDich = db.DSTrans.Find(MaGD);

                if (GiaoDich != null)
                {                                        
                    db.DSTrans.Remove(GiaoDich);
                    db.SaveChanges();
                    return true;                    
                }
            }
            return false;
        }
    }
}
