using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class KhoiDAL
    {
        QL_THPTDataContext dataContext = new QL_THPTDataContext();
        #region instance
        private static KhoiDAL instance;
        public static KhoiDAL Instance
        {
            get
            {
                if (instance == null) instance = new KhoiDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private KhoiDAL()
        {
        }
        #endregion
        public List<Khoi> layKhois()
        {
            return dataContext.Khois.ToList();
        }
    }
}
