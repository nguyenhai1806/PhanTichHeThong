using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoSoBLL
    {
        #region instance

        private static HoSoBLL instance;

        public static HoSoBLL Instance
        {
            get
            {
                if (instance == null) instance = new HoSoBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private HoSoBLL()
        {
        }

        #endregion
        public List<HoSo_PP> GetHoSo()
        {
            return HoSoDAL.Instance.GetHoSo();
        }
    }
}
