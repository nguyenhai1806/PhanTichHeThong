
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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.groupBoxKiemTra.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxThongTinHS.SuspendLayout();
            this.groupBienNhanHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(497, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHẬP HỌC THCS";
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
            this.groupBoxKiemTra.Size = new System.Drawing.Size(364, 558);
            this.groupBoxKiemTra.TabIndex = 3;
            this.groupBoxKiemTra.TabStop = false;
            this.groupBoxKiemTra.Text = "Kiểm tra thông tin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNhanVien);
            this.panel2.Location = new System.Drawing.Point(12, 667);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 31);
            this.panel2.TabIndex = 5;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(7, 7);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(252, 18);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Chào mừng Nguyễn Duy Hải - NV003";
            // 
            // groupBoxThongTinHS
            // 
            this.groupBoxThongTinHS.Controls.Add(this.txtMaHS);
            this.groupBoxThongTinHS.Controls.Add(this.label8);
            this.groupBoxThongTinHS.Controls.Add(this.txtSDT);
            this.groupBoxThongTinHS.Controls.Add(this.label9);
            this.groupBoxThongTinHS.Controls.Add(this.txtDiaChi);
            this.groupBoxThongTinHS.Controls.Add(this.label10);
            this.groupBoxThongTinHS.Controls.Add(this.label11);
            this.groupBoxThongTinHS.Controls.Add(this.txtCCCD);
            this.groupBoxThongTinHS.Controls.Add(this.txtTenHS);
            this.groupBoxThongTinHS.Controls.Add(this.label12);
            this.groupBoxThongTinHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTinHS.Location = new System.Drawing.Point(389, 103);
            this.groupBoxThongTinHS.Name = "groupBoxThongTinHS";
            this.groupBoxThongTinHS.Size = new System.Drawing.Size(819, 216);
            this.groupBoxThongTinHS.TabIndex = 7;
            this.groupBoxThongTinHS.TabStop = false;
            this.groupBoxThongTinHS.Text = "Thông tin học sinh";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHS.Location = new System.Drawing.Point(161, 53);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.ReadOnly = true;
            this.txtMaHS.Size = new System.Drawing.Size(258, 27);
            this.txtMaHS.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã học sinh";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(547, 57);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(266, 27);
            this.txtSDT.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(494, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "SDT";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(547, 104);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(266, 27);
            this.txtDiaChi.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(473, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Địa chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "CCCD";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(161, 146);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(258, 27);
            this.txtCCCD.TabIndex = 3;
            // 
            // txtTenHS
            // 
            this.txtTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHS.Location = new System.Drawing.Point(161, 99);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(258, 27);
            this.txtTenHS.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tên học sinh";
            // 
            // groupBienNhanHS
            // 
            this.groupBienNhanHS.Controls.Add(this.dataGridView);
            this.groupBienNhanHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBienNhanHS.Location = new System.Drawing.Point(383, 339);
            this.groupBienNhanHS.Name = "groupBienNhanHS";
            this.groupBienNhanHS.Size = new System.Drawing.Size(825, 245);
            this.groupBienNhanHS.TabIndex = 8;
            this.groupBienNhanHS.TabStop = false;
            this.groupBienNhanHS.Text = "Biên nhận hồ sơ";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 26);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(806, 213);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            // 
            // panelIN
            // 
            this.panelIN.Controls.Add(this.button1);
            this.panelIN.Controls.Add(this.btnInPhieuBienNhan);
            this.panelIN.Controls.Add(this.btnInGiayXacNhan);
            this.panelIN.Location = new System.Drawing.Point(389, 590);
            this.panelIN.Name = "panelIN";
            this.panelIN.Size = new System.Drawing.Size(812, 71);
            this.panelIN.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(24, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnInPhieuBienNhan
            // 
            this.btnInPhieuBienNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieuBienNhan.Image")));
            this.btnInPhieuBienNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInPhieuBienNhan.Location = new System.Drawing.Point(290, 16);
            this.btnInPhieuBienNhan.Name = "btnInPhieuBienNhan";
            this.btnInPhieuBienNhan.Size = new System.Drawing.Size(250, 52);
            this.btnInPhieuBienNhan.TabIndex = 1;
            this.btnInPhieuBienNhan.Text = "In phiếu biên nhận hồ sơ";
            this.btnInPhieuBienNhan.UseVisualStyleBackColor = true;
            // 
            // btnInGiayXacNhan
            // 
            this.btnInGiayXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnInGiayXacNhan.Image")));
            this.btnInGiayXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInGiayXacNhan.Location = new System.Drawing.Point(559, 16);
            this.btnInGiayXacNhan.Name = "btnInGiayXacNhan";
            this.btnInGiayXacNhan.Size = new System.Drawing.Size(250, 52);
            this.btnInGiayXacNhan.TabIndex = 0;
            this.btnInGiayXacNhan.Text = "In giấy xác nhận nhập học";
            this.btnInGiayXacNhan.UseVisualStyleBackColor = true;
            // 
            // frmNhapHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 710);
            this.Controls.Add(this.panelIN);
            this.Controls.Add(this.groupBienNhanHS);
            this.Controls.Add(this.groupBoxThongTinHS);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBoxKiemTra);
            this.Controls.Add(this.label1);
            this.Name = "frmNhapHoc";
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
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label10;
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
    }
}

