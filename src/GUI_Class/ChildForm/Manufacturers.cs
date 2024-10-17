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
    public partial class Manufacturers : Form
    {
        List<BLL.NSX> DSNSX = new List<BLL.NSX>();
        private int rowindex = -1;
        public Manufacturers()
        {
            InitializeComponent();
        }

        private void Manufacturers_Load(object sender, EventArgs e)
        {
            dgv_NSX.DataSource = BLL.LayNSX();
            foreach (DataRow dr in BLL.LayNSX().Rows)
            {
                DSNSX.Add(new BLL.NSX(dr["Man_ID"].ToString(), dr["Man_Name"].ToString(), dr["Man_Location"].ToString()));

            }
        }
        private static bool Empty_Check(TextBox txt1, TextBox txt2, TextBox txt3)
        {
            if (string.IsNullOrEmpty(txt1.Text) || string.IsNullOrEmpty(txt2.Text) || string.IsNullOrEmpty(txt3.Text))
            {
                return true;
            }
            return false;
        }

        private void dgv_NSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr = dgv_NSX.Rows[rowindex];
                txt_MaNSX.Text = Convert.ToString(dr.Cells["Col_CusID"].Value);
                txt_TenNSX.Text = Convert.ToString(dr.Cells["Col_Fullname"].Value);
                txt_DiaChi.Text = Convert.ToString(dr.Cells["Col_Address"].Value);
            }
        }

        private void btn_ThemNSX_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaNSX, txt_TenNSX, txt_DiaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool tontai = false;
                foreach (BLL.NSX nsx in DSNSX)
                {
                    if (txt_MaNSX.Text.Trim() == nsx.ma.Trim() || txt_TenNSX.Text.Trim() == nsx.ten.Trim())
                    {
                        MessageBox.Show("Nhà sản xuất đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tontai = true;
                    }
                }
                if (!tontai)
                {
                    BLL.ThemNSX(txt_MaNSX.Text, txt_TenNSX.Text, txt_DiaChi.Text);
                    dgv_NSX.DataSource = BLL.LayNSX();
                }
            }
        }
        private void btn_SuaNSX_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaNSX, txt_TenNSX, txt_DiaChi))
            {
                MessageBox.Show("Chọn thông tin nhà sản xuất cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BLL.SuaNSX(txt_MaNSX.Text, txt_TenNSX.Text, txt_DiaChi.Text);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                dgv_NSX.DataSource = BLL.LayNSX();
                foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                {
                    txt.Clear();
                }
            }
        }

        private void btnXoaNSX_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaNSX, txt_TenNSX, txt_DiaChi))
            {
                MessageBox.Show("Chọn thông tin nhà sản xuất cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BLL.XoaNSX(txt_MaNSX.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgv_NSX.DataSource = BLL.LayNSX();
                    foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa vì có giao dịch liên quan");
                    foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                }
            }
        }
    }
}
