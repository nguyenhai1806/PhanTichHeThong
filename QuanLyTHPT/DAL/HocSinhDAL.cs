using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HocSinhDAL
    {
        #region instance

        private static HocSinhDAL instance;

        public static HocSinhDAL Instance
        {
            get
            {
                if (instance == null) instance = new HocSinhDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private HocSinhDAL()
        {
        }

        #endregion
        QL_THPTDataContext dataContext = new QL_THPTDataContext();
        public List<HOCSINH> layTatCaHocSinh()
        {
            return dataContext.HOCSINHs.ToList<HOCSINH>();
        }
        public bool ThemHocSinh(HOCSINH hocSinh)
        {
            try
            {
                dataContext.HOCSINHs.InsertOnSubmit(hocSinh);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<HocSinh_Diem> layHocSinhChuaPhanLop()
        {
            return (from hs in dataContext.HOCSINHs
                    join ts in dataContext.DSTrungTuyens
                    on hs.CCCD equals ts.CCCD
                    where !(from hslh in dataContext.HocSinh_LopHocs select hslh.MaHS).Contains(hs.MaHS)
                    select new HocSinh_Diem
                    {
                        MaHS = hs.MaHS,
                        TenHS = hs.TenHS,
                        CCCD = hs.CCCD,
                        DiaChi = hs.DiaChi,
                        GioiTinh = hs.GioiTinh,
                        NgaySinh = hs.NgaySinh,
                        DiemToan = ts.DiemToan,
                        DiemLy = ts.DiemLy,
                        DiemHoa = ts.DiemHoa,
                        DiemVan = ts.DiemVan,
                        DiemAnh = ts.DiemAnh,
                    }).ToList();
        }
    }
}
