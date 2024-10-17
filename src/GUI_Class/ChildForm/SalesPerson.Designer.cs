namespace GUI_Class.ChildForm
{
    partial class SalesPerson
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
            txt_SDT = new TextBox();
            txt_DiaChi = new TextBox();
            txt_Luong = new TextBox();
            txt_MaNV = new TextBox();
            txt_Ten = new TextBox();
            txt_Mail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_NV = new DataGridView();
            Col_CusID = new DataGridViewTextBoxColumn();
            Col_Fullname = new DataGridViewTextBoxColumn();
            Col_SDT = new DataGridViewTextBoxColumn();
            Col_CaID = new DataGridViewTextBoxColumn();
            Col_Info_Address = new DataGridViewTextBoxColumn();
            Col_Salary = new DataGridViewTextBoxColumn();
            btn_XoaNV = new Button();
            btn_SuaNV = new Button();
            btn_ThemNV = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NV).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_SDT);
            panel1.Controls.Add(txt_DiaChi);
            panel1.Controls.Add(txt_Luong);
            panel1.Controls.Add(txt_MaNV);
            panel1.Controls.Add(txt_Ten);
            panel1.Controls.Add(txt_Mail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(49, 387);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 148);
            panel1.TabIndex = 34;
            // 
            // txt_SDT
            // 
            txt_SDT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SDT.Location = new Point(80, 99);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(247, 25);
            txt_SDT.TabIndex = 17;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DiaChi.Location = new Point(422, 60);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(247, 25);
            txt_DiaChi.TabIndex = 16;
            // 
            // txt_Luong
            // 
            txt_Luong.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Luong.Location = new Point(422, 102);
            txt_Luong.Name = "txt_Luong";
            txt_Luong.Size = new Size(247, 25);
            txt_Luong.TabIndex = 15;
            // 
            // txt_MaNV
            // 
            txt_MaNV.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaNV.Location = new Point(80, 18);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(247, 25);
            txt_MaNV.TabIndex = 14;
            // 
            // txt_Ten
            // 
            txt_Ten.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Ten.Location = new Point(80, 60);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(247, 25);
            txt_Ten.TabIndex = 13;
            // 
            // txt_Mail
            // 
            txt_Mail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Mail.Location = new Point(422, 17);
            txt_Mail.Name = "txt_Mail";
            txt_Mail.Size = new Size(247, 25);
            txt_Mail.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(354, 103);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 11;
            label7.Text = "Lương : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(354, 60);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 10;
            label6.Text = "Địa chỉ :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(354, 18);
            label5.Name = "label5";
            label5.Size = new Size(50, 17);
            label5.TabIndex = 9;
            label5.Text = "Email : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 59);
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
            label3.Location = new Point(11, 102);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 7;
            label3.Text = "SĐT :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 17);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 6;
            label2.Text = "Mã NV :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 19);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 30;
            label1.Text = "Thông tin nhân viên";
            // 
            // dgv_NV
            // 
            dgv_NV.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_NV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NV.Columns.AddRange(new DataGridViewColumn[] { Col_CusID, Col_Fullname, Col_SDT, Col_CaID, Col_Info_Address, Col_Salary });
            dgv_NV.Location = new Point(49, 59);
            dgv_NV.Name = "dgv_NV";
            dgv_NV.ReadOnly = true;
            dgv_NV.RowHeadersWidth = 51;
            dgv_NV.RowTemplate.Height = 25;
            dgv_NV.Size = new Size(913, 307);
            dgv_NV.TabIndex = 27;
            dgv_NV.CellClick += dgv_NV_CellClick;
            // 
            // Col_CusID
            // 
            Col_CusID.DataPropertyName = "SalesPerson_ID";
            Col_CusID.HeaderText = "Mã NV";
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
            Col_SDT.DataPropertyName = "ContactNumber";
            Col_SDT.HeaderText = "Số điện thoại";
            Col_SDT.MinimumWidth = 6;
            Col_SDT.Name = "Col_SDT";
            Col_SDT.ReadOnly = true;
            Col_SDT.Width = 150;
            // 
            // Col_CaID
            // 
            Col_CaID.DataPropertyName = "Email";
            Col_CaID.HeaderText = "Email ";
            Col_CaID.MinimumWidth = 6;
            Col_CaID.Name = "Col_CaID";
            Col_CaID.ReadOnly = true;
            Col_CaID.Width = 150;
            // 
            // Col_Info_Address
            // 
            Col_Info_Address.DataPropertyName = "Info_Address";
            Col_Info_Address.HeaderText = "Địa chỉ";
            Col_Info_Address.MinimumWidth = 6;
            Col_Info_Address.Name = "Col_Info_Address";
            Col_Info_Address.ReadOnly = true;
            Col_Info_Address.Width = 125;
            // 
            // Col_Salary
            // 
            Col_Salary.DataPropertyName = "Salary";
            Col_Salary.HeaderText = "Lương";
            Col_Salary.MinimumWidth = 6;
            Col_Salary.Name = "Col_Salary";
            Col_Salary.ReadOnly = true;
            Col_Salary.Width = 125;
            // 
            // btn_XoaNV
            // 
            btn_XoaNV.Dock = DockStyle.Top;
            btn_XoaNV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XoaNV.Location = new Point(3, 109);
            btn_XoaNV.Name = "btn_XoaNV";
            btn_XoaNV.Size = new Size(195, 45);
            btn_XoaNV.TabIndex = 29;
            btn_XoaNV.Text = "Xóa thông tin NV";
            btn_XoaNV.UseVisualStyleBackColor = true;
            btn_XoaNV.Click += btn_XoaNV_Click;
            // 
            // btn_SuaNV
            // 
            btn_SuaNV.Dock = DockStyle.Top;
            btn_SuaNV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaNV.Location = new Point(3, 64);
            btn_SuaNV.Name = "btn_SuaNV";
            btn_SuaNV.Size = new Size(195, 45);
            btn_SuaNV.TabIndex = 31;
            btn_SuaNV.Text = "Sửa thông tin NV";
            btn_SuaNV.UseVisualStyleBackColor = true;
            btn_SuaNV.Click += btn_SuaNV_Click;
            // 
            // btn_ThemNV
            // 
            btn_ThemNV.Dock = DockStyle.Top;
            btn_ThemNV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemNV.Location = new Point(3, 19);
            btn_ThemNV.Name = "btn_ThemNV";
            btn_ThemNV.Size = new Size(195, 45);
            btn_ThemNV.TabIndex = 28;
            btn_ThemNV.Text = "Thêm NV mới";
            btn_ThemNV.UseVisualStyleBackColor = true;
            btn_ThemNV.Click += btn_ThemNV_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_XoaNV);
            groupBox1.Controls.Add(btn_SuaNV);
            groupBox1.Controls.Add(btn_ThemNV);
            groupBox1.Location = new Point(761, 377);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 158);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control buttons";
            // 
            // SalesPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 561);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgv_NV);
            Name = "SalesPerson";
            Text = "SalesPerson";
            Load += SalesPerson_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NV).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox txt_SDT;
        private TextBox txt_DiaChi;
        private TextBox txt_Luong;
        private TextBox txt_MaNV;
        private TextBox txt_Ten;
        private TextBox txt_Mail;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_NV;
        private Button btn_XoaNV;
        private Button btn_SuaNV;
        private Button btn_ThemNV;
        private DataGridViewTextBoxColumn Col_CusID;
        private DataGridViewTextBoxColumn Col_Fullname;
        private DataGridViewTextBoxColumn Col_SDT;
        private DataGridViewTextBoxColumn Col_CaID;
        private DataGridViewTextBoxColumn Col_Info_Address;
        private DataGridViewTextBoxColumn Col_Salary;
        private GroupBox groupBox1;
    }
}