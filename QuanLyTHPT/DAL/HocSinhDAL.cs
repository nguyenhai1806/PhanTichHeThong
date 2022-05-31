using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HocSinhDAL
    {
        #region instance

        private static HocSinhDAL instance;

        public static HocSinhDAL Instance
        {
            get
            {
                if (instance == null) instance = new HocSinhDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private HocSinhDAL()
        {
        }

        #endregion
        QL_THPTDataContext dataContext = new QL_THPTDataContext();
        public List<HOCSINH> layTatCaHocSinh()
        {
            return dataContext.HOCSINHs.ToList<HOCSINH>();
        }
    }
}
