using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class LopHocDAL
    {
        QL_THPTDataContext dataContext = new QL_THPTDataContext();
        #region instance

        private static LopHocDAL instance;
        public static LopHocDAL Instance
        {
            get
            {
                if (instance == null) instance = new LopHocDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private LopHocDAL()
        {
        }

        #endregion
        public List<LopHoc> layLopHocTheoNamVaKhoi(NamHoc namHoc, Khoi khoi)
        {
            return dataContext.LopHocs.Where(l => l.Khoi == khoi.MaKhoi && l.NamHoc == namHoc.MaNamHoc).ToList();
        }
        public bool themHocSinhVaoLop(string maHS, string maLop)
        {
            try
            {
                HocSinh_LopHoc hocSinh_LopHoc = new HocSinh_LopHoc();
                hocSinh_LopHoc.MaHS = maHS;
                hocSinh_LopHoc.MaLop = maLop;

                dataContext.HocSinh_LopHocs.InsertOnSubmit(hocSinh_LopHoc);
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
