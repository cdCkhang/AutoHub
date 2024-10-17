using BussinessLogicLayer;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class
{
    public partial class Login : Form
    {
        public static string ValidUsername = "";
        public static List<Account> accountlist = new List<Account>();
        public static string job_title = "";
        public Login()
        {
            InitializeComponent();

        }
        private static bool EmptyCheck(TextBox txt1, TextBox txt2)
        {
            if (string.IsNullOrEmpty(txt1.Text) && string.IsNullOrEmpty(txt2.Text))
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txt1.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txt2.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private static bool ExitsCheck(TextBox txt1, TextBox txt2)
        {
            accountlist = BLL.DSAcc();
            for (int i = 0; i < accountlist.Count; i++)
            {
                if (accountlist[i].Account_Username == txt1.Text.Trim() && accountlist[i].Account_Password == txt2.Text.Trim())
                {
                    ValidUsername = accountlist[i].Account_Username;
                    job_title = accountlist[i].Job_Title;
                    return true;
                }
            }
            return false;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (EmptyCheck(txt_TaiKhoan, txt_MatKhau))
            {
                if (ExitsCheck(txt_TaiKhoan, txt_MatKhau))
                {
                    this.Hide();
                    MAIN_UI main_f = new MAIN_UI();
                    main_f.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
