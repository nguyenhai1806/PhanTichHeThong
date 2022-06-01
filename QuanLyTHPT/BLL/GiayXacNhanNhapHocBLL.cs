using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class GiayXacNhanNhapHocBLL
    {
        #region instance

        private static GiayXacNhanNhapHocBLL instance;

        public static GiayXacNhanNhapHocBLL Instance
        {
            get
            {
                if (instance == null) instance = new GiayXacNhanNhapHocBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private GiayXacNhanNhapHocBLL()
        {
        }

        #endregion
        public bool LuuGiayXacNhan(HOCSINH hocSinh, NhanVien nhanVien)
        {
            return GiayXacNhanNhapHocDAL.Instance.LuuGiayXacNhan(hocSinh, nhanVien);
        }
    }
    
}
