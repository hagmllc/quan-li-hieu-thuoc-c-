using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc
{
    class thuoc
    {
        public thuoc()
        {
        }
        public string mathuoc { get; set; }
        public string manhom { get; set; }
        public string tenthuoc { get; set; }
        public string congdung { get; set; }
        public string thanhphan { get; set; }
        public string donvitinh { get; set; }
        public string xuatxu { get; set; }
        public int giaban { get; set; }
        public int soluong { get; set; }
        public string hinhanh { get; set; }
        public thuoc(string mt, string mn, string tt, string cd, string tp, string dvt, string xx, int gb, int sl, string sa)
        {
            this.mathuoc = mt;
            this.manhom = mn;
            this.tenthuoc = tt;
            this.congdung = cd;
            this.thanhphan = tp;
            this.donvitinh = dvt;
            this.xuatxu = xx;
            this.giaban = gb;
            this.soluong = sl;
            this.hinhanh = sa;
        }
    }
}
