using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc
{
    class chitiethoadonxuat
    {
        public chitiethoadonxuat()
        {

        }
        public string sochungtuxuat { get; set; }
        public string mathuoc { get; set; }
        public int dongiaban { get; set; }
        public int soluongxuat { get; set; }
        public chitiethoadonxuat(string a, string b, int c, int d)
        {
            this.sochungtuxuat = a;
            this.mathuoc = b;
            this.dongiaban = c;
            this.soluongxuat = d;
        }
    }
}
