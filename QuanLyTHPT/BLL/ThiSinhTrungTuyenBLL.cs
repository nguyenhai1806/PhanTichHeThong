using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThiSinhTrungTuyenBLL
    {
        #region instance

        private static ThiSinhTrungTuyenBLL instance;

        public static ThiSinhTrungTuyenBLL Instance
        {
            get
            {
                if (instance == null) instance = new ThiSinhTrungTuyenBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private ThiSinhTrungTuyenBLL()
        {
        }
        #endregion

        public DSTrungTuyen layThiSinhTheoCCCD(string cccd)
        {
            return ThiSinhTrungTuyenDAL.Instance.layThiSinhTheoCCCD(cccd);
        }
        public List<DSTrungTuyen> layDSTrungTuyen()
        {
            return ThiSinhTrungTuyenDAL.Instance.layDSTrungTuyen();
        }
        public List<DSTrungTuyen> TimDSTrungTuyens(string value)
        {
            return ThiSinhTrungTuyenDAL.Instance.TimDSTrungTuyens(value);
        }
    }
}
