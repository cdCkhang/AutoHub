namespace GUI_Class.ChildForm
{
    partial class Statistics
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
            dgv_Trans = new DataGridView();
            Col_CusID = new DataGridViewTextBoxColumn();
            Col_Fullname = new DataGridViewTextBoxColumn();
            Col_Tong = new DataGridViewTextBoxColumn();
            label1 = new Label();
            dgv_Cars = new DataGridView();
            Col_CarID = new DataGridViewTextBoxColumn();
            Col_NameModel = new DataGridViewTextBoxColumn();
            Col_ManID = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txt_MaGD = new TextBox();
            label4 = new Label();
            txt_MaXe = new TextBox();
            label3 = new Label();
            btn_TimKiemGD = new Button();
            btn_TimKiemXe = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txt_TongGD = new TextBox();
            txtbox_soGD = new TextBox();
            txt_Doanhthu = new TextBox();
            label5 = new Label();
            txt_SoKH = new TextBox();
            label6 = new Label();
            txtbox_SoMau = new TextBox();
            label7 = new Label();
            txtbox_TBGD = new TextBox();
            panel1 = new Panel();
            txtbox_DTTB = new TextBox();
            label12 = new Label();
            txtbox_TBXe = new TextBox();
            label11 = new Label();
            txtbox_Nam = new TextBox();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Trans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Cars).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Trans
            // 
            dgv_Trans.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Trans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Trans.Columns.AddRange(new DataGridViewColumn[] { Col_CusID, Col_Fullname, Col_Tong });
            dgv_Trans.Location = new Point(75, 59);
            dgv_Trans.Name = "dgv_Trans";
            dgv_Trans.RowHeadersWidth = 51;
            dgv_Trans.RowTemplate.Height = 25;
            dgv_Trans.Size = new Size(399, 284);
            dgv_Trans.TabIndex = 36;
            // 
            // Col_CusID
            // 
            Col_CusID.DataPropertyName = "MaGD";
            Col_CusID.HeaderText = "Mã GD";
            Col_CusID.MinimumWidth = 6;
            Col_CusID.Name = "Col_CusID";
            Col_CusID.Width = 110;
            // 
            // Col_Fullname
            // 
            Col_Fullname.DataPropertyName = "MaKH";
            Col_Fullname.HeaderText = "Mã KH ";
            Col_Fullname.MinimumWidth = 6;
            Col_Fullname.Name = "Col_Fullname";
            Col_Fullname.Width = 110;
            // 
            // Col_Tong
            // 
            Col_Tong.DataPropertyName = "Price";
            Col_Tong.HeaderText = "Giá trị";
            Col_Tong.MinimumWidth = 6;
            Col_Tong.Name = "Col_Tong";
            Col_Tong.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 19);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 39;
            label1.Text = "Giao dịch đã thực hiện";
            // 
            // dgv_Cars
            // 
            dgv_Cars.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Cars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cars.Columns.AddRange(new DataGridViewColumn[] { Col_CarID, Col_NameModel, Col_ManID });
            dgv_Cars.Location = new Point(507, 59);
            dgv_Cars.Name = "dgv_Cars";
            dgv_Cars.RowHeadersWidth = 51;
            dgv_Cars.RowTemplate.Height = 25;
            dgv_Cars.Size = new Size(532, 284);
            dgv_Cars.TabIndex = 40;
            // 
            // Col_CarID
            // 
            Col_CarID.DataPropertyName = "MaXe";
            Col_CarID.HeaderText = "Mã xe";
            Col_CarID.MinimumWidth = 6;
            Col_CarID.Name = "Col_CarID";
            Col_CarID.Width = 110;
            // 
            // Col_NameModel
            // 
            Col_NameModel.DataPropertyName = "TenXe";
            Col_NameModel.HeaderText = "Tên xe";
            Col_NameModel.MinimumWidth = 6;
            Col_NameModel.Name = "Col_NameModel";
            Col_NameModel.Width = 150;
            // 
            // Col_ManID
            // 
            Col_ManID.DataPropertyName = "MaNSX";
            Col_ManID.HeaderText = "Mã nhà SX";
            Col_ManID.MinimumWidth = 6;
            Col_ManID.Name = "Col_ManID";
            Col_ManID.Width = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(692, 19);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 41;
            label2.Text = "Mẫu xe đã nhập";
            // 
            // txt_MaGD
            // 
            txt_MaGD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaGD.Location = new Point(193, 354);
            txt_MaGD.Name = "txt_MaGD";
            txt_MaGD.Size = new Size(150, 25);
            txt_MaGD.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(93, 357);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 42;
            label4.Text = "Mã giao dịch : ";
            // 
            // txt_MaXe
            // 
            txt_MaXe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaXe.Location = new Point(654, 354);
            txt_MaXe.Name = "txt_MaXe";
            txt_MaXe.Size = new Size(177, 25);
            txt_MaXe.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(597, 357);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 44;
            label3.Text = "Mã xe :";
            // 
            // btn_TimKiemGD
            // 
            btn_TimKiemGD.Location = new Point(352, 349);
            btn_TimKiemGD.Name = "btn_TimKiemGD";
            btn_TimKiemGD.Size = new Size(104, 35);
            btn_TimKiemGD.TabIndex = 46;
            btn_TimKiemGD.Text = "Tìm kiếm";
            btn_TimKiemGD.UseVisualStyleBackColor = true;
            btn_TimKiemGD.Click += btn_TimKiemGD_Click;
            // 
            // btn_TimKiemXe
            // 
            btn_TimKiemXe.Location = new Point(847, 349);
            btn_TimKiemXe.Name = "btn_TimKiemXe";
            btn_TimKiemXe.Size = new Size(104, 35);
            btn_TimKiemXe.TabIndex = 47;
            btn_TimKiemXe.Text = "Tìm kiếm";
            btn_TimKiemXe.UseVisualStyleBackColor = true;
            btn_TimKiemXe.Click += btn_TimKiemXe_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(255, 255, 192);
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(17, 23);
            label10.Name = "label10";
            label10.Size = new Size(128, 17);
            label10.TabIndex = 6;
            label10.Text = "Số GD đã thực hiện :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(347, 23);
            label9.Name = "label9";
            label9.Size = new Size(108, 17);
            label9.TabIndex = 7;
            label9.Text = "Tổng doanh thu :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 255, 192);
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(19, 65);
            label8.Name = "label8";
            label8.Size = new Size(124, 17);
            label8.TabIndex = 8;
            label8.Text = "Tổng giá trị GD [$] :";
            // 
            // txt_TongGD
            // 
            txt_TongGD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TongGD.Location = new Point(151, 62);
            txt_TongGD.Name = "txt_TongGD";
            txt_TongGD.Size = new Size(100, 25);
            txt_TongGD.TabIndex = 13;
            txt_TongGD.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbox_soGD
            // 
            txtbox_soGD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_soGD.Location = new Point(151, 20);
            txtbox_soGD.Name = "txtbox_soGD";
            txtbox_soGD.Size = new Size(100, 25);
            txtbox_soGD.TabIndex = 14;
            txtbox_soGD.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Doanhthu
            // 
            txt_Doanhthu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Doanhthu.Location = new Point(461, 20);
            txt_Doanhthu.Name = "txt_Doanhthu";
            txt_Doanhthu.Size = new Size(100, 25);
            txt_Doanhthu.TabIndex = 17;
            txt_Doanhthu.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(633, 23);
            label5.Name = "label5";
            label5.Size = new Size(133, 17);
            label5.TabIndex = 18;
            label5.Text = "Tổng số khách hàng :";
            // 
            // txt_SoKH
            // 
            txt_SoKH.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SoKH.Location = new Point(772, 20);
            txt_SoKH.Name = "txt_SoKH";
            txt_SoKH.Size = new Size(100, 25);
            txt_SoKH.TabIndex = 19;
            txt_SoKH.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(341, 107);
            label6.Name = "label6";
            label6.Size = new Size(114, 17);
            label6.TabIndex = 20;
            label6.Text = "Số lượng mẫu xe :";
            // 
            // txtbox_SoMau
            // 
            txtbox_SoMau.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_SoMau.Location = new Point(461, 104);
            txtbox_SoMau.Name = "txtbox_SoMau";
            txtbox_SoMau.Size = new Size(100, 25);
            txtbox_SoMau.TabIndex = 21;
            txtbox_SoMau.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 107);
            label7.Name = "label7";
            label7.Size = new Size(125, 17);
            label7.TabIndex = 22;
            label7.Text = "Trung bình mỗi GD :";
            // 
            // txtbox_TBGD
            // 
            txtbox_TBGD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_TBGD.Location = new Point(151, 104);
            txtbox_TBGD.Name = "txtbox_TBGD";
            txtbox_TBGD.Size = new Size(100, 25);
            txtbox_TBGD.TabIndex = 23;
            txtbox_TBGD.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtbox_DTTB);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtbox_TBXe);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtbox_Nam);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtbox_TBGD);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtbox_SoMau);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_SoKH);
            panel1.Controls.Add(txt_Doanhthu);
            panel1.Controls.Add(txtbox_soGD);
            panel1.Controls.Add(txt_TongGD);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(75, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 145);
            panel1.TabIndex = 48;
            // 
            // txtbox_DTTB
            // 
            txtbox_DTTB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_DTTB.Location = new Point(461, 65);
            txtbox_DTTB.Name = "txtbox_DTTB";
            txtbox_DTTB.Size = new Size(100, 25);
            txtbox_DTTB.TabIndex = 31;
            txtbox_DTTB.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(314, 65);
            label12.Name = "label12";
            label12.Size = new Size(141, 17);
            label12.TabIndex = 30;
            label12.Text = "TB Doanh thu mỗi GD :";
            // 
            // txtbox_TBXe
            // 
            txtbox_TBXe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_TBXe.Location = new Point(771, 62);
            txtbox_TBXe.Name = "txtbox_TBXe";
            txtbox_TBXe.Size = new Size(100, 25);
            txtbox_TBXe.TabIndex = 29;
            txtbox_TBXe.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(633, 65);
            label11.Name = "label11";
            label11.Size = new Size(132, 17);
            label11.TabIndex = 28;
            label11.Text = "Trung bình giá trị xe :";
            // 
            // txtbox_Nam
            // 
            txtbox_Nam.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_Nam.Location = new Point(771, 104);
            txtbox_Nam.Name = "txtbox_Nam";
            txtbox_Nam.Size = new Size(100, 25);
            txtbox_Nam.TabIndex = 25;
            txtbox_Nam.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(638, 107);
            label13.Name = "label13";
            label13.Size = new Size(126, 17);
            label13.TabIndex = 24;
            label13.Text = "Năm SX trung bình :";
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel1);
            Controls.Add(btn_TimKiemXe);
            Controls.Add(btn_TimKiemGD);
            Controls.Add(txt_MaXe);
            Controls.Add(label3);
            Controls.Add(txt_MaGD);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dgv_Cars);
            Controls.Add(label1);
            Controls.Add(dgv_Trans);
            Name = "Statistics";
            Text = "Statistics";
            Load += Statistics_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Trans).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Cars).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Trans;
        private Label label1;
        private DataGridView dgv_Cars;
        private Label label2;
        private TextBox txt_MaGD;
        private Label label4;
        private TextBox txt_MaXe;
        private Label label3;
        private Button btn_TimKiemGD;
        private Button btn_TimKiemXe;
        private DataGridViewTextBoxColumn Col_CarID;
        private DataGridViewTextBoxColumn Col_NameModel;
        private DataGridViewTextBoxColumn Col_ManID;
        private DataGridViewTextBoxColumn Col_CusID;
        private DataGridViewTextBoxColumn Col_Fullname;
        private DataGridViewTextBoxColumn Col_Tong;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txt_TongGD;
        private TextBox txtbox_soGD;
        private TextBox txt_Doanhthu;
        private Label label5;
        private TextBox txt_SoKH;
        private Label label6;
        private TextBox txtbox_SoMau;
        private Label label7;
        private TextBox txtbox_TBGD;
        private Panel panel1;
        private TextBox txtbox_TBXe;
        private Label label11;
        private TextBox txtbox_Nam;
        private Label label13;
        private TextBox txtbox_DTTB;
        private Label label12;
    }
}