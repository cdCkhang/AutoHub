using BussinessLogicLayer;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class.ChildForm
{
    public partial class Statistics : Form
    {
        public static string GDID = "";
        public static string CarID = "";
        public static DataTable dt1 = BLL.LayThongKeGD().dt;
        public static DataTable dt2 = BLL.ThongKeXe().dt;
        public static int sogd = BLL.LayThongKeGD().SoGd;
        public static int soxe = BLL.ThongKeXe().soxe;
        public static double TongGT = BLL.LayThongKeGD().TongGT;
        public static double TongDT = BLL.LayThongKeGD().TongDT;
        public static int soKH = BLL.LayKhachHang().soKH;
        public static double TBxe = BLL.LayXe().tb;
        public static double year = BLL.LayXe().myear;
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

            dgv_Trans.DataSource = dt1;
            dgv_Cars.DataSource = dt2;
            txtbox_soGD.Text = sogd.ToString();
            txtbox_SoMau.Text = soxe.ToString();
            txt_TongGD.Text = TongGT.ToString();
            txtbox_TBGD.Text = Math.Round((TongGT / sogd), 1).ToString();
            txt_Doanhthu.Text = Math.Round(TongDT, 1).ToString();
            txtbox_DTTB.Text = Math.Round((TongDT / sogd), 1).ToString();
            txt_SoKH.Text = soKH.ToString();
            txtbox_TBXe.Text = Math.Round(TBxe, 1).ToString();
            txtbox_Nam.Text = Math.Round(year, 0).ToString();
        }

        private void btn_TimKiemGD_Click(object sender, EventArgs e)
        {
            GDID = txt_MaGD.Text;
            if (GDID != "")
            {
                dgv_Trans.DataSource = BLL.LayGDTheoID(GDID);
            }
            else
            {
                dgv_Trans.DataSource = dt1;
            }
        }
        private void btn_TimKiemXe_Click(object sender, EventArgs e)
        {
            CarID = txt_MaXe.Text;
            if (CarID != "")
            {
                dgv_Cars.DataSource = BLL.LayXeTheoID(CarID);
            }
            else
            {
                dgv_Cars.DataSource = dt2;
            }
        }
    }
}
