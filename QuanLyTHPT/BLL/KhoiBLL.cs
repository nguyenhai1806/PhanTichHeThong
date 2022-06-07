using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class KhoiBLL
    {
        #region instance

        private static KhoiBLL instance;

        public static KhoiBLL Instance
        {
            get
            {
                if (instance == null) instance = new KhoiBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private KhoiBLL()
        {

        }
        #endregion
        public List<Khoi> laykhois(){
            return KhoiDAL.Instance.layKhois();
        }
    }
}
