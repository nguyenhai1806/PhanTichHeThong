using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhieuBienNhanHoSoDAL
    {
        #region instance

        private static PhieuBienNhanHoSoDAL instance;

        public static PhieuBienNhanHoSoDAL Instance
        {
            get
            {
                if (instance == null) instance = new PhieuBienNhanHoSoDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private PhieuBienNhanHoSoDAL()
        {
        }

        #endregion
        QL_THPTDataContext dataContext = new QL_THPTDataContext();
        public List<PhieuBienNhanH> layTatCa()
        {
            return dataContext.PhieuBienNhanHs.ToList<PhieuBienNhanH>();
        }
        public string TaoMaPhieuBienNhan()
        {
            List<PhieuBienNhanH> phieuBienNhans = layTatCa();
            if (phieuBienNhans.Count == 0)
                return "PBN001";
            else
            {
                List<int> maPhieu = new List<int>();
                foreach (PhieuBienNhanH item in phieuBienNhans)
                {
                    int ma = int.Parse(item.MaPhieu.Substring(3));
                    maPhieu.Add(ma);
                }
                maPhieu.Sort();
                int max = (int)maPhieu.Max();
                max = max + 1;
                int lengthMax = max.ToString().Length;
                string result = "PBN";
                for (int i = 0; i < 3 - lengthMax; i++)
                {
                    result = result + "0";
                }
                result = result + max.ToString();
                return result;
            }
        }
        public bool ThemPhieuBienNhan(HOCSINH hocSinh, NhanVien nhanVien, List<HoSo_PP> listHoSo)
        {
            try
            {
                string maPhieu = TaoMaPhieuBienNhan();
                PhieuBienNhanH phieu = new PhieuBienNhanH();
                phieu.MaPhieu = maPhieu;
                phieu.MaHS = hocSinh.MaHS;
                phieu.MaNV = nhanVien.MaNV;
                phieu.NgayNhan = DateTime.Now;
                dataContext.PhieuBienNhanHs.InsertOnSubmit(phieu);
                dataContext.SubmitChanges();

                foreach (var item in listHoSo)
                {
                    CTPhieuBienNhanH cTPhieuBienNhan = new CTPhieuBienNhanH();
                    cTPhieuBienNhan.MaPhieuBN = phieu.MaPhieu;
                    cTPhieuBienNhan.MaHoSo = item.maHoSo;
                    cTPhieuBienNhan.GhiChu = item.ghiChu;
                    cTPhieuBienNhan.SoLuong = item.soLuongGhiNhan;
                    dataContext.CTPhieuBienNhanHs.InsertOnSubmit(cTPhieuBienNhan);
                }
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
