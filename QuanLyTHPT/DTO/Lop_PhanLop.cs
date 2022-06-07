using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class Lop_PhanLop
    {
        public static double saiSoDiem = 0.5;
        public static double saiSoGioiTinh = 0.1;
        public static double saiSoSiSo = 1;
        string maLop;
        List<HocSinh_Diem> hocsinhs;
        public Lop_PhanLop() { }
        public Lop_PhanLop(Lop_PhanLop a)
        {
            this.maLop = a.maLop;
            this.hocsinhs = new List<HocSinh_Diem>();
        }
        public int SiSo
        {
            get {
                return Hocsinhs.Count;
            }
        }
        public double DTBToan
        {
            get
            {
                return Hocsinhs.Sum(hs => hs.DiemToan) / SiSo;
            }
        }
        public double DTBLy
        {
            get
            {
                return Hocsinhs.Sum(hs => hs.DiemLy) / SiSo;
            }
        }
        public double DTBHoa
        {
            get
            {
                return Hocsinhs.Sum(hs => hs.DiemHoa) / SiSo;
            }
        }
        public double DTBVan
        {
            get
            {
                return Hocsinhs.Sum(hs => hs.DiemVan) / SiSo;
            }
        }
        public double DTBAnh
        {
            get
            {
                return Hocsinhs.Sum(hs => hs.DiemAnh) / SiSo;
            }
        }
        public string MaLop { get => maLop; set => maLop = value; }
        public double TiLeNamGioi
        {
            get
            {
                return ((double)Hocsinhs.Count(hs => hs.GioiTinh == true)) / SiSo;
            }
        }

        public List<HocSinh_Diem> Hocsinhs { get => hocsinhs; set => hocsinhs = value; }

        public int kiemTraDieuKien(double diemToan, double diemLy, double diemHoa, double diemVan, double diemAnh, double tiLeNam, double siso)
        {
            if (SiSo < siso - saiSoSiSo)
                return -1;
            else if (siso + saiSoSiSo < SiSo)
                return 1;

            if (DTBToan < diemToan - saiSoDiem)
                return -1;
            else if (diemToan + saiSoDiem < DTBToan)
                return 1;

            if (DTBLy < diemLy - saiSoDiem)
                return -1;
            else if (diemLy + saiSoDiem < DTBLy)
                return 1;

            if (DTBHoa < diemHoa - saiSoDiem)
                return -1;
            else if (diemHoa - saiSoDiem < DTBHoa)
                return 1;

            if (DTBVan < diemVan - saiSoDiem)
                return -1;
            else if (diemVan + saiSoDiem < DTBVan)
                return 1;

            if (DTBAnh < diemAnh - saiSoDiem)
                return -1;
            else if (diemAnh + saiSoDiem < DTBAnh)
                return 1;

            if (TiLeNamGioi < tiLeNam - saiSoGioiTinh)
                return -1;
            else if (tiLeNam + saiSoGioiTinh < TiLeNamGioi)
                return 1;
            return 0;
        }
    }
}
