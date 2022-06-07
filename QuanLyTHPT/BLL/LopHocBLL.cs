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
        public bool kiemTraDieuKien(List<Lop_PhanLop> list)
        {
            foreach (Lop_PhanLop item1 in list)
            {
                foreach (Lop_PhanLop item2 in list)
                {
                    if (item1 == item2)
                        continue;
                    else
                    {
                        if (Math.Abs(item1.DTBToan - item2.DTBToan) > Lop_PhanLop.saiSoDiem + 1.2)
                            return false;
                        if (Math.Abs(item1.DTBLy - item2.DTBLy) > Lop_PhanLop.saiSoDiem + 1.2)
                            return false;
                        if (Math.Abs(item1.DTBHoa - item2.DTBHoa) > Lop_PhanLop.saiSoDiem + 1.2)
                            return false;
                        if (Math.Abs(item1.DTBVan - item2.DTBVan) > Lop_PhanLop.saiSoDiem + 1.2)
                            return false;
                        if (Math.Abs(item1.DTBAnh - item2.DTBAnh) > Lop_PhanLop.saiSoDiem + 1.2)
                            return false;

                        if (Math.Abs(item1.SiSo - item2.SiSo) > Lop_PhanLop.saiSoSiSo + 2)
                            return false;
                    }
                }
            }
            return true;
        }
        public List<HocSinh_Diem> CopyListHocSinhChuaPhanLop(List<HocSinh_Diem> hocSinhChuaPhanLop)
        {
            List<HocSinh_Diem> result = new List<HocSinh_Diem>();
            foreach (HocSinh_Diem item in hocSinhChuaPhanLop)
            {
                HocSinh_Diem temp = item;
                result.Add(temp);
            }
            return result;
        }
        public List<DTO.Lop_PhanLop> CopyListLopPhanLop(List<Lop_PhanLop> lop_PhanLops)
        {
            List<Lop_PhanLop> result = new List<Lop_PhanLop>();
            foreach (Lop_PhanLop item in lop_PhanLops)
            {
                Lop_PhanLop temp = new Lop_PhanLop(item);
                result.Add(temp);
            }
            return result;
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
            List<Lop_PhanLop> listClone;
            List<HocSinh_Diem> hocSinhChuaPhanLopClone;
            do
            {
                listClone = CopyListLopPhanLop(list);
                hocSinhChuaPhanLopClone = CopyListHocSinhChuaPhanLop(hocSinhChuaPhanLop);
                int soLanLap = 0;
                do
                {
                    //Tron hoc sinh
                    Shuffle(hocSinhChuaPhanLopClone);
                    //Phan lop
                    for (int i = 0; i < listClone.Count; i++)
                    {
                        for (int j = 0; j < hocSinhChuaPhanLopClone.Count; j++)
                        {
                            HocSinh_Diem itemHS = hocSinhChuaPhanLopClone[j];
                            listClone[i].Hocsinhs.Add(itemHS);
                            int result = listClone[i].kiemTraDieuKien(dtbToan, dtbLy, dtbHoa, dtbVan, dtbAnh, tiLeNam, siSo);
                            if (result == 1)
                                listClone[i].Hocsinhs.Remove(itemHS);
                            else
                            {
                                hocSinhChuaPhanLopClone.RemoveAt(j);
                                j--;
                                if (result == 0)
                                    break;
                            }
                            continue;
                        }
                        continue;
                    }
                    soLanLap++;
                } while (!(hocSinhChuaPhanLopClone.Count < soLuongHSBanDau / 10 || soLanLap > soLuongHSBanDau / 10));

                //Rai nhung hoc sinh chua duoc phan vao cac lop
                while (hocSinhChuaPhanLopClone.Count != 0)
                {
                    for (int i = 0; i < listClone.Count; i++)
                    {
                        int indexMin = i;
                        for (int j = 0; j < listClone.Count; j++)
                        {
                            if (listClone[indexMin].SiSo > listClone[j].SiSo)
                                indexMin = j;
                        }

                        if (hocSinhChuaPhanLopClone.Count != 0)
                        {
                            listClone[indexMin].Hocsinhs.Add(hocSinhChuaPhanLopClone[0]);
                            hocSinhChuaPhanLopClone.RemoveAt(0);
                        }
                    }
                }
            } while (!kiemTraDieuKien(listClone));
            

            //Them hoc sinh xuong csdl
            foreach (Lop_PhanLop phanLop in listClone)
            {
                foreach (HocSinh_Diem hocSinh in phanLop.Hocsinhs)
                {
                    LopHocDAL.Instance.themHocSinhVaoLop(hocSinh.MaHS, phanLop.MaLop);
                }
            }
        }
    }
}
