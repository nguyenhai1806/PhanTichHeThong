using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phuong
    {
        string name, codename, division_type, short_codename;
        int code, phone_code;

        public string Name { get => name; set { name = value; } }
        public string Codename { get => codename; set => codename = value; }
        public string Division_type { get => division_type; set => division_type = value; }
        public int Code { get => code; set => code = value; }
        public int Phone_code { get => phone_code; set => phone_code = value; }
        public string Short_codename { get => short_codename; set => short_codename = value; }
    }
}
