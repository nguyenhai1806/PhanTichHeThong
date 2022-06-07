using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NamHocDAL
    {
        QL_THPTDataContext dataContext = new QL_THPTDataContext();
        #region instance

        private static NamHocDAL instance;

        public static NamHocDAL Instance
        {
            get
            {
                if (instance == null) instance = new NamHocDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private NamHocDAL()
        {
        }

        #endregion
        public List<NamHoc> layNamHocs()
        {
            return dataContext.NamHocs.ToList<NamHoc>();
        }

    }
}
