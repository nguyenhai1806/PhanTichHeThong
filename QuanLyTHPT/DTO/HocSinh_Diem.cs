using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinh_Diem: HOCSINH
    {
        double diemToan, diemLy, diemHoa, diemVan, diemAnh;
        public double DiemToan { get => diemToan; set => diemToan = value; }
        public double DiemLy { get => diemLy; set => diemLy = value; }
        public double DiemHoa { get => diemHoa; set => diemHoa = value; }
        public double DiemVan { get => diemVan; set => diemVan = value; }
        public double DiemAnh { get => diemAnh; set => diemAnh = value; }
    }
}
