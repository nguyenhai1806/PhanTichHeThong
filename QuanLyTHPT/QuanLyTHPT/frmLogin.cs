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
                NhanVien nhanVien = NhanVienBLL.Instance.DangNhap(taiKhoan, password);
                if (nhanVien != null)
                {
                    BienToanCuc.Instance.NguoiDung = nhanVien;
                    frmNhapHoc nhapHoc = new frmNhapHoc();
                    nhapHoc.Show();
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
