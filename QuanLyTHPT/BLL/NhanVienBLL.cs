using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class NhanVienBLL
    {
        #region instance

        private static NhanVienBLL instance;

        public static NhanVienBLL Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private NhanVienBLL()
        {
        }

        #endregion
        public NhanVien DangNhap(string taiKhoan, string matKhau)
        {
            return NhanVienDAL.Instance.DangNhap(taiKhoan, matKhau);
        }
    }
}
