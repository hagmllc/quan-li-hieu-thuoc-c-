using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc
{
    class hoadonxuat
    {
        public hoadonxuat()
        {

        }
        public string sochungtuxuat { get; set; }
        public string manhanvien { get; set; }
        public string ngaygioxuat { get; set; }
        public int tongtienban { get; set; }
       
        public hoadonxuat(string a, string b, string c, int d)
        {
            this.sochungtuxuat = a;
            this.manhanvien = b;
            this.ngaygioxuat = c;
            this.tongtienban = d;
            
        }
    }
}
