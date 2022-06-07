using Aspose.Words;
using Aspose.Words.Tables;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class Export
    {
        public void XuatBienNhanHoSo(HOCSINH hocSinh, NhanVien nhanVien, List<HoSo_PP> hoSo_s)
        {
            var homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            Document phieuBienNhanHS = new Document("Template\\Bieu_Mau_Bien_Nhan_HS.doc");

            //Bước 2: Điền các thông tin cố định
            phieuBienNhanHS.MailMerge.Execute(new[] { "Ngay" }, new[] { DateTime.Now.Day.ToString() });
            phieuBienNhanHS.MailMerge.Execute(new[] { "Thang" }, new[] { DateTime.Now.Month.ToString() });
            phieuBienNhanHS.MailMerge.Execute(new[] { "Nam" }, new[] { DateTime.Now.Year.ToString() });
            phieuBienNhanHS.MailMerge.Execute(new[] { "TenHS" }, new[] { hocSinh.TenHS });
            phieuBienNhanHS.MailMerge.Execute(new[] { "MaHS" }, new[] { hocSinh.MaHS });
            phieuBienNhanHS.MailMerge.Execute(new[] { "NhanVien" }, new[] { nhanVien.TenNV });
            //Bước 3: Điền thông tin lên bảng
            Table bangHoSo = phieuBienNhanHS.GetChild(NodeType.Table, 1, true) as Table;//Lấy bảng thứ 2 trong file mẫu
            int hangHienTai = 1;
            bangHoSo.InsertRows(hangHienTai, hangHienTai, hoSo_s.Count - 1);
            for (int i = 1; i <= hoSo_s.Count; i++)
            {
                bangHoSo.PutValue(hangHienTai, 0, i.ToString());//Cột STT
                bangHoSo.PutValue(hangHienTai, 1, hoSo_s[i - 1].TenHS);//Cột Họ và tên
                bangHoSo.PutValue(hangHienTai, 2, hoSo_s[i - 1].SoLuongGhiNhan.ToString());//Cột quan hệ
                bangHoSo.PutValue(hangHienTai, 3, hoSo_s[i - 1].GhiChu);//Cột Số điện thoại
                hangHienTai++;
            }

            //Bước 4: Lưu và mở file
            string tenfile = "phieuBienNhanHS" + hocSinh.MaHS + ".doc";
            phieuBienNhanHS.SaveAndOpenFile(tenfile);
        }
        public void InGiayXacNhanNhapHoc(HOCSINH hocSinh, NhanVien nhanVien,string khoi, string taiKhoan, string matKhau, string namHoc)
        {
            DateTime homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            Document giayXacNhanNhapHoc = new Document("Template\\BieuMauXacNhanNhapHoc.doc");

            //Bước 2: Điền các thông tin cố định
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "Ngay" }, new[] { DateTime.Now.Day.ToString() });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "Thang" }, new[] { DateTime.Now.Month.ToString() });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "Nam" }, new[] { DateTime.Now.Year.ToString() });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "HoTen" }, new[] { hocSinh.TenHS });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "NgaySinh" }, new[] { String.Format("{0}/{1}/{2}",hocSinh.NgaySinh.Day, hocSinh.NgaySinh.Month, hocSinh.NgaySinh.Year) });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "MaHS" }, new[] { hocSinh.MaHS });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "TenTaiKhoan" }, new[] { taiKhoan });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "CCCD" }, new[] { hocSinh.CCCD });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "GioiTinh" }, new[] { hocSinh.GioiTinh ? "Nam" : "Nữ"});
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "Khoi" }, new[] { khoi });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "MatKhau" }, new[] { matKhau });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "NhanVien" }, new[] { nhanVien.TenNV });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "DiaChi" }, new[] { hocSinh.DiaChi });
            giayXacNhanNhapHoc.MailMerge.Execute(new[] { "NamHoc" }, new[] { namHoc });

            string tenfile = "BieuMauXacNhanNhapHoc_" + hocSinh.MaHS + ".doc";
            giayXacNhanNhapHoc.SaveAndOpenFile(tenfile);
        }
    }
}
