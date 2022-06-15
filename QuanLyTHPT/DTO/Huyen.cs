using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Huyen
    {
        string name, division_type, codename;
        int code, province_code;
        List<Phuong> wards = new List<Phuong>();
        public string Name { get => name; set { name = value; } }
        public string Division_type { get => division_type; set => division_type = value; }
        public string Codename { get => codename; set => codename = value; }
        public int Code { get => code; set => code = value; }
        public int Province_code { get => province_code; set => province_code = value; }
        public List<Phuong> Wards { get => wards; set => wards = value; }
    }
}
