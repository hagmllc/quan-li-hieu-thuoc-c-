using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc
{
    class hoadonnhap
    {
        public hoadonnhap()
        {

        }
        public string sochungtunhap { get; set; }
        public string manhanvien { get; set; }
        public string ngaygionhap { get; set; }
        public string tennhacungcap { get; set; }
        public int tongtiennhap { get; set; }
        public hoadonnhap (string sct, string mn, string ng, string tn, int t)
        {
            this.sochungtunhap = sct;
            this.manhanvien = mn;
            this.ngaygionhap = ng;
            this.tennhacungcap = tn;
            this.tongtiennhap = t;
        }
    }
}
