using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace hieuthuoc
{
    public partial class baocaosoluongnhapxuat : Form
    {
        public baocaosoluongnhapxuat()
        {
            InitializeComponent();
            string strconnect = @"Data Source = PHAMHAIANH\SQLEXPRESS; Initial Catalog = quanli_hieuthuoc; Integrated Security = True";
            con = new SqlConnection(strconnect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        SqlConnection con;
        private void btn_xembaocao_Click(object sender, EventArgs e)
        {
            //bảng nhập
            DataTable table = new DataTable();
            string SQL_SELECT = "SELECT mathuoc, manhanvien, dongiavon, ngaygionhap, tennhacungcap FROM hoadonnhap INNER JOIN chitiethoadonnhap ON hoadonnhap.sochungtunhap = chitiethoadonnhap.sochungtunhap WHERE ngaygionhap BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
            SqlCommand data = new SqlCommand();
            data.CommandText = SQL_SELECT;
            con.Open();

            SqlDataAdapter adap = new SqlDataAdapter(SQL_SELECT, con);
            adap.Fill(table);
            data_dsthuocnhap.DataSource = table;
            con.Close();
            //bảng xuất
            DataTable table1 = new DataTable();
            string SQL_SELECT1 = "SELECT mathuoc, manhanvien, dongiaban, soluongxuat, ngaygioxuat FROM hoadonxuat INNER JOIN chitiethoadonxuat ON hoadonxuat.sochungtuxuat = chitiethoadonxuat.sochungtuxuat WHERE ngaygioxuat BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
            SqlCommand data1 = new SqlCommand();
            data.CommandText = SQL_SELECT1;

            con.Open();

            SqlDataAdapter adap1 = new SqlDataAdapter(SQL_SELECT1, con);
            adap1.Fill(table1);
            data_dsthuocxuat.DataSource = table1;
            con.Close();
            //báo cáo
            int solannhap = 0;
            int soluongnhap = 0;
            int solanban = 0;
            int soluongban = 0;
            int sc = data_dsthuocnhap.Rows.Count;
            int s = data_dsthuocxuat.Rows.Count;
            for (int i = 0; i < sc - 1; i++)
                solannhap += 1;
            for (int i = 0; i < s - 1; i++)
                solanban += 1;
            for (int i = 0; i < sc - 1; i++)
                soluongnhap += int.Parse(data_dsthuocnhap.Rows[i].Cells[2].Value.ToString());
            for (int i = 0; i < s - 1; i++)
                soluongban += int.Parse(data_dsthuocxuat.Rows[i].Cells[2].Value.ToString());

            lb_lannhap.Text = solannhap.ToString();
            lb_lanban.Text = solanban.ToString();
            lb_luongnhap.Text = soluongnhap.ToString();
            lb_luongban.Text = soluongban.ToString();


        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_chinh n = new menu_chinh();
            n.ShowDialog();
        }
    }
}
