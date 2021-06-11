using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hieuthuoc
{
    class datatil
    {
        SqlConnection con;
        
        public datatil()
        {
            string strconnect = @"Data Source = PHAMHAIANH\SQLEXPRESS; Initial Catalog = quanli_hieuthuoc; Integrated Security = True";
            con = new SqlConnection(strconnect);
        }
        public DataTable thuoc()
        {
            DataTable table = new DataTable();
            string sql = "select * from thuoc";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable nhanvien()
        {
            DataTable table = new DataTable();
            string sql = "select * from nhanvien";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;

        }
        public DataTable hoadonnhap()
        {
            DataTable table = new DataTable();
            string sql = "select * from hoadonnhap";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable chitiethoadonnhap()
        {
            DataTable table = new DataTable();
            string sql = "select * from chitiethoadonnhap";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable nhomthuoc()
        {
            DataTable table = new DataTable();
            string sql = "select * from nhomthuoc";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable hoadonxuat()
        {
            DataTable table = new DataTable();
            string sql = "select * from hoadonxuat";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public DataTable chitiethoadonxuat()
        {
            DataTable table = new DataTable();
            string sql = "select * from chitiethoadonxuat";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        // hoá đơn nhập
        public void themhoadonnhap(hoadonnhap s)
        {
            
                con.Open();
                
                string sql = "insert into hoadonnhap values(@sochungtunhap,@manhanvien,@ngaygionhap,@tennhacungcap,@tongtiennhap)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("sochungtunhap", s.sochungtunhap);
                cmd.Parameters.AddWithValue("manhanvien", s.manhanvien);
                cmd.Parameters.AddWithValue("ngaygionhap", s.ngaygionhap);
                cmd.Parameters.AddWithValue("tennhacungcap", s.tennhacungcap);
                cmd.Parameters.AddWithValue("tongtiennhap", s.tongtiennhap);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                //nhập xong tự tính tổng
                string sql1 = "update hoadonnhap set tongtiennhap = (select SUM(dongiavon * soluongnhap) from chitiethoadonnhap where sochungtunhap = hoadonnhap.sochungtunhap)";
                SqlCommand cm1 = new SqlCommand(sql1, con);
                cm1.ExecuteNonQuery();
                con.Close();
            
        }
        public void capnhathoadonnhap(hoadonnhap s)
        {
            con.Open();
            string sql = "update hoadonnhap set sochungtunhap=@sochungtunhap, manhanvien = @manhanvien, ngaygionhap =@ngaygionhap, tennhacungcap = @tennhacungcap, tongtiennhap =(select SUM(dongiavon * soluongnhap) from chitiethoadonnhap where sochungtunhap = hoadonnhap.sochungtunhap) where sochungtunhap=@sochungtunhap";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtunhap", s.sochungtunhap);
            cmd.Parameters.AddWithValue("manhanvien", s.manhanvien);
            cmd.Parameters.AddWithValue("ngaygionhap", s.ngaygionhap);
            cmd.Parameters.AddWithValue("tennhacungcap", s.tennhacungcap);
            cmd.Parameters.AddWithValue("tongtiennhap", s.tongtiennhap);
            cmd.ExecuteNonQuery();
            con.Close();
            //
            
        }
        public void xoahoadonnhap(string sochungtunhap)
        {
            con.Open();
            string sql = "delete from hoadonnhap where sochungtunhap = @sochungtunhap";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtunhap", sochungtunhap);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //hoá đơn xuất
        public void themhoadonxuat(hoadonxuat s)
        {

            con.Open();

            string sql = "insert into hoadonxuat values(@sochungtuxuat,@manhanvien,@ngaygioxuat,@tongtienban)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtuxuat", s.sochungtuxuat);
            cmd.Parameters.AddWithValue("manhanvien", s.manhanvien);
            cmd.Parameters.AddWithValue("ngaygioxuat", s.ngaygioxuat);
            
            cmd.Parameters.AddWithValue("tongtienban", s.tongtienban);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            //nhập xong tự tính tổng
            string sql1 = "update hoadonxuat set tongtienban = (select SUM(dongiaban * soluongxuat) from chitiethoadonxuat where sochungtuxuat = hoadonxuat.sochungtuxuat)";
            SqlCommand cm1 = new SqlCommand(sql1, con);
            cm1.ExecuteNonQuery();
            con.Close();

        }
        public void capnhathoadonxuat(hoadonxuat s)
        {
            con.Open();
            string sql = "update hoadonxuat set sochungtuxuat=@sochungtuxuat, manhanvien = @manhanvien, ngaygioxuat =@ngaygioxuat, tongtienban = (select SUM(dongiaban * soluongxuat) from chitiethoadonxuat where sochungtuxuat = hoadonxuat.sochungtuxuat) where sochungtuxuat = @sochungtuxuat";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtuxuat", s.sochungtuxuat);
            cmd.Parameters.AddWithValue("manhanvien", s.manhanvien);
            cmd.Parameters.AddWithValue("ngaygioxuat", s.ngaygioxuat);

            cmd.Parameters.AddWithValue("tongtienban", s.tongtienban);
            cmd.ExecuteNonQuery();
            con.Close();
            //

        }
        public void xoahoadonxuat(string sochungtuxuat)
        {
            con.Open();
            string sql = "delete from hoadonxuat where sochungtuxuat = @sochungtuxuat";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtuxuat", sochungtuxuat);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //chi tiết hoá đơn nhập
        public void themchitiethoadonnhap(chitiethoadonnhap s)
        {

            con.Open();

            string sql = "insert into chitiethoadonnhap values(@sochungtunhap,@mathuoc,@dongiavon,@soluongnhap)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtunhap", s.sochungtunhap);
            cmd.Parameters.AddWithValue("mathuoc", s.mathuoc);
            cmd.Parameters.AddWithValue("dongiavon", s.dongiavon);
            cmd.Parameters.AddWithValue("soluongnhap", s.soluongnhap);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            //nhập xong tự tính tổng
            string sql1 = "update hoadonnhap set tongtiennhap = (select SUM(dongiavon * soluongnhap) from chitiethoadonnhap where sochungtunhap = hoadonnhap.sochungtunhap)";
            SqlCommand cm1 = new SqlCommand(sql1, con);
            cm1.ExecuteNonQuery();
            con.Close();

        }
        public void capnhatchitiethoadonnhap(chitiethoadonnhap s)
        {
            con.Open();
            string sql = "update chitiethoadonnhap set sochungtunhap=@sochungtunhap, mathuoc = @mathuoc, dongiavon =@dongiavon, soluongnhap = @soluongnhap where sochungtunhap = @sochungtunhap";
            
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtunhap", s.sochungtunhap);
            cmd.Parameters.AddWithValue("mathuoc", s.mathuoc);
            cmd.Parameters.AddWithValue("dongiavon", s.dongiavon);
            cmd.Parameters.AddWithValue("soluongnhap", s.soluongnhap);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            //nhập xong tự tính tổng
            string sql1 = "update hoadonnhap set tongtiennhap = (select SUM(dongiavon * soluongnhap) from chitiethoadonnhap where sochungtunhap = hoadonnhap.sochungtunhap)";
            SqlCommand cm1 = new SqlCommand(sql1, con);
            cm1.ExecuteNonQuery();
            con.Close();

        }
        public void xoachitiethoadonnhap(string sochungtunhap)
        {
            con.Open();
            string sql = "delete from chitiethoadonnhap where sochungtunhap = @sochungtunhap";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtunhap", sochungtunhap);
            cmd.ExecuteNonQuery();
            string sql1 = "update hoadonnhap set tongtiennhap = (select SUM(dongiavon * soluongnhap) from chitiethoadonnhap where sochungtunhap = hoadonnhap.sochungtunhap)";
            SqlCommand cm1 = new SqlCommand(sql1, con);
            cm1.ExecuteNonQuery();
            con.Close();
            
        }
        //chi tiết hoá đơn xuất
        public void themchitiethoadonxuat(chitiethoadonxuat s)
        {

            con.Open();

            string sql = "insert into chitiethoadonxuat values(@sochungtuxuat,@mathuoc,@dongiaban,@soluongxuat)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtuxuat", s.sochungtuxuat);
            cmd.Parameters.AddWithValue("mathuoc", s.mathuoc);
            cmd.Parameters.AddWithValue("dongiaban", s.dongiaban);
            cmd.Parameters.AddWithValue("soluongxuat", s.soluongxuat);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            //nhập xong tự tính tổng
            string sql1 = "update hoadonxuat set tongtienban = (select SUM(dongiaban * soluongxuat) from chitiethoadonxuat where sochungtuxuat = hoadonxuat.sochungtuxuat)";
            SqlCommand cm1 = new SqlCommand(sql1, con);
            cm1.ExecuteNonQuery();
            con.Close();

        }
        public void capnhatchitiethoadonxuat(chitiethoadonxuat s)
        {
            con.Open();
            string sql = "update chitiethoadonxuat set sochungtuxuat=@sochungtuxuat, mathuoc = @mathuoc, dongiaban =@dongiaban, soluongxuat = @soluongxuat where sochungtuxuat = @sochungtuxuat";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtuxuat", s.sochungtuxuat);
            cmd.Parameters.AddWithValue("mathuoc", s.mathuoc);
            cmd.Parameters.AddWithValue("dongiaban", s.dongiaban);
            cmd.Parameters.AddWithValue("soluongxuat", s.soluongxuat);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            //nhập xong tự tính tổng
            //nhập xong tự tính tổng
            string sql1 = "update hoadonxuat set tongtienban = (select SUM(dongiaban * soluongxuat) from chitiethoadonxuat where sochungtuxuat = hoadonxuat.sochungtuxuat)";
            SqlCommand cm1 = new SqlCommand(sql1, con);
            cm1.ExecuteNonQuery();
            con.Close();

        }
        public void xoachitiethoadonxuat(string sochungtuxuat)
        {
            con.Open();
            string sql = "delete from chitiethoadonxuat where sochungtuxuat = @sochungtuxuat";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtuxuat", sochungtuxuat);
            cmd.ExecuteNonQuery();
            string sql1 = "update hoadonxuat set tongtienban = (select SUM(dongiaban * soluongxuat) from chitiethoadonxuat where sochungtuxuat = hoadonxuat.sochungtuxuat)";
            SqlCommand cm1 = new SqlCommand(sql1, con);
            cm1.ExecuteNonQuery();
            con.Close();

        }
        //thuốc
        public void themnhomthuoc(nhomthuoc s)
        {
            con.Open();
            string sql = "insert into nhomthuoc values(@manhom,@tennhom)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manhom", s.manhom);
            cmd.Parameters.AddWithValue("tennhom", s.tennhom);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void capnhatnhomthuoc(nhomthuoc s)
        {
            con.Open();
            string sql = "update nhomthuoc set manhom=@manhom, tennhom = @tennhom where manhom=@manhom";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manhom", s.manhom);
            cmd.Parameters.AddWithValue("tennhom", s.tennhom);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void xoanhomthuoc(string manhom)
        {
            con.Open();
            string sql = "delete from nhomthuoc where manhom = @manhom";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manhom", manhom);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void themthuoc(thuoc s)
        {
            con.Open();
            string source = Application.StartupPath.ToString();
            string path = source + "\\" + s.hinhanh;
            string sql = "insert into thuoc(mathuoc,manhom,tenthuoc,congdung,thanhphan,donvitinh,xuatxu,giaban,soluong,hinhanh)" +
                "select @mathuoc,@manhom,@tenthuoc,@congdung,@thanhphan,@donvitinh,@xuatxu,@giaban,@soluong,BulkColumn from openrowset (bulk '" + path + "',Single_Blob) as Picture";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("mathuoc", s.mathuoc);
            cmd.Parameters.AddWithValue("manhom", s.manhom);
            cmd.Parameters.AddWithValue("tenthuoc", s.tenthuoc);
            cmd.Parameters.AddWithValue("congdung", s.congdung);
            cmd.Parameters.AddWithValue("thanhphan", s.thanhphan);
            cmd.Parameters.AddWithValue("donvitinh", s.donvitinh);
            cmd.Parameters.AddWithValue("xuatxu", s.xuatxu);
            cmd.Parameters.AddWithValue("giaban", s.giaban);
            cmd.Parameters.AddWithValue("soluong", s.soluong);
            cmd.Parameters.AddWithValue("hinhanh", s.hinhanh);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void capnhatthuoc(thuoc s)
        {

            con.Open();
            string sql = "update thuoc set mathuoc=@mathuoc, manhom=@manhom, tenthuoc = @tenthuoc, congdung=@congdung,thanhphan=@thanhphan, donvitinh = @donvitinh, xuatxu = @xuatxu, giaban = @giaban, soluong = @soluong where mathuoc=@mathuoc";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("mathuoc", s.mathuoc);
            cmd.Parameters.AddWithValue("manhom", s.manhom);
            cmd.Parameters.AddWithValue("tenthuoc", s.tenthuoc);
            cmd.Parameters.AddWithValue("congdung", s.congdung);
            cmd.Parameters.AddWithValue("thanhphan", s.thanhphan);
            cmd.Parameters.AddWithValue("donvitinh", s.donvitinh);
            cmd.Parameters.AddWithValue("xuatxu", s.xuatxu);
            cmd.Parameters.AddWithValue("giaban", s.giaban);
            cmd.Parameters.AddWithValue("soluong", s.soluong);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void xoathuoc(string mathuoc)
        {
            con.Open();
            string sql = "delete from thuoc where mathuoc = @mathuoc";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("mathuoc", mathuoc);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //nhân viên

        public void themnhanvien(nhanvien s)
        {
            con.Open();

            string source = Application.StartupPath.ToString();
            string path = source + "\\" + s.hinhanh;
            string sql = "insert into nhanvien(manhanvien,hoten,chucvu,gioitinh,tuoi,diachi,email,sodienthoai,phanquyen,tendangnhap,matkhau,hinhanh)" +
                "select @manhanvien,@hoten,@chucvu,@gioitinh,@tuoi,@diachi,@email,@sodienthoai,@phanquyen,@tendangnhap,@matkhau,BulkColumn from openrowset (bulk '"+ path + "',Single_Blob) as Picture";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manhanvien", s.manhanvien);
            cmd.Parameters.AddWithValue("hoten", s.hoten);
            cmd.Parameters.AddWithValue("chucvu", s.chucvu);
            cmd.Parameters.AddWithValue("gioitinh", s.gioitinh);
            cmd.Parameters.AddWithValue("tuoi", s.tuoi);
            cmd.Parameters.AddWithValue("diachi", s.diachi);
            cmd.Parameters.AddWithValue("email", s.email);
            cmd.Parameters.AddWithValue("sodienthoai", s.sodienthoai);
            cmd.Parameters.AddWithValue("phanquyen", s.phanquyen);
            cmd.Parameters.AddWithValue("tendangnhap", s.tendangnhap);
            cmd.Parameters.AddWithValue("matkhau", s.matkhau);
            cmd.Parameters.AddWithValue("hinhanh", s.hinhanh);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        //xoá nhân viên
        public void xoanhanvien(string manhanvien)
        {
            con.Open();
            string sql = "delete from nhanvien where manhanvien = @manhanvien";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manhanvien", manhanvien);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void capnhatnhanvien(nhanvien s)
        {

            con.Open();
            string sql = "update nhanvien set manhanvien=@manhanvien, hoten=@hoten, chucvu=@chucvu, gioitinh=@gioitinh, tuoi=@tuoi, diachi=@diachi, email = @email, sodienthoai=@sodienthoai, phanquyen=@phanquyen, tendangnhap=@tendangnhap, matkhau=@matkhau where manhanvien=@manhanvien";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manhanvien", s.manhanvien);
            cmd.Parameters.AddWithValue("hoten", s.hoten);
            cmd.Parameters.AddWithValue("chucvu", s.chucvu);
            cmd.Parameters.AddWithValue("gioitinh", s.gioitinh);
            cmd.Parameters.AddWithValue("tuoi", s.tuoi);
            cmd.Parameters.AddWithValue("diachi", s.diachi);
            cmd.Parameters.AddWithValue("email", s.email);
            cmd.Parameters.AddWithValue("sodienthoai", s.sodienthoai);
            cmd.Parameters.AddWithValue("phanquyen", s.phanquyen);
            cmd.Parameters.AddWithValue("tendangnhap", s.tendangnhap);
            cmd.Parameters.AddWithValue("matkhau", s.matkhau);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //tìm kiếm thuốc theo mã
        public DataTable Findthuoc(string s)
        {
            DataTable table = new DataTable();
            string sql = "select * from thuoc where mathuoc like N'%" + s + "%' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        //tìm thuốc theo tên
        public DataTable Findthuoctheoten(string s)
        {
            DataTable table = new DataTable();
            string sql = "select * from thuoc where tenthuoc like N'%" + s + "%' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        //tìm thuốc theo mã nhóm
        public DataTable Findthuoctheomanhom(string s)
        {
            DataTable table = new DataTable();
            string sql = "select * from thuoc where manhom like N'%" + s + "%' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }

        //tìm thuốc theo công dụng
        public DataTable Findthuoctheocongdung(string s)
        {
            DataTable table = new DataTable();
            string sql = "select * from thuoc where congdung like N'%" + s + "%' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        //tìm thuốc theo thành phần
        public DataTable Findthuoctheothanhphan(string s)
        {
            DataTable table = new DataTable();
            string sql = "select * from thuoc where thanhphan like N'%" + s + "%' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        //tìm chi tiết hoá đơn xuất theo số chứng từ xuất
        public DataTable Findchitiethoadonxuat(string s)
        {
            DataTable table = new DataTable();
            
            string sql = "select thuoc.mathuoc, manhom, congdung, xuatxu, donvitinh, dongiaban, soluongxuat from thuoc inner join chitiethoadonxuat on thuoc.mathuoc = chitiethoadonxuat.mathuoc where sochungtuxuat like N'%" + s + "%'";
            
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        //tìm chi tiết hoá đơn nhập theo số chứng từ nhập
        public DataTable Findchitiethoadonnhap(string s)
        {
            DataTable table = new DataTable();
            string sql = "select * from chitiethoadonnhap where sochungtunhap like N'%" + s + "%'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        //tra cứu thuốc
        public DataTable timthuoc(string s)
        {
            DataTable table = new DataTable();
            string sql = "select * from thuoc where mathuoc like N'%" + s + "%' or tenthuoc like N'%" + s + "%' or congdung like N'%" + s + "%'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }

    }
}
