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
    public partial class Car_models : Form
    {
        List<BLL.Xe> DSXe = new List<BLL.Xe>();
        public static DataTable dt = BLL.LayXe().dt;
        
        private int rowindex = -1;
        public Car_models()
        {
            InitializeComponent();
        }

        // RETURN THE DATA FROM BLL LAYER.
        private DataTable Get_Cars_data()
        {
            return BLL.LayXe().dt;
        }

        private void Car_models_Load(object sender, EventArgs e)
        {
            dgv_Cars.DataSource = Get_Cars_data();
            foreach (DataRow dr in Get_Cars_data().Rows)
            {
                DSXe.Add(new BLL.Xe(dr["Car_ID"].ToString(), dr["Model_Name"].ToString(), dr["Man_ID"].ToString(),
                                    Convert.ToInt32(dr["Model_Year"]), dr["PaintColor"].ToString(), Convert.ToInt32(dr["Price"])));

            }
            foreach (DataRow dr in BLL.LayNSX().Rows)
            {
                cbb_nsx.Items.Add(dr["Man_ID"].ToString());
            }
        }
        private static bool Empty_Check(TextBox txt1, TextBox txt2, ComboBox cbb, TextBox txt3, TextBox txt4, TextBox txt5)
        {
            if (string.IsNullOrEmpty(txt1.Text) || string.IsNullOrEmpty(txt2.Text) || cbb.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txt3.Text) || string.IsNullOrEmpty(txt4.Text) || string.IsNullOrEmpty(txt5.Text))
            {
                return true;
            }
            return false;
        }

        private void dgv_Cars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr = dgv_Cars.Rows[rowindex];
                txt_MaXe.Text = Convert.ToString(dr.Cells["Col_CarID"].Value);
                txt_TenXe.Text = Convert.ToString(dr.Cells["Col_NameModel"].Value);
                for (int i = 0; i < cbb_nsx.Items.Count; i++)
                {
                    if (cbb_nsx.Items[i].ToString() == Convert.ToString(dr.Cells["Col_ManID"].Value))
                    {
                        cbb_nsx.SelectedIndex = i;
                    }
                }
                txt_NamSX.Text = Convert.ToString(dr.Cells["Col_year"].Value);
                txt_MauSon.Text = Convert.ToString(dr.Cells["Col_Color"].Value);
                txt_GiaTien.Text = Convert.ToString(dr.Cells["Col_Price"].Value);
            }
        }

        private void btn_ThemXe_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaXe, txt_TenXe, cbb_nsx, txt_NamSX, txt_MauSon, txt_GiaTien))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool tontai = false;
                foreach (BLL.Xe xe in DSXe)
                {
                    if (txt_MaXe.Text == xe.maxe.Trim())
                    {
                        MessageBox.Show("Xe đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tontai = true;
                    }
                }
                if (!tontai)
                {
                    BLL.ThemXe(txt_MaXe.Text, txt_TenXe.Text, cbb_nsx.SelectedItem.ToString(), Convert.ToInt32(txt_NamSX.Text), txt_MauSon.Text, Convert.ToInt32(txt_GiaTien.Text));
                    dgv_Cars.DataSource = Get_Cars_data();
                }
            }
        }

        private void btn_SuaXe_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaXe, txt_TenXe, cbb_nsx, txt_NamSX, txt_MauSon, txt_GiaTien))
            {
                MessageBox.Show("Chọn thông tin xe cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BLL.SuaThongTinXe(txt_MaXe.Text, txt_TenXe.Text, cbb_nsx.SelectedItem.ToString(), Convert.ToInt32(txt_NamSX.Text), txt_MauSon.Text, Convert.ToInt32(txt_GiaTien.Text));
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                dgv_Cars.DataSource = Get_Cars_data();
                foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                {
                    txt.Clear();
                }
                cbb_nsx.SelectedIndex = -1;
            }
        }

        private void btn_XoaXe_Click(object sender, EventArgs e)
        {
            if (Empty_Check(txt_MaXe, txt_TenXe, cbb_nsx, txt_NamSX, txt_MauSon, txt_GiaTien))
            {
                MessageBox.Show("Chọn thông tin xe cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BLL.XoaThongTinXe(txt_MaXe.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgv_Cars.DataSource = Get_Cars_data();
                    foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                    cbb_nsx.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Không thể xóa xe vì đang có giao dịch liên quan. Vui lòng xóa giao dịch !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                    cbb_nsx.SelectedIndex = -1;
                }
            }
        }

      
    }
}
