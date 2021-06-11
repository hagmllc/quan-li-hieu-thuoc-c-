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
    public partial class baocaodoanhthu : Form
    {
        public baocaodoanhthu()
        {
            InitializeComponent();
            string strconnect = @"Data Source = PHAMHAIANH\SQLEXPRESS; Initial Catalog = quanli_hieuthuoc; Integrated Security = True";
            con = new SqlConnection(strconnect);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_chinh n = new menu_chinh();
            n.ShowDialog();
        }

        private void hoadonnhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoadonnhapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanli_hieuthuocDataSet1);

        }

        private void baocaodoanhthu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.hoadonxuat' table. You can move, or remove it, as needed.
            this.hoadonxuatTableAdapter.Fill(this.quanli_hieuthuocDataSet1.hoadonxuat);
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.hoadonnhap' table. You can move, or remove it, as needed.


        }
        SqlConnection con;

        private void btn_xembaocao_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string SQL_SELECT = "SELECT * FROM hoadonnhap WHERE ngaygionhap BETWEEN '" + txt_tungay.Value.ToString("yyyy-MM-dd") + "' AND '" + txt_denngay.Value.ToString("yyyy-MM-dd") + "'";
            SqlCommand data = new SqlCommand();
            data.CommandText = SQL_SELECT;
            
            con.Open();

            SqlDataAdapter adap = new SqlDataAdapter(SQL_SELECT, con);
            adap.Fill(table);
            hoadonnhapDataGridView.DataSource = table;
            con.Close();
            //
            DataTable table1 = new DataTable();
            string SQL_SELECT1 = "SELECT * FROM hoadonxuat WHERE ngaygioxuat BETWEEN '" + txt_tungay.Value.ToString("yyyy-MM-dd") + "' AND '" + txt_denngay.Value.ToString("yyyy-MM-dd") + "'";
            SqlCommand data1 = new SqlCommand();
            data.CommandText = SQL_SELECT1;

            con.Open();

            SqlDataAdapter adap1 = new SqlDataAdapter(SQL_SELECT1, con);
            adap1.Fill(table1);
            hoadonxuatDataGridView.DataSource = table1;
            con.Close();
            //
            int sc = hoadonnhapDataGridView.Rows.Count;
            int dem1 = 0;
            
            int tong1 = 0;
            

            for (int i = 0; i < sc - 1; i++)
                dem1 = dem1 + 1;
            for (int i = 0; i < sc - 1; i++)
            tong1 += int.Parse(hoadonnhapDataGridView.Rows[i].Cells[4].Value.ToString());
            lb_hoadonnhap.Text = dem1.ToString();
            lb_giatrinhap.Text = tong1.ToString();
            //
            int s = hoadonxuatDataGridView.Rows.Count;
            int dem11 = 0;
            
            int tong11 = 0;
            

            for (int i = 0; i < s - 1; i++)
                dem11 = dem11 + 1;
            for (int i = 0; i < s - 1; i++)
                tong11 += int.Parse(hoadonxuatDataGridView.Rows[i].Cells[3].Value.ToString());
            lb_hoadonxuat.Text = dem11.ToString();
            lb_giatrixuat.Text = tong11.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_tungay.Text = "";
            txt_denngay.Text = "";
            txt_tungay.Focus();
        }
    }
}
