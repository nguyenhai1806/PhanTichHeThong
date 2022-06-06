using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ThiSinhTrungTuyenDAL
    {
        #region instance
        QL_THPTDataContext dataContext = new QL_THPTDataContext();
        private static ThiSinhTrungTuyenDAL instance;
        public static ThiSinhTrungTuyenDAL Instance
        {
            get
            {
                if (instance == null) instance = new ThiSinhTrungTuyenDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private ThiSinhTrungTuyenDAL()
        {
        }

        #endregion
        public  DSTrungTuyen layThiSinhTheoCCCD(string cccd)
        {
            return dataContext.DSTrungTuyens.Where(ts => ts.CCCD == cccd).FirstOrDefault();
        }
        public List<DSTrungTuyen> layDSTrungTuyen()
        {
            return dataContext.DSTrungTuyens.ToList<DSTrungTuyen>();
        }
        public List<DSTrungTuyen> TimDSTrungTuyens(string value)
        {
            return (
                    from ts in dataContext.DSTrungTuyens
                    where SqlMethods.Like(ts.TenTS, "%" + value + "%") || SqlMethods.Like(ts.SoDienThoai, "%" + value + "%") || SqlMethods.Like(ts.MaTS, "%" + value + "%") || SqlMethods.Like(ts.CCCD, "%" + value + "%")
                    select ts).ToList<DSTrungTuyen>();    
        }
    }
}
