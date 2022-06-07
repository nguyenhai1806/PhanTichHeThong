using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class NamHocBLL
    {
        #region instance

        private static NamHocBLL instance;

        public static NamHocBLL Instance
        {
            get
            {
                if (instance == null) instance = new NamHocBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private NamHocBLL()
        {
        }

        #endregion
        public List<NamHoc> layNamHocs()
        {
            return NamHocDAL.Instance.layNamHocs();
        }
    }
}
