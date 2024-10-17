namespace GUI_Class.ChildForm
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txt_SoThe = new TextBox();
            txt_Mail = new TextBox();
            txt_DiaChi = new TextBox();
            txt_MaKH = new TextBox();
            txt_Ten = new TextBox();
            txt_SDT = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_KhachHang = new DataGridView();
            btn_XoaKH = new Button();
            btn_SuaKH = new Button();
            btn_ThemKH = new Button();
            groupBox1 = new GroupBox();
            Col_CusID = new DataGridViewTextBoxColumn();
            Col_Fullname = new DataGridViewTextBoxColumn();
            Col_SDT = new DataGridViewTextBoxColumn();
            Col_CaID = new DataGridViewTextBoxColumn();
            Col_Email = new DataGridViewTextBoxColumn();
            Col_Address = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_KhachHang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_SoThe);
            panel1.Controls.Add(txt_Mail);
            panel1.Controls.Add(txt_DiaChi);
            panel1.Controls.Add(txt_MaKH);
            panel1.Controls.Add(txt_Ten);
            panel1.Controls.Add(txt_SDT);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(69, 385);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 148);
            panel1.TabIndex = 26;
            // 
            // txt_SoThe
            // 
            txt_SoThe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SoThe.Location = new Point(90, 99);
            txt_SoThe.Name = "txt_SoThe";
            txt_SoThe.Size = new Size(247, 25);
            txt_SoThe.TabIndex = 17;
            // 
            // txt_Mail
            // 
            txt_Mail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Mail.Location = new Point(447, 60);
            txt_Mail.Name = "txt_Mail";
            txt_Mail.Size = new Size(247, 25);
            txt_Mail.TabIndex = 16;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DiaChi.Location = new Point(447, 102);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(247, 25);
            txt_DiaChi.TabIndex = 15;
            // 
            // txt_MaKH
            // 
            txt_MaKH.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaKH.Location = new Point(90, 18);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.Size = new Size(247, 25);
            txt_MaKH.TabIndex = 14;
            // 
            // txt_Ten
            // 
            txt_Ten.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Ten.Location = new Point(90, 60);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(247, 25);
            txt_Ten.TabIndex = 13;
            // 
            // txt_SDT
            // 
            txt_SDT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SDT.Location = new Point(447, 17);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(247, 25);
            txt_SDT.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(379, 103);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 11;
            label7.Text = "Địa chỉ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(379, 60);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 10;
            label6.Text = "Email : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(379, 18);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 9;
            label5.Text = "SĐT :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 59);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 8;
            label4.Text = "Họ và tên : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 102);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 7;
            label3.Text = "Số thẻ : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 17);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 6;
            label2.Text = "Mã KH :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 19);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 22;
            label1.Text = "Thông tin khách hàng";
            // 
            // dgv_KhachHang
            // 
            dgv_KhachHang.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_KhachHang.Columns.AddRange(new DataGridViewColumn[] { Col_CusID, Col_Fullname, Col_SDT, Col_CaID, Col_Email, Col_Address });
            dgv_KhachHang.Location = new Point(69, 57);
            dgv_KhachHang.Name = "dgv_KhachHang";
            dgv_KhachHang.ReadOnly = true;
            dgv_KhachHang.RowHeadersWidth = 51;
            dgv_KhachHang.RowTemplate.Height = 25;
            dgv_KhachHang.Size = new Size(939, 299);
            dgv_KhachHang.TabIndex = 6;
            dgv_KhachHang.CellClick += dgv_KhachHang_CellClick;
            // 
            // btn_XoaKH
            // 
            btn_XoaKH.Dock = DockStyle.Top;
            btn_XoaKH.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XoaKH.Location = new Point(3, 109);
            btn_XoaKH.Name = "btn_XoaKH";
            btn_XoaKH.Size = new Size(207, 45);
            btn_XoaKH.TabIndex = 21;
            btn_XoaKH.Text = "Xóa thông tin KH";
            btn_XoaKH.UseVisualStyleBackColor = true;
            btn_XoaKH.Click += btn_XoaKH_Click;
            // 
            // btn_SuaKH
            // 
            btn_SuaKH.Dock = DockStyle.Top;
            btn_SuaKH.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaKH.Location = new Point(3, 64);
            btn_SuaKH.Name = "btn_SuaKH";
            btn_SuaKH.Size = new Size(207, 45);
            btn_SuaKH.TabIndex = 23;
            btn_SuaKH.Text = "Sửa thông tin KH";
            btn_SuaKH.UseVisualStyleBackColor = true;
            btn_SuaKH.Click += btn_SuaKH_Click;
            // 
            // btn_ThemKH
            // 
            btn_ThemKH.Dock = DockStyle.Top;
            btn_ThemKH.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemKH.Location = new Point(3, 19);
            btn_ThemKH.Name = "btn_ThemKH";
            btn_ThemKH.Size = new Size(207, 45);
            btn_ThemKH.TabIndex = 20;
            btn_ThemKH.Text = "Thêm thông tin KH";
            btn_ThemKH.UseVisualStyleBackColor = true;
            btn_ThemKH.Click += btn_ThemKH_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_XoaKH);
            groupBox1.Controls.Add(btn_SuaKH);
            groupBox1.Controls.Add(btn_ThemKH);
            groupBox1.Location = new Point(795, 374);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 159);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control buttons";
            // 
            // Col_CusID
            // 
            Col_CusID.DataPropertyName = "Customer_ID";
            Col_CusID.HeaderText = "Mã KH";
            Col_CusID.MinimumWidth = 6;
            Col_CusID.Name = "Col_CusID";
            Col_CusID.ReadOnly = true;
            Col_CusID.Width = 110;
            // 
            // Col_Fullname
            // 
            Col_Fullname.DataPropertyName = "FullName";
            Col_Fullname.HeaderText = "Họ và tên";
            Col_Fullname.MinimumWidth = 6;
            Col_Fullname.Name = "Col_Fullname";
            Col_Fullname.ReadOnly = true;
            Col_Fullname.Width = 200;
            // 
            // Col_SDT
            // 
            Col_SDT.DataPropertyName = "Contact_Number";
            Col_SDT.HeaderText = "Số điện thoại";
            Col_SDT.MinimumWidth = 6;
            Col_SDT.Name = "Col_SDT";
            Col_SDT.ReadOnly = true;
            Col_SDT.Width = 150;
            // 
            // Col_CaID
            // 
            Col_CaID.DataPropertyName = "CreditCardNumber";
            Col_CaID.HeaderText = "Số thẻ";
            Col_CaID.MinimumWidth = 6;
            Col_CaID.Name = "Col_CaID";
            Col_CaID.ReadOnly = true;
            Col_CaID.Width = 150;
            // 
            // Col_Email
            // 
            Col_Email.DataPropertyName = "Email";
            Col_Email.HeaderText = "Email";
            Col_Email.MinimumWidth = 6;
            Col_Email.Name = "Col_Email";
            Col_Email.ReadOnly = true;
            Col_Email.Width = 125;
            // 
            // Col_Address
            // 
            Col_Address.DataPropertyName = "Info_Address";
            Col_Address.HeaderText = "Địa chỉ";
            Col_Address.MinimumWidth = 6;
            Col_Address.Name = "Col_Address";
            Col_Address.ReadOnly = true;
            Col_Address.Width = 150;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgv_KhachHang);
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_KhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox txt_SoThe;
        private TextBox txt_Mail;
        private TextBox txt_DiaChi;
        private TextBox txt_MaKH;
        private TextBox txt_Ten;
        private TextBox txt_SDT;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_KhachHang;
        private Button btn_XoaKH;
        private Button btn_SuaKH;
        private Button btn_ThemKH;
        private DataGridViewTextBoxColumn Col_CusID;
        private DataGridViewTextBoxColumn Col_Fullname;
        private DataGridViewTextBoxColumn Col_SDT;
        private DataGridViewTextBoxColumn Col_CaID;
        private DataGridViewTextBoxColumn Col_Email;
        private DataGridViewTextBoxColumn Col_Address;
        private GroupBox groupBox1;
    }
}