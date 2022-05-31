using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace QuanLyTHPT
{
    public class BienToanCuc
    {
        #region instance

        private static BienToanCuc instance;

        public static BienToanCuc Instance
        {
            get
            {
                if (instance == null) instance = new BienToanCuc();
                return instance;
            }
            private set { instance = value; }
        }

        private BienToanCuc()
        {
        }

        #endregion

        private NhanVien nguoiDung;
        public  NhanVien NguoiDung { get => nguoiDung; set => nguoiDung = value; }
    }
}
