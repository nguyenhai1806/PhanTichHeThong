using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class HocSinhBLL
    {
        #region instance

        private static HocSinhBLL instance;

        public static HocSinhBLL Instance
        {
            get
            {
                if (instance == null) instance = new HocSinhBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private HocSinhBLL()
        {
        }
        #endregion
        public List<HOCSINH> layTatCaHocSinh()
        {
            return HocSinhDAL.Instance.layTatCaHocSinh();
        }
        public bool HocSinhDaNhapHoc(string cccd)
        {
            List<HOCSINH> hocSinhs = layTatCaHocSinh();
            foreach (HOCSINH item in hocSinhs)
            {
                if (item.CCCD == cccd)
                    return true;
            }
            return false;
        }
        public string TaoMaHocSinh()
        {
            List<HOCSINH> hocSinhs = layTatCaHocSinh();
            if (hocSinhs.Count == 0)
                return "HS001";
            else
            {
                List<int> maHS = new List<int>();
                foreach (HOCSINH item in hocSinhs)
                {
                    int ma = int.Parse(item.MaHS.Substring(2));
                    maHS.Add(ma);
                }
                maHS.Sort();
                int max = (int) maHS.Max();
                max = max + 1;
                int lengthMax = max.ToString().Length;
                string result = "HS";
                for (int i = 0; i < 3 - lengthMax; i++)
                {
                    result = result + "0";
                }
                result = result + max.ToString();
                return result;
            }
        }
        public HOCSINH ThiSinhToHocSinh(DSTrungTuyen dSTrungTuyen)
        {
            HOCSINH hocSinh = new HOCSINH();
            hocSinh.MaHS = TaoMaHocSinh();
            hocSinh.TenHS = dSTrungTuyen.TenTS;
            hocSinh.CCCD = dSTrungTuyen.CCCD;
            hocSinh.DiaChi = dSTrungTuyen.DiaChi;
            hocSinh.NgaySinh = dSTrungTuyen.NgaySinh;
            hocSinh.GioiTinh = dSTrungTuyen.GioiTinh;
            hocSinh.SoDienThoai = dSTrungTuyen.SoDienThoai;
            return hocSinh;
        }
        public bool ThemHocSinh(HOCSINH hocSinh)
        {
            return HocSinhDAL.Instance.ThemHocSinh(hocSinh);
        }
    }
}
