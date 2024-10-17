using BussinessLogicLayer;
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
    public partial class Customers : Form
    {
        List<BLL.KhachHang> DSKhacHang = new List<BLL.KhachHang>();
        DataTable dt = BLL.LayKhachHang().dt;
        private int rowindex = -1;
        public Customers()
        {
            InitializeComponent();
        }

        private DataTable GET_customers_data()
        {
            return BLL.LayKhachHang().dt;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            dgv_KhachHang.DataSource = GET_customers_data();
            foreach (DataRow dr in GET_customers_data().Rows)
            {
                DSKhacHang.Add(new BLL.KhachHang(dr["Customer_ID"].ToString(), dr["FullName"].ToString(), dr["CreditCardNumber"].ToString(),
                                                 dr["Contact_Number"].ToString(), dr["Email"].ToString(), dr["Info_Address"].ToString()));
            }
        }
        private static bool Empty_Check(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6)
        {
            if (string.IsNullOrEmpty(txt1.Text) || string.IsNullOrEmpty(txt2.Text) || string.IsNullOrEmpty(txt3.Text) ||
                string.IsNullOrEmpty(txt4.Text) || string.IsNullOrEmpty(txt5.Text) || string.IsNullOrEmpty(txt6.Text))
            {
                return true;
            }
            return false;
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaKH, txt_Ten, txt_SoThe, txt_SDT, txt_Mail, txt_DiaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool tontai = false;
                foreach (BLL.KhachHang khach in DSKhacHang)
                {
                    if (txt_MaKH.Text.Trim() == khach.makh.Trim() || txt_Mail.Text.Trim() == khach.mail.Trim())
                    {
                        MessageBox.Show("Người mua đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tontai = true;
                    }
                }
                if (!tontai)
                {
                    BLL.ThemKhach(txt_MaKH.Text, txt_Ten.Text, txt_SoThe.Text, txt_SDT.Text, txt_Mail.Text, txt_DiaChi.Text);
                    dgv_KhachHang.DataSource = GET_customers_data();
                }
            }
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr = dgv_KhachHang.Rows[rowindex];
                txt_MaKH.Text = Convert.ToString(dr.Cells["Col_CusID"].Value);
                txt_Ten.Text = Convert.ToString(dr.Cells["Col_Fullname"].Value);
                txt_SoThe.Text = Convert.ToString(dr.Cells["Col_CaID"].Value);
                txt_SDT.Text = Convert.ToString(dr.Cells["Col_SDT"].Value);
                txt_Mail.Text = Convert.ToString(dr.Cells["Col_Email"].Value);
                txt_DiaChi.Text = Convert.ToString(dr.Cells["Col_Address"].Value);
            }
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaKH, txt_Ten, txt_SoThe, txt_SDT, txt_Mail, txt_DiaChi))
            {
                MessageBox.Show("Chọn thông tin khách hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BLL.SuaThongTinKhach(txt_MaKH.Text, txt_Ten.Text, txt_SoThe.Text, txt_SDT.Text, txt_Mail.Text, txt_DiaChi.Text);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                dgv_KhachHang.DataSource = GET_customers_data();
                foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                {
                    txt.Clear();
                }
            }
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaKH, txt_Ten, txt_SoThe, txt_SDT, txt_Mail, txt_DiaChi))
            {
                MessageBox.Show("Chọn thông tin khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BLL.XoaThongTinKhach(txt_MaKH.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgv_KhachHang.DataSource = GET_customers_data();
                    foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa khách hàng vì đang có giao dịch liên quan", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                }
            }
        }
    }
}
