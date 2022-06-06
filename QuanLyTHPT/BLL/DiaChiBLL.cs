using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Newtonsoft.Json;

namespace BLL
{
    
    public class DiaChiBLL
    {
        #region instance

        private static DiaChiBLL instance;
        public static DiaChiBLL Instance
        {
            get
            {
                if (instance == null) instance = new DiaChiBLL();
                return instance;
            }
            private set { instance = value; }
        }
        #endregion
        private DiaChiBLL()
        {
            
        }
        public List<Tinh> getData()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            string json = client.DownloadString("https://provinces.open-api.vn/api/?depth=3");
            List<Tinh> tinhs = JsonConvert.DeserializeObject<List<Tinh>>(json);
            return tinhs;
        }
        public string GernerateAddress(Tinh tinh, Huyen huyen, Phuong phuong, string duong)
        {
            return String.Format("{0}, {1}, {2}, {3}", duong, phuong.Name, huyen.Name, tinh.Name);
        }
        public void fillAddress(out Tinh tinh, out Huyen huyen, out Phuong phuong, out string duong, string address, List<Tinh> dataAddress)
        {
            duong = "";
            string[] add = address.Split(',');
            for (int i = 0; i < add.Count<string>(); i++)
                add[i] = add[i].Trim();
            int countIndex = add.Count<string>();
            tinh = dataAddress.Where(t => t.Name.Equals(add[countIndex - 1])).FirstOrDefault<Tinh>();
            huyen = tinh.Districts.Where(h => h.Name.Equals(add[countIndex - 2])).FirstOrDefault<Huyen>();
            phuong = huyen.Wards.Where(w => w.Name.Equals(add[countIndex - 3])).FirstOrDefault<Phuong>();
            for (int i = 0; i < add.Count<string>() - 3; i++)
            {
                if (duong == "")
                    duong += add[i];
                else
                    duong += ", " + add[i];
            }
        }
    }
}
