using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc
{
    class nhomthuoc
    {
        public nhomthuoc()
        {

        }
        public string manhom { get; set; }
        public string tennhom { get; set; }
        public nhomthuoc (string mn, string tn)
        {
            this.manhom = mn;
            this.tennhom = tn;
        }
    }
}
