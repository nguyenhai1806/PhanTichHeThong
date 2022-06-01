using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class GiayXacNhanNhapHocDAL
    {
        #region instance

        private static GiayXacNhanNhapHocDAL instance;

        public static GiayXacNhanNhapHocDAL Instance
        {
            get
            {
                if (instance == null) instance = new GiayXacNhanNhapHocDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private GiayXacNhanNhapHocDAL()
        {
        }

        #endregion
        private QL_THPTDataContext dataContext = new QL_THPTDataContext();
        public bool LuuGiayXacNhan(HOCSINH hocSinh,NhanVien nhanVien ) 
        {
            try
            {
                GiayXacNhanNhapHoc giayXacNhan = new GiayXacNhanNhapHoc();
                giayXacNhan.MaHS = hocSinh.MaHS;
                giayXacNhan.MaNV = nhanVien.MaNV;
                giayXacNhan.NgayLap = DateTime.Now;
                dataContext.GiayXacNhanNhapHocs.InsertOnSubmit(giayXacNhan);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
