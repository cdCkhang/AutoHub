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
    public partial class SalesPerson : Form
    {
        List<BLL.NhanVien> DSNhanVien = new List<BLL.NhanVien>();
        private int rowindex = -1;
        public SalesPerson()
        {
            InitializeComponent();
        }

        private void SalesPerson_Load(object sender, EventArgs e)
        {
            dgv_NV.DataSource = BLL.LayNV();
            foreach (DataRow dr in BLL.LayNV().Rows)
            {
                DSNhanVien.Add(new BLL.NhanVien(dr["SalesPerson_ID"].ToString(), dr["FullName"].ToString(), dr["ContactNumber"].ToString(),
                                                dr["Email"].ToString(), dr["Info_Address"].ToString(), Convert.ToInt32(dr["Salary"])));
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

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaNV, txt_Ten, txt_SDT, txt_Mail, txt_DiaChi, txt_Luong))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool tontai = false;
                foreach (BLL.NhanVien nhanvien in DSNhanVien)
                {
                    if (txt_MaNV.Text.Trim() == nhanvien.manv.Trim() || txt_Mail.Text.Trim() == nhanvien.mail.Trim())
                    {
                        MessageBox.Show("Nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tontai = true;
                    }
                }
                if (!tontai)
                {
                    BLL.ThemNhanVien(txt_MaNV.Text, txt_Ten.Text, txt_SDT.Text, txt_Mail.Text, txt_DiaChi.Text, Convert.ToInt32(txt_Luong.Text));
                    dgv_NV.DataSource = BLL.LayNV();
                }
            }
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaNV, txt_Ten, txt_SDT, txt_Mail, txt_DiaChi, txt_Luong))
            {
                MessageBox.Show("Chọn thông tin nhân viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BLL.SuaThongTinNhanVien(txt_MaNV.Text, txt_Ten.Text, txt_SDT.Text, txt_Mail.Text, txt_DiaChi.Text, Convert.ToInt32(txt_Luong.Text));
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                dgv_NV.DataSource = BLL.LayNV();
                foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                {
                    txt.Clear();
                }
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaNV, txt_Ten, txt_SDT, txt_Mail, txt_DiaChi, txt_Luong))
            {
                MessageBox.Show("Chọn thông tin nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BLL.XoaThongTinKhach(txt_MaNV.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgv_NV.DataSource = BLL.LayNV();
                    foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa nhân viên vì đang có giao dịch liên quan", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                }
            }
        }

        private void dgv_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr = dgv_NV.Rows[rowindex];
                txt_MaNV.Text = Convert.ToString(dr.Cells["Col_CusID"].Value);
                txt_Ten.Text = Convert.ToString(dr.Cells["Col_Fullname"].Value);
                txt_SDT.Text = Convert.ToString(dr.Cells["Col_SDT"].Value);
                txt_Mail.Text = Convert.ToString(dr.Cells["Col_CaID"].Value);
                txt_DiaChi.Text = Convert.ToString(dr.Cells["Col_Info_Address"].Value);
                txt_Luong.Text = Convert.ToString(dr.Cells["Col_Salary"].Value);
            }
        }
    }
}
