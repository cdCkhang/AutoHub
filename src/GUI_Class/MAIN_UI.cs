namespace GUI_Class
{
    public partial class MAIN_UI : Form
    {
        private Form activeForm;
        public MAIN_UI()
        {
            InitializeComponent();
        }

        private void MAIN_UI_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Label_Info.Text = "Welcome, "+Login.ValidUsername;            
            label4.Text = Login.job_title;            
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void ActiveButton(object btnsender)
        {
            DisableButton();
            if (btnsender is Button activeButton)
            {
                activeButton.BackColor = Color.FromArgb(45, 45, 110);
            }
        }
        private void DisableButton()
        {
            foreach (Control PrevBtn in panelMenu.Controls)
            {
                if (PrevBtn.GetType() == typeof(Button))
                {
                    PrevBtn.BackColor = Color.FromArgb(39, 39, 58);
                    PrevBtn.ForeColor = Color.White;
                }
            }
        }

        private void btn_Transacts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForm.Transactions(), sender);
            Label_Info.Text = " .: [ GIAO DỊCH ] :.";
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForm.Customers(), sender);
            Label_Info.Text = ".: [ KHÁCH HÀNG ] :.";
        }

        private void btn_Models_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForm.Car_models(), sender);
            Label_Info.Text = ".: [ MẪU XE ] :.";
        }

        private void btn_Manufacturers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForm.Manufacturers(), sender);
            Label_Info.Text = ".:[ NHÀ SẢN XUẤT ] :.";
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForm.SalesPerson(), sender);
            Label_Info.Text = ".: [ NHÂN VIÊN ] :.";
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForm.Statistics(), sender);
            Label_Info.Text = ".: [ THỐNG KÊ ] :.";
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                Login loginf = new Login();
                loginf.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString();
        }
    }
}