using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc
{
    class chitiethoadonnhap
    {
        public chitiethoadonnhap()
        {

        }
        public string sochungtunhap { get; set; }
        public string mathuoc { get; set; }
        public int dongiavon { get; set; }
        public int soluongnhap { get; set; }
        public chitiethoadonnhap(string a, string b, int c, int d)
        {
            this.sochungtunhap = a;
            this.mathuoc = b;
            this.dongiavon = c;
            this.soluongnhap = d;
        }
    }
}
