using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class NhanVienDAL
    {
        QL_THPTDataContext dataContext = new QL_THPTDataContext();
        #region instance

        private static NhanVienDAL instance;

        public static NhanVienDAL Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private NhanVienDAL()
        {
        }

        #endregion
        public NhanVien DangNhap(string tenTaiKhoan, string matKhau)
        {
            NhanVien nhanVien = null;
            TaiKhoan taiKhoan = null;
            taiKhoan = dataContext.TaiKhoans.Where(tk => tk.TenTaiKhoan == tenTaiKhoan && tk.MatKhau == matKhau).FirstOrDefault();
            if (taiKhoan != null)
            {
                nhanVien = dataContext.NhanViens.Where(nv => nv.MaNV == taiKhoan.MaNV).FirstOrDefault();
            }
            return nhanVien;
        }
    }
}
