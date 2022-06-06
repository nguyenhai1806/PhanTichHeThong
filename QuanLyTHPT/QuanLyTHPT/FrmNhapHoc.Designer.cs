
namespace QuanLyTHPT
{
    partial class frmNhapHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCCCDFind = new System.Windows.Forms.TextBox();
            this.btnTimTrongDS = new System.Windows.Forms.Button();
            this.groupBoxKiemTra = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.groupBoxThongTinHS = new System.Windows.Forms.GroupBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBienNhanHS = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelIN = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInPhieuBienNhan = new System.Windows.Forms.Button();
            this.btnInGiayXacNhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dptNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTinh = new System.Windows.Forms.ComboBox();
            this.cbbQuan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbPhuong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDuong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxKiemTra.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxThongTinHS.SuspendLayout();
            this.groupBienNhanHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelIN.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(788, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHẬP HỌC THCS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CCCD";
            // 
            // txtCCCDFind
            // 
            this.txtCCCDFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCDFind.Location = new System.Drawing.Point(91, 55);
            this.txtCCCDFind.Name = "txtCCCDFind";
            this.txtCCCDFind.Size = new System.Drawing.Size(258, 27);
            this.txtCCCDFind.TabIndex = 1;
            this.txtCCCDFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCCDFind_KeyPress);
            this.txtCCCDFind.Leave += new System.EventHandler(this.txtCCCDFind_Leave);
            // 
            // btnTimTrongDS
            // 
            this.btnTimTrongDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTrongDS.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTrongDS.Image")));
            this.btnTimTrongDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimTrongDS.Location = new System.Drawing.Point(91, 99);
            this.btnTimTrongDS.Name = "btnTimTrongDS";
            this.btnTimTrongDS.Size = new System.Drawing.Size(258, 37);
            this.btnTimTrongDS.TabIndex = 2;
            this.btnTimTrongDS.Text = "Tìm trong DS trúng tuyển";
            this.btnTimTrongDS.UseVisualStyleBackColor = true;
            this.btnTimTrongDS.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxKiemTra
            // 
            this.groupBoxKiemTra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxKiemTra.Controls.Add(this.btnTimTrongDS);
            this.groupBoxKiemTra.Controls.Add(this.label2);
            this.groupBoxKiemTra.Controls.Add(this.txtCCCDFind);
            this.groupBoxKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKiemTra.ForeColor = System.Drawing.Color.Black;
            this.groupBoxKiemTra.Location = new System.Drawing.Point(12, 103);
            this.groupBoxKiemTra.Name = "groupBoxKiemTra";
            this.groupBoxKiemTra.Size = new System.Drawing.Size(364, 681);
            this.groupBoxKiemTra.TabIndex = 3;
            this.groupBoxKiemTra.TabStop = false;
            this.groupBoxKiemTra.Text = "Kiểm tra thông tin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblNhanVien);
            this.panel2.Location = new System.Drawing.Point(12, 790);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1787, 31);
            this.panel2.TabIndex = 5;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(131)))), ((int)(((byte)(125)))));
            this.lblNhanVien.Location = new System.Drawing.Point(7, 7);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(252, 18);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Chào mừng Nguyễn Duy Hải - NV003";
            // 
            // groupBoxThongTinHS
            // 
            this.groupBoxThongTinHS.Controls.Add(this.panel1);
            this.groupBoxThongTinHS.Controls.Add(this.txtDuong);
            this.groupBoxThongTinHS.Controls.Add(this.label10);
            this.groupBoxThongTinHS.Controls.Add(this.label7);
            this.groupBoxThongTinHS.Controls.Add(this.cbbPhuong);
            this.groupBoxThongTinHS.Controls.Add(this.label6);
            this.groupBoxThongTinHS.Controls.Add(this.cbbQuan);
            this.groupBoxThongTinHS.Controls.Add(this.label5);
            this.groupBoxThongTinHS.Controls.Add(this.cbbTinh);
            this.groupBoxThongTinHS.Controls.Add(this.label4);
            this.groupBoxThongTinHS.Controls.Add(this.dptNgaySinh);
            this.groupBoxThongTinHS.Controls.Add(this.label3);
            this.groupBoxThongTinHS.Controls.Add(this.txtMaHS);
            this.groupBoxThongTinHS.Controls.Add(this.label8);
            this.groupBoxThongTinHS.Controls.Add(this.txtSDT);
            this.groupBoxThongTinHS.Controls.Add(this.label9);
            this.groupBoxThongTinHS.Controls.Add(this.label11);
            this.groupBoxThongTinHS.Controls.Add(this.txtCCCD);
            this.groupBoxThongTinHS.Controls.Add(this.txtTenHS);
            this.groupBoxThongTinHS.Controls.Add(this.label12);
            this.groupBoxThongTinHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTinHS.Location = new System.Drawing.Point(389, 103);
            this.groupBoxThongTinHS.Name = "groupBoxThongTinHS";
            this.groupBoxThongTinHS.Size = new System.Drawing.Size(1410, 279);
            this.groupBoxThongTinHS.TabIndex = 7;
            this.groupBoxThongTinHS.TabStop = false;
            this.groupBoxThongTinHS.Text = "Thông tin học sinh";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHS.Location = new System.Drawing.Point(153, 55);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.ReadOnly = true;
            this.txtMaHS.Size = new System.Drawing.Size(232, 27);
            this.txtMaHS.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã HS";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(153, 103);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(232, 27);
            this.txtSDT.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "SDT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(963, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "CCCD";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(1111, 60);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.ReadOnly = true;
            this.txtCCCD.Size = new System.Drawing.Size(285, 27);
            this.txtCCCD.TabIndex = 3;
            // 
            // txtTenHS
            // 
            this.txtTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHS.Location = new System.Drawing.Point(566, 55);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.ReadOnly = true;
            this.txtTenHS.Size = new System.Drawing.Size(341, 27);
            this.txtTenHS.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(413, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tên HS";
            // 
            // groupBienNhanHS
            // 
            this.groupBienNhanHS.Controls.Add(this.dataGridView);
            this.groupBienNhanHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBienNhanHS.Location = new System.Drawing.Point(389, 388);
            this.groupBienNhanHS.Name = "groupBienNhanHS";
            this.groupBienNhanHS.Size = new System.Drawing.Size(1410, 321);
            this.groupBienNhanHS.TabIndex = 8;
            this.groupBienNhanHS.TabStop = false;
            this.groupBienNhanHS.Text = "Biên nhận hồ sơ";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 23);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1404, 295);
            this.dataGridView.TabIndex = 12;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            // 
            // panelIN
            // 
            this.panelIN.Controls.Add(this.button1);
            this.panelIN.Controls.Add(this.btnInPhieuBienNhan);
            this.panelIN.Controls.Add(this.btnInGiayXacNhan);
            this.panelIN.Location = new System.Drawing.Point(382, 715);
            this.panelIN.Name = "panelIN";
            this.panelIN.Size = new System.Drawing.Size(1414, 69);
            this.panelIN.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(442, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnInPhieuBienNhan
            // 
            this.btnInPhieuBienNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieuBienNhan.Image")));
            this.btnInPhieuBienNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInPhieuBienNhan.Location = new System.Drawing.Point(768, 17);
            this.btnInPhieuBienNhan.Name = "btnInPhieuBienNhan";
            this.btnInPhieuBienNhan.Size = new System.Drawing.Size(310, 52);
            this.btnInPhieuBienNhan.TabIndex = 14;
            this.btnInPhieuBienNhan.Text = "In phiếu biên nhận hồ sơ";
            this.btnInPhieuBienNhan.UseVisualStyleBackColor = true;
            this.btnInPhieuBienNhan.Click += new System.EventHandler(this.btnInPhieuBienNhan_Click);
            // 
            // btnInGiayXacNhan
            // 
            this.btnInGiayXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnInGiayXacNhan.Image")));
            this.btnInGiayXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInGiayXacNhan.Location = new System.Drawing.Point(1102, 17);
            this.btnInGiayXacNhan.Name = "btnInGiayXacNhan";
            this.btnInGiayXacNhan.Size = new System.Drawing.Size(309, 52);
            this.btnInGiayXacNhan.TabIndex = 15;
            this.btnInGiayXacNhan.Text = "     In giấy xác nhận nhập học";
            this.btnInGiayXacNhan.UseVisualStyleBackColor = true;
            this.btnInGiayXacNhan.Click += new System.EventHandler(this.btnInGiayXacNhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ngày sinh";
            // 
            // dptNgaySinh
            // 
            this.dptNgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dptNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptNgaySinh.Location = new System.Drawing.Point(566, 103);
            this.dptNgaySinh.Name = "dptNgaySinh";
            this.dptNgaySinh.Size = new System.Drawing.Size(341, 27);
            this.dptNgaySinh.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tỉnh / TP";
            // 
            // cbbTinh
            // 
            this.cbbTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinh.FormattingEnabled = true;
            this.cbbTinh.Location = new System.Drawing.Point(153, 145);
            this.cbbTinh.Name = "cbbTinh";
            this.cbbTinh.Size = new System.Drawing.Size(232, 28);
            this.cbbTinh.TabIndex = 8;
            this.cbbTinh.SelectedIndexChanged += new System.EventHandler(this.cbbTinh_SelectedIndexChanged);
            // 
            // cbbQuan
            // 
            this.cbbQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuan.FormattingEnabled = true;
            this.cbbQuan.Location = new System.Drawing.Point(566, 145);
            this.cbbQuan.Name = "cbbQuan";
            this.cbbQuan.Size = new System.Drawing.Size(341, 28);
            this.cbbQuan.TabIndex = 9;
            this.cbbQuan.SelectedIndexChanged += new System.EventHandler(this.cbbQuan_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Quận / Huyện";
            // 
            // cbbPhuong
            // 
            this.cbbPhuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhuong.FormattingEnabled = true;
            this.cbbPhuong.Location = new System.Drawing.Point(1111, 145);
            this.cbbPhuong.Name = "cbbPhuong";
            this.cbbPhuong.Size = new System.Drawing.Size(285, 28);
            this.cbbPhuong.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(963, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Phường / xã";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(963, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Giới tính";
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(3, 8);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(65, 24);
            this.rdbNam.TabIndex = 6;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rdbNu.Location = new System.Drawing.Point(158, 8);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(51, 24);
            this.rdbNu.TabIndex = 7;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Đường";
            // 
            // txtDuong
            // 
            this.txtDuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtDuong.Location = new System.Drawing.Point(153, 197);
            this.txtDuong.Name = "txtDuong";
            this.txtDuong.Size = new System.Drawing.Size(1243, 27);
            this.txtDuong.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbNam);
            this.panel1.Controls.Add(this.rdbNu);
            this.panel1.Location = new System.Drawing.Point(1111, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 42);
            this.panel1.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Mã hồ sơ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Tên hồ sơ";
            this.Column2.MinimumWidth = 300;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Số lượng tối đa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Số lượng ghi nhận";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.MinimumWidth = 300;
            this.Column5.Name = "Column5";
            this.Column5.Width = 320;
            // 
            // frmNhapHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1811, 824);
            this.Controls.Add(this.panelIN);
            this.Controls.Add(this.groupBienNhanHS);
            this.Controls.Add(this.groupBoxThongTinHS);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBoxKiemTra);
            this.Controls.Add(this.label1);
            this.Name = "frmNhapHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập học THCS";
            this.groupBoxKiemTra.ResumeLayout(false);
            this.groupBoxKiemTra.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxThongTinHS.ResumeLayout(false);
            this.groupBoxThongTinHS.PerformLayout();
            this.groupBienNhanHS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelIN.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCCCDFind;
        private System.Windows.Forms.Button btnTimTrongDS;
        private System.Windows.Forms.GroupBox groupBoxKiemTra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.GroupBox groupBoxThongTinHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBienNhanHS;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelIN;
        private System.Windows.Forms.Button btnInPhieuBienNhan;
        private System.Windows.Forms.Button btnInGiayXacNhan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbPhuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbQuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dptNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

