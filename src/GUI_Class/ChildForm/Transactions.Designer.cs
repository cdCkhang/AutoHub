namespace GUI_Class.ChildForm
{
    partial class Transactions
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
            cbb_MaXe = new ComboBox();
            cbb_MaNV = new ComboBox();
            cbb_MaKH = new ComboBox();
            txt_Thue = new TextBox();
            txt_Tong = new TextBox();
            txt_MaGD = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_Trans = new DataGridView();
            Col_CusID = new DataGridViewTextBoxColumn();
            Col_Fullname = new DataGridViewTextBoxColumn();
            Col_SDT = new DataGridViewTextBoxColumn();
            Col_CaID = new DataGridViewTextBoxColumn();
            Col_Taxes = new DataGridViewTextBoxColumn();
            Col_Tong = new DataGridViewTextBoxColumn();
            btn_XoaGD = new Button();
            btn_SuaGD = new Button();
            btn_ThemGD = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Trans).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbb_MaXe);
            panel1.Controls.Add(cbb_MaNV);
            panel1.Controls.Add(cbb_MaKH);
            panel1.Controls.Add(txt_Thue);
            panel1.Controls.Add(txt_Tong);
            panel1.Controls.Add(txt_MaGD);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(87, 382);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 148);
            panel1.TabIndex = 42;
            // 
            // cbb_MaXe
            // 
            cbb_MaXe.FormattingEnabled = true;
            cbb_MaXe.Location = new Point(423, 16);
            cbb_MaXe.Margin = new Padding(3, 2, 3, 2);
            cbb_MaXe.Name = "cbb_MaXe";
            cbb_MaXe.Size = new Size(247, 23);
            cbb_MaXe.TabIndex = 17;
            // 
            // cbb_MaNV
            // 
            cbb_MaNV.FormattingEnabled = true;
            cbb_MaNV.Location = new Point(80, 103);
            cbb_MaNV.Margin = new Padding(3, 2, 3, 2);
            cbb_MaNV.Name = "cbb_MaNV";
            cbb_MaNV.Size = new Size(247, 23);
            cbb_MaNV.TabIndex = 17;
            // 
            // cbb_MaKH
            // 
            cbb_MaKH.FormattingEnabled = true;
            cbb_MaKH.Location = new Point(80, 58);
            cbb_MaKH.Margin = new Padding(3, 2, 3, 2);
            cbb_MaKH.Name = "cbb_MaKH";
            cbb_MaKH.Size = new Size(247, 23);
            cbb_MaKH.TabIndex = 17;
            // 
            // txt_Thue
            // 
            txt_Thue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Thue.Location = new Point(423, 58);
            txt_Thue.Name = "txt_Thue";
            txt_Thue.Size = new Size(247, 25);
            txt_Thue.TabIndex = 16;
            // 
            // txt_Tong
            // 
            txt_Tong.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Tong.Location = new Point(423, 100);
            txt_Tong.Name = "txt_Tong";
            txt_Tong.ReadOnly = true;
            txt_Tong.Size = new Size(247, 25);
            txt_Tong.TabIndex = 15;
            // 
            // txt_MaGD
            // 
            txt_MaGD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaGD.Location = new Point(80, 18);
            txt_MaGD.Name = "txt_MaGD";
            txt_MaGD.Size = new Size(247, 25);
            txt_MaGD.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(344, 101);
            label7.Name = "label7";
            label7.Size = new Size(72, 17);
            label7.TabIndex = 11;
            label7.Text = "Tổng g.trị :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(344, 58);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 10;
            label6.Text = "Thuế [%] :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(344, 16);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 9;
            label5.Text = "Mã xe :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 59);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 8;
            label4.Text = "Mã KH :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 102);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 7;
            label3.Text = "Mã NV :";
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
            label2.Text = "Mã GD :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 38;
            label1.Text = "Thông tin Giao dịch";
            // 
            // dgv_Trans
            // 
            dgv_Trans.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Trans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Trans.Columns.AddRange(new DataGridViewColumn[] { Col_CusID, Col_Fullname, Col_SDT, Col_CaID, Col_Taxes, Col_Tong });
            dgv_Trans.Location = new Point(128, 43);
            dgv_Trans.Name = "dgv_Trans";
            dgv_Trans.ReadOnly = true;
            dgv_Trans.RowHeadersWidth = 51;
            dgv_Trans.RowTemplate.Height = 25;
            dgv_Trans.Size = new Size(793, 307);
            dgv_Trans.TabIndex = 35;
            dgv_Trans.CellClick += dgv_Trans_CellClick;
            // 
            // Col_CusID
            // 
            Col_CusID.DataPropertyName = "Transaction_ID";
            Col_CusID.HeaderText = "Mã GD";
            Col_CusID.MinimumWidth = 6;
            Col_CusID.Name = "Col_CusID";
            Col_CusID.ReadOnly = true;
            Col_CusID.Width = 120;
            // 
            // Col_Fullname
            // 
            Col_Fullname.DataPropertyName = "Customer_ID";
            Col_Fullname.HeaderText = "Mã KH ";
            Col_Fullname.MinimumWidth = 6;
            Col_Fullname.Name = "Col_Fullname";
            Col_Fullname.ReadOnly = true;
            Col_Fullname.Width = 120;
            // 
            // Col_SDT
            // 
            Col_SDT.DataPropertyName = "SalesPerson_ID";
            Col_SDT.HeaderText = "Mã NV ";
            Col_SDT.MinimumWidth = 6;
            Col_SDT.Name = "Col_SDT";
            Col_SDT.ReadOnly = true;
            Col_SDT.Width = 125;
            // 
            // Col_CaID
            // 
            Col_CaID.DataPropertyName = "Car_ID";
            Col_CaID.HeaderText = "Mã xe";
            Col_CaID.MinimumWidth = 6;
            Col_CaID.Name = "Col_CaID";
            Col_CaID.ReadOnly = true;
            Col_CaID.Width = 125;
            // 
            // Col_Taxes
            // 
            Col_Taxes.DataPropertyName = "Taxes_Fees";
            Col_Taxes.HeaderText = "Thuế";
            Col_Taxes.MinimumWidth = 6;
            Col_Taxes.Name = "Col_Taxes";
            Col_Taxes.ReadOnly = true;
            Col_Taxes.Width = 125;
            // 
            // Col_Tong
            // 
            Col_Tong.DataPropertyName = "Price";
            Col_Tong.HeaderText = "Tổng giá trị";
            Col_Tong.MinimumWidth = 6;
            Col_Tong.Name = "Col_Tong";
            Col_Tong.ReadOnly = true;
            Col_Tong.Width = 125;
            // 
            // btn_XoaGD
            // 
            btn_XoaGD.Dock = DockStyle.Top;
            btn_XoaGD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XoaGD.Location = new Point(3, 109);
            btn_XoaGD.Name = "btn_XoaGD";
            btn_XoaGD.Size = new Size(196, 45);
            btn_XoaGD.TabIndex = 37;
            btn_XoaGD.Text = "Xóa thông tin GD";
            btn_XoaGD.UseVisualStyleBackColor = true;
            btn_XoaGD.Click += btn_XoaGD_Click;
            // 
            // btn_SuaGD
            // 
            btn_SuaGD.Dock = DockStyle.Top;
            btn_SuaGD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaGD.Location = new Point(3, 64);
            btn_SuaGD.Name = "btn_SuaGD";
            btn_SuaGD.Size = new Size(196, 45);
            btn_SuaGD.TabIndex = 39;
            btn_SuaGD.Text = "Sửa chi tiết GD ";
            btn_SuaGD.UseVisualStyleBackColor = true;
            btn_SuaGD.Click += btn_SuaGD_Click;
            // 
            // btn_ThemGD
            // 
            btn_ThemGD.Dock = DockStyle.Top;
            btn_ThemGD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemGD.Location = new Point(3, 19);
            btn_ThemGD.Name = "btn_ThemGD";
            btn_ThemGD.Size = new Size(196, 45);
            btn_ThemGD.TabIndex = 36;
            btn_ThemGD.Text = "Tạo mới GD";
            btn_ThemGD.UseVisualStyleBackColor = true;
            btn_ThemGD.Click += btn_ThemGD_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_XoaGD);
            groupBox1.Controls.Add(btn_SuaGD);
            groupBox1.Controls.Add(btn_ThemGD);
            groupBox1.Location = new Point(789, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 157);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control buttons";
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgv_Trans);
            Name = "Transactions";
            Text = "Transactions";
            Load += Transactions_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Trans).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox txt_Thue;
        private TextBox txt_Tong;
        private TextBox txt_MaGD;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_Trans;
        private Button btn_XoaGD;
        private Button btn_SuaGD;
        private Button btn_ThemGD;
        private DataGridViewTextBoxColumn Col_CusID;
        private DataGridViewTextBoxColumn Col_Fullname;
        private DataGridViewTextBoxColumn Col_SDT;
        private DataGridViewTextBoxColumn Col_CaID;
        private DataGridViewTextBoxColumn Col_Taxes;
        private DataGridViewTextBoxColumn Col_Tong;
        private ComboBox cbb_MaXe;
        private ComboBox cbb_MaNV;
        private ComboBox cbb_MaKH;
        private GroupBox groupBox1;
    }
}