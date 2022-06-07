using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class LopHocBLL
    {
        QL_THPTDataContext dataContext = new QL_THPTDataContext();
        #region instance

        private static LopHocBLL instance;

        public static LopHocBLL Instance
        {
            get
            {
                if (instance == null) instance = new LopHocBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private LopHocBLL()
        {
        }
        #endregion
        public List<LopHoc> layLopHoc(NamHoc nam, Khoi khoi)
        {
            if (nam == null || khoi == null)
                return null;
            return LopHocDAL.Instance.layLopHocTheoNamVaKhoi(nam, khoi);
        }
        public void Swap(List<HocSinh_Diem> list, int i, int j)
        {
            HocSinh_Diem temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
        private void Shuffle(List<HocSinh_Diem> list)
        {
            int count = list.Count;
            Random rand = new Random();
            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Swap(list, i, rand.Next(0, count - 1));
                }
            }
        }
        public void PhanLop(List<HocSinh_Diem> hocSinhChuaPhanLop, List<LopHoc> lopHocs)
        {
            //Tinh diem tb cac mon cua tat ca hoc sinh
            double dtbToan = hocSinhChuaPhanLop.Sum(HS => HS.DiemToan) / hocSinhChuaPhanLop.Count();
            double dtbLy = hocSinhChuaPhanLop.Sum(HS => HS.DiemLy) / hocSinhChuaPhanLop.Count();
            double dtbHoa = hocSinhChuaPhanLop.Sum(HS => HS.DiemHoa) / hocSinhChuaPhanLop.Count();
            double dtbVan = hocSinhChuaPhanLop.Sum(HS => HS.DiemVan) / hocSinhChuaPhanLop.Count();
            double dtbAnh = hocSinhChuaPhanLop.Sum(HS => HS.DiemAnh) / hocSinhChuaPhanLop.Count();
            double siSo = hocSinhChuaPhanLop.Count / lopHocs.Count();
            double tiLeNam = (float)hocSinhChuaPhanLop.Count(HS => HS.GioiTinh == true) / hocSinhChuaPhanLop.Count();
            int soLuongHSBanDau = hocSinhChuaPhanLop.Count();
            //Chuyen lop hoc thanh lop_phanlop
            List<Lop_PhanLop> list = new List<Lop_PhanLop>();
            foreach (LopHoc item in lopHocs)
            {
                Lop_PhanLop lop_PhanLop = new Lop_PhanLop();
                lop_PhanLop.MaLop = item.MaLop;
                list.Add(lop_PhanLop);
            }
            int soLanLap = 0;
            do
            {
                //Tron hoc sinh
                Shuffle(hocSinhChuaPhanLop);
                //Phan lop
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < hocSinhChuaPhanLop.Count; j++)
                    {
                        HocSinh_Diem itemHS = hocSinhChuaPhanLop[j];
                        list[i].Hocsinhs.Add(itemHS);
                        int result = list[i].kiemTraDieuKien(dtbToan, dtbLy, dtbHoa, dtbVan, dtbAnh, tiLeNam, siSo);
                        if (result == 1)
                            list[i].Hocsinhs.Remove(itemHS);
                        else
                        {
                            hocSinhChuaPhanLop.RemoveAt(j);
                            j--;
                            if (result == 0)
                                break;
                        }
                        continue;
                    }
                    continue;
                }
                soLanLap++;
            } while (!(hocSinhChuaPhanLop.Count < soLuongHSBanDau / 10 || soLanLap > soLuongHSBanDau / 10));

            //Rai nhung hoc sinh chua duoc phan vao cac lop
            while(hocSinhChuaPhanLop.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int indexMin = i;
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[indexMin].SiSo > list[j].SiSo)
                            indexMin = j;
                    }

                    if (hocSinhChuaPhanLop.Count != 0)
                    {
                        list[indexMin].Hocsinhs.Add(hocSinhChuaPhanLop[0]);
                        hocSinhChuaPhanLop.RemoveAt(0);
                    }
                }
            }

            //Them hoc sinh xuong csdl
            foreach (Lop_PhanLop phanLop in list)
            {
                foreach (HocSinh_Diem hocSinh in phanLop.Hocsinhs)
                {
                    LopHocDAL.Instance.themHocSinhVaoLop(hocSinh.MaHS, phanLop.MaLop);
                }
            }
        }
    }
}
