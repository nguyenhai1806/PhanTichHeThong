using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class PhieuBienNhanHoSoBLL
    {
        #region instance

        private static PhieuBienNhanHoSoBLL instance;

        public static PhieuBienNhanHoSoBLL Instance
        {
            get
            {
                if (instance == null) instance = new PhieuBienNhanHoSoBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private PhieuBienNhanHoSoBLL()
        {
        }

        #endregion
        public bool ThemPhieuBienNhan(HOCSINH hocSinh, NhanVien nhanVien,List<HoSo_PP> listHoSo)
        {
            return PhieuBienNhanHoSoDAL.Instance.ThemPhieuBienNhan(hocSinh, nhanVien, listHoSo);
        }
    }
}
