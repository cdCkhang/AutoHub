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
    public partial class Transactions : Form
    {
        List<BLL.KhachHang> DSKhachHang = new List<BLL.KhachHang>();
        List<BLL.Xe> DSXe = new List<BLL.Xe>();
        List<BLL.NhanVien> DSNhanVien = new List<BLL.NhanVien>();
        List<BLL.GiaoDich> DSGiaoDich = new List<BLL.GiaoDich>();
        public static DataTable dt = BLL.LayKhachHang().dt;
        public static DataTable dt2 = BLL.LayXe().dt;        
        private int rowindex = -1;
        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            dgv_Trans.DataSource = BLL.LayGD();
            foreach (DataRow dr in BLL.LayGD().Rows)
            {
                DSGiaoDich.Add(new BLL.GiaoDich(dr["Transaction_ID"].ToString(), dr["Customer_ID"].ToString(), dr["SalesPerson_ID"].ToString(),
                                                dr["Car_ID"].ToString(), Convert.ToInt32(dr["Taxes_Fees"])));
            }
            foreach (DataRow dr in dt.Rows)
            {
                cbb_MaKH.Items.Add(dr["Customer_ID"]);
            }
            foreach (DataRow dr in BLL.LayNV().Rows)
            {
                cbb_MaNV.Items.Add(dr["SalesPerson_ID"]);
            }
            foreach (DataRow dr in dt2.Rows)
            {
                cbb_MaXe.Items.Add(dr["Car_ID"]);
            }
        }
        private static bool Empty_Check(TextBox txt1, ComboBox cbb1, ComboBox cbb2, ComboBox cbb3, TextBox txt2)
        {
            if (string.IsNullOrEmpty(txt1.Text) || cbb1.SelectedIndex == -1 || cbb2.SelectedIndex == -1 ||
                cbb3.SelectedIndex == -1 || string.IsNullOrEmpty(txt2.Text))
            {
                return true;
            }
            return false;
        }

        private void btn_ThemGD_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaGD, cbb_MaKH, cbb_MaNV, cbb_MaXe, txt_Thue))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool tontai = false;
                foreach (BLL.GiaoDich giaodich in DSGiaoDich)
                {
                    if (txt_MaGD.Text.Trim() == giaodich.magd.Trim())
                    {
                        MessageBox.Show("Giao dịch đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tontai = true;
                    }
                }
                if (!tontai)
                {
                    BLL.ThemGiaoDich(txt_MaGD.Text, cbb_MaKH.SelectedItem.ToString(), cbb_MaNV.SelectedItem.ToString(), cbb_MaXe.SelectedItem.ToString(), Convert.ToInt32(txt_Thue.Text));
                    dgv_Trans.DataSource = BLL.LayGD();
                    foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                    foreach (ComboBox cbb in panel1.Controls.OfType<ComboBox>())
                    {
                        cbb.SelectedIndex = -1;
                    }
                }
            }
        }

        private void btn_SuaGD_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaGD, cbb_MaKH, cbb_MaNV, cbb_MaXe, txt_Thue))
            {
                MessageBox.Show("Chọn thông tin giao dịch cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BLL.SuaGiaoDich(txt_MaGD.Text, cbb_MaKH.SelectedItem.ToString(), cbb_MaNV.SelectedItem.ToString(), cbb_MaXe.SelectedItem.ToString(), Convert.ToInt32(txt_Thue.Text));
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                dgv_Trans.DataSource = BLL.LayGD();
                foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                {
                    txt.Clear();
                }
                foreach (ComboBox cbb in panel1.Controls.OfType<ComboBox>())
                {
                    cbb.SelectedIndex = -1;
                }
            }
        }

        private void btn_XoaGD_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaGD, cbb_MaKH, cbb_MaNV, cbb_MaXe, txt_Thue))
            {
                MessageBox.Show("Chọn thông tin giao dịch cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BLL.XoaGiaoDich(txt_MaGD.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgv_Trans.DataSource = BLL.LayGD();
                    foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                    foreach (ComboBox cbb in panel1.Controls.OfType<ComboBox>())
                    {
                        cbb.SelectedIndex = -1;
                    }
                }
            }
        }

        private void dgv_Trans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr = dgv_Trans.Rows[rowindex];
                txt_MaGD.Text = Convert.ToString(dr.Cells["Col_CusID"].Value);
                txt_Thue.Text = Convert.ToString(dr.Cells["Col_Taxes"].Value);
                txt_Tong.Text = Convert.ToString(dr.Cells["Col_Tong"].Value);
                for (int i = 0; i < cbb_MaKH.Items.Count; i++)
                {
                    if (cbb_MaKH.Items[i].ToString() == Convert.ToString(dr.Cells["Col_Fullname"].Value))
                    {
                        cbb_MaKH.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbb_MaNV.Items.Count; i++)
                {
                    if (cbb_MaNV.Items[i].ToString() == Convert.ToString(dr.Cells["Col_SDT"].Value))
                    {
                        cbb_MaNV.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cbb_MaXe.Items.Count; i++)
                {
                    if (cbb_MaXe.Items[i].ToString() == Convert.ToString(dr.Cells["Col_CaID"].Value))
                    {
                        cbb_MaXe.SelectedIndex = i;
                    }
                }
            }
        }
    }
}
