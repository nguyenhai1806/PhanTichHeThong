using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QuanLyTHPT
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void btnDangNhap_Click(object sender, EventArgs e){
            string taiKhoan = txtTaiKhoan.Text;
            string password = txtPassword.Text;
            if (!String.IsNullOrWhiteSpace(taiKhoan) && !String.IsNullOrWhiteSpace(password))
            {
                progressBar.Value = 10;
                NhanVien nhanVien = NhanVienBLL.Instance.DangNhap(taiKhoan, password);
                if (nhanVien != null)
                {
                    progressBar.Value = 20;
                    BienToanCuc.Instance.NguoiDung = nhanVien;
                    progressBar.Value = 30;
                    frmNhapHoc nhapHoc = new frmNhapHoc();
                    progressBar.Value = 40;
                    nhapHoc.Show();
                    progressBar.Value = 50;
                    this.Hide();
                }
                else
                    MyMessageBox.ShowError("Tài khoản mật khẩu không đúng");
            }
            else
                MyMessageBox.ShowError("Không được để trống");
        }
    }
}
