using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tinh
    {
        private string name;
        private int code;
        private string codename;
        private int phone_code;
        private string division_type;
        List<Huyen> districts = new List<Huyen>();

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public int Code { get => code; set => code = value; }
        public string Codename { get => codename; set => codename = value; }
        public int Phone_code { get => phone_code; set => phone_code = value; }
        public string Division_type { get => division_type; set => division_type = value; }
        public List<Huyen> Districts { get => districts; set => districts = value; }
    }
}
