namespace GUI_Class.ChildForm
{
    partial class Car_models
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
            dgv_Cars = new DataGridView();
            Col_CarID = new DataGridViewTextBoxColumn();
            Col_NameModel = new DataGridViewTextBoxColumn();
            Col_ManID = new DataGridViewTextBoxColumn();
            Col_year = new DataGridViewTextBoxColumn();
            Col_Color = new DataGridViewTextBoxColumn();
            Col_Price = new DataGridViewTextBoxColumn();
            btn_ThemXe = new Button();
            btn_XoaXe = new Button();
            label1 = new Label();
            btn_SuaXe = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_NamSX = new TextBox();
            txt_TenXe = new TextBox();
            txt_MaXe = new TextBox();
            txt_GiaTien = new TextBox();
            txt_MauSon = new TextBox();
            panel1 = new Panel();
            cbb_nsx = new ComboBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Cars).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Cars
            // 
            dgv_Cars.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Cars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cars.Columns.AddRange(new DataGridViewColumn[] { Col_CarID, Col_NameModel, Col_ManID, Col_year, Col_Color, Col_Price });
            dgv_Cars.Location = new Point(76, 53);
            dgv_Cars.Name = "dgv_Cars";
            dgv_Cars.ReadOnly = true;
            dgv_Cars.RowHeadersWidth = 51;
            dgv_Cars.RowTemplate.Height = 25;
            dgv_Cars.Size = new Size(778, 299);
            dgv_Cars.TabIndex = 0;
            dgv_Cars.CellClick += dgv_Cars_CellClick;
            // 
            // Col_CarID
            // 
            Col_CarID.DataPropertyName = "Car_ID";
            Col_CarID.HeaderText = "Mã xe";
            Col_CarID.MinimumWidth = 6;
            Col_CarID.Name = "Col_CarID";
            Col_CarID.ReadOnly = true;
            Col_CarID.Width = 110;
            // 
            // Col_NameModel
            // 
            Col_NameModel.DataPropertyName = "Model_Name";
            Col_NameModel.HeaderText = "Tên xe";
            Col_NameModel.MinimumWidth = 6;
            Col_NameModel.Name = "Col_NameModel";
            Col_NameModel.ReadOnly = true;
            Col_NameModel.Width = 150;
            // 
            // Col_ManID
            // 
            Col_ManID.DataPropertyName = "Man_ID";
            Col_ManID.HeaderText = "Mã nhà SX";
            Col_ManID.MinimumWidth = 6;
            Col_ManID.Name = "Col_ManID";
            Col_ManID.ReadOnly = true;
            Col_ManID.Width = 110;
            // 
            // Col_year
            // 
            Col_year.DataPropertyName = "Model_Year";
            Col_year.HeaderText = "Năm SX";
            Col_year.MinimumWidth = 6;
            Col_year.Name = "Col_year";
            Col_year.ReadOnly = true;
            Col_year.Width = 125;
            // 
            // Col_Color
            // 
            Col_Color.DataPropertyName = "PaintColor";
            Col_Color.HeaderText = "Màu sơn";
            Col_Color.MinimumWidth = 6;
            Col_Color.Name = "Col_Color";
            Col_Color.ReadOnly = true;
            Col_Color.Width = 125;
            // 
            // Col_Price
            // 
            Col_Price.DataPropertyName = "Price";
            Col_Price.HeaderText = "Giá tiền";
            Col_Price.MinimumWidth = 6;
            Col_Price.Name = "Col_Price";
            Col_Price.ReadOnly = true;
            Col_Price.Width = 104;
            // 
            // btn_ThemXe
            // 
            btn_ThemXe.Dock = DockStyle.Top;
            btn_ThemXe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemXe.Location = new Point(3, 21);
            btn_ThemXe.Name = "btn_ThemXe";
            btn_ThemXe.Size = new Size(200, 45);
            btn_ThemXe.TabIndex = 1;
            btn_ThemXe.Text = "Thêm thông tin xe";
            btn_ThemXe.UseVisualStyleBackColor = true;
            btn_ThemXe.Click += btn_ThemXe_Click;
            // 
            // btn_XoaXe
            // 
            btn_XoaXe.Dock = DockStyle.Top;
            btn_XoaXe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XoaXe.Location = new Point(3, 111);
            btn_XoaXe.Name = "btn_XoaXe";
            btn_XoaXe.Size = new Size(200, 45);
            btn_XoaXe.TabIndex = 2;
            btn_XoaXe.Text = "Xóa thông tin xe";
            btn_XoaXe.UseVisualStyleBackColor = true;
            btn_XoaXe.Click += btn_XoaXe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 25);
            label1.Name = "label1";
            label1.Size = new Size(221, 25);
            label1.TabIndex = 4;
            label1.Text = "Thông tin chi tiết mẫu xe";
            // 
            // btn_SuaXe
            // 
            btn_SuaXe.Dock = DockStyle.Top;
            btn_SuaXe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaXe.Location = new Point(3, 66);
            btn_SuaXe.Name = "btn_SuaXe";
            btn_SuaXe.Size = new Size(200, 45);
            btn_SuaXe.TabIndex = 5;
            btn_SuaXe.Text = "Sửa thông tin xe";
            btn_SuaXe.UseVisualStyleBackColor = true;
            btn_SuaXe.Click += btn_SuaXe_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 17);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 6;
            label2.Text = "Mã xe :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 102);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 7;
            label3.Text = "Mã NSX :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 59);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 8;
            label4.Text = "Tên xe :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(337, 19);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 9;
            label5.Text = "Năm SX :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(337, 61);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 10;
            label6.Text = "Màu sơn :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(337, 104);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 11;
            label7.Text = "Giá tiền :";
            // 
            // txt_NamSX
            // 
            txt_NamSX.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_NamSX.Location = new Point(405, 18);
            txt_NamSX.Name = "txt_NamSX";
            txt_NamSX.Size = new Size(247, 25);
            txt_NamSX.TabIndex = 12;
            // 
            // txt_TenXe
            // 
            txt_TenXe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TenXe.Location = new Point(80, 60);
            txt_TenXe.Name = "txt_TenXe";
            txt_TenXe.Size = new Size(247, 25);
            txt_TenXe.TabIndex = 13;
            // 
            // txt_MaXe
            // 
            txt_MaXe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaXe.Location = new Point(80, 18);
            txt_MaXe.Name = "txt_MaXe";
            txt_MaXe.Size = new Size(247, 25);
            txt_MaXe.TabIndex = 14;
            // 
            // txt_GiaTien
            // 
            txt_GiaTien.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_GiaTien.Location = new Point(405, 103);
            txt_GiaTien.Name = "txt_GiaTien";
            txt_GiaTien.Size = new Size(247, 25);
            txt_GiaTien.TabIndex = 15;
            // 
            // txt_MauSon
            // 
            txt_MauSon.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MauSon.Location = new Point(405, 61);
            txt_MauSon.Name = "txt_MauSon";
            txt_MauSon.Size = new Size(247, 25);
            txt_MauSon.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbb_nsx);
            panel1.Controls.Add(txt_MauSon);
            panel1.Controls.Add(txt_GiaTien);
            panel1.Controls.Add(txt_MaXe);
            panel1.Controls.Add(txt_TenXe);
            panel1.Controls.Add(txt_NamSX);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(76, 366);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 148);
            panel1.TabIndex = 18;
            // 
            // cbb_nsx
            // 
            cbb_nsx.FormattingEnabled = true;
            cbb_nsx.Location = new Point(80, 100);
            cbb_nsx.Margin = new Padding(3, 2, 3, 2);
            cbb_nsx.Name = "cbb_nsx";
            cbb_nsx.Size = new Size(247, 23);
            cbb_nsx.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_XoaXe);
            groupBox1.Controls.Add(btn_SuaXe);
            groupBox1.Controls.Add(btn_ThemXe);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(751, 358);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 158);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control buttons";
            // 
            // Car_models
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgv_Cars);
            Name = "Car_models";
            Text = "Car_models";
            Load += Car_models_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Cars).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Cars;
        private Button btn_ThemXe;
        private Button btn_XoaXe;
        private Label label1;
        private Button btn_SuaXe;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_NamSX;
        private TextBox txt_TenXe;
        private TextBox txt_MaXe;
        private TextBox txt_GiaTien;
        private TextBox txt_MauSon;
        private Panel panel1;
        private DataGridViewTextBoxColumn Col_CarID;
        private DataGridViewTextBoxColumn Col_NameModel;
        private DataGridViewTextBoxColumn Col_ManID;
        private DataGridViewTextBoxColumn Col_year;
        private DataGridViewTextBoxColumn Col_Color;
        private DataGridViewTextBoxColumn Col_Price;
        private ComboBox cbb_nsx;
        private GroupBox groupBox1;
    }
}