using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoSo_PP
    {
        private string maHoSo, tenHS, ghiChu;
        private int soLuongGhiNhan, soLuongToiDan;

        public string MaHoSo { get => maHoSo; set => maHoSo = value; }
        public string TenHS { get => tenHS; set => tenHS = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int SoLuongGhiNhan { get => soLuongGhiNhan; set => soLuongGhiNhan = value; }
        public int SoLuongToiDan { get => soLuongToiDan; set => soLuongToiDan = value; }
    }
}
