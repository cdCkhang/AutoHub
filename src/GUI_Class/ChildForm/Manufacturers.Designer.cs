namespace GUI_Class.ChildForm
{
    partial class Manufacturers
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
            label1 = new Label();
            dgv_NSX = new DataGridView();
            Col_CusID = new DataGridViewTextBoxColumn();
            Col_Fullname = new DataGridViewTextBoxColumn();
            Col_Address = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            txt_DiaChi = new TextBox();
            txt_MaNSX = new TextBox();
            txt_TenNSX = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnXoaNSX = new Button();
            btn_SuaNSX = new Button();
            btn_ThemNSX = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_NSX).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 92);
            label1.Name = "label1";
            label1.Size = new Size(205, 25);
            label1.TabIndex = 24;
            label1.Text = "Thông tin nhà sản xuất";
            // 
            // dgv_NSX
            // 
            dgv_NSX.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_NSX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NSX.Columns.AddRange(new DataGridViewColumn[] { Col_CusID, Col_Fullname, Col_Address });
            dgv_NSX.Location = new Point(94, 132);
            dgv_NSX.Name = "dgv_NSX";
            dgv_NSX.ReadOnly = true;
            dgv_NSX.RowHeadersWidth = 51;
            dgv_NSX.RowTemplate.Height = 25;
            dgv_NSX.Size = new Size(505, 326);
            dgv_NSX.TabIndex = 23;
            dgv_NSX.CellClick += dgv_NSX_CellClick;
            // 
            // Col_CusID
            // 
            Col_CusID.DataPropertyName = "Man_ID";
            Col_CusID.HeaderText = "Mã NSX";
            Col_CusID.MinimumWidth = 6;
            Col_CusID.Name = "Col_CusID";
            Col_CusID.ReadOnly = true;
            Col_CusID.Width = 110;
            // 
            // Col_Fullname
            // 
            Col_Fullname.DataPropertyName = "Man_Name";
            Col_Fullname.HeaderText = "Tên NSX";
            Col_Fullname.MinimumWidth = 6;
            Col_Fullname.Name = "Col_Fullname";
            Col_Fullname.ReadOnly = true;
            Col_Fullname.Width = 200;
            // 
            // Col_Address
            // 
            Col_Address.DataPropertyName = "Man_Location";
            Col_Address.HeaderText = "Địa chỉ";
            Col_Address.MinimumWidth = 6;
            Col_Address.Name = "Col_Address";
            Col_Address.ReadOnly = true;
            Col_Address.Width = 200;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_DiaChi);
            panel1.Controls.Add(txt_MaNSX);
            panel1.Controls.Add(txt_TenNSX);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(617, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 148);
            panel1.TabIndex = 27;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DiaChi.Location = new Point(98, 100);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(247, 25);
            txt_DiaChi.TabIndex = 17;
            // 
            // txt_MaNSX
            // 
            txt_MaNSX.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaNSX.Location = new Point(98, 19);
            txt_MaNSX.Name = "txt_MaNSX";
            txt_MaNSX.Size = new Size(247, 25);
            txt_MaNSX.TabIndex = 14;
            // 
            // txt_TenNSX
            // 
            txt_TenNSX.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TenNSX.Location = new Point(98, 61);
            txt_TenNSX.Name = "txt_TenNSX";
            txt_TenNSX.Size = new Size(247, 25);
            txt_TenNSX.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 60);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 8;
            label4.Text = "Tên NSX :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 103);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 18);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 6;
            label2.Text = "Mã NSX :";
            // 
            // btnXoaNSX
            // 
            btnXoaNSX.Dock = DockStyle.Top;
            btnXoaNSX.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaNSX.Location = new Point(3, 119);
            btnXoaNSX.Name = "btnXoaNSX";
            btnXoaNSX.Size = new Size(212, 50);
            btnXoaNSX.TabIndex = 29;
            btnXoaNSX.Text = "Xóa thông tin NSX";
            btnXoaNSX.UseVisualStyleBackColor = true;
            btnXoaNSX.Click += btnXoaNSX_Click;
            // 
            // btn_SuaNSX
            // 
            btn_SuaNSX.Dock = DockStyle.Top;
            btn_SuaNSX.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaNSX.Location = new Point(3, 69);
            btn_SuaNSX.Name = "btn_SuaNSX";
            btn_SuaNSX.Size = new Size(212, 50);
            btn_SuaNSX.TabIndex = 30;
            btn_SuaNSX.Text = "Sửa thông tin NSX";
            btn_SuaNSX.UseVisualStyleBackColor = true;
            btn_SuaNSX.Click += btn_SuaNSX_Click;
            // 
            // btn_ThemNSX
            // 
            btn_ThemNSX.Dock = DockStyle.Top;
            btn_ThemNSX.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemNSX.Location = new Point(3, 19);
            btn_ThemNSX.Name = "btn_ThemNSX";
            btn_ThemNSX.Size = new Size(212, 50);
            btn_ThemNSX.TabIndex = 28;
            btn_ThemNSX.Text = "Thêm thông tin NSX";
            btn_ThemNSX.UseVisualStyleBackColor = true;
            btn_ThemNSX.Click += btn_ThemNSX_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaNSX);
            groupBox1.Controls.Add(btn_SuaNSX);
            groupBox1.Controls.Add(btn_ThemNSX);
            groupBox1.Location = new Point(617, 286);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 172);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control buttons";
            // 
            // Manufacturers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgv_NSX);
            Name = "Manufacturers";
            Text = "Manufacturers";
            Load += Manufacturers_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_NSX).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_NSX;
        private Panel panel1;
        private TextBox txt_DiaChi;
        private TextBox txt_MaNSX;
        private TextBox txt_TenNSX;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnXoaNSX;
        private Button btn_SuaNSX;
        private Button btn_ThemNSX;
        private DataGridViewTextBoxColumn Col_CusID;
        private DataGridViewTextBoxColumn Col_Fullname;
        private DataGridViewTextBoxColumn Col_Address;
        private GroupBox groupBox1;
    }
}