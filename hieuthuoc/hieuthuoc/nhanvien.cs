using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc
{
    class nhanvien
    {
        public nhanvien()
        {

        }
        public string manhanvien { get; set; }
        public string hoten { get; set; }
        public string chucvu { get; set; }
        public string gioitinh { get; set; }
        public int tuoi { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public string sodienthoai { get; set; }
        public string phanquyen { get; set; }
        public string tendangnhap { get; set; }
        public string matkhau { get; set; }
        public string hinhanh { get; set; }
        


        public nhanvien(string mnv, string ht, string cv, string gt, int tuoi, string dc, string m, string dt, string pq, string un, string p, string ha)
        {
            this.manhanvien = mnv;
            this.hoten = ht;
            this.chucvu = cv;
            this.gioitinh = gt;
            this.tuoi = tuoi;
            this.diachi = dc;
            this.email = m;
            this.sodienthoai = dt;
            this.phanquyen = pq;
            this.tendangnhap = un;
            this.matkhau = p;
            this.hinhanh = ha;
            
        }
    }
}
