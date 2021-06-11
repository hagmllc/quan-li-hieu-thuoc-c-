using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;

namespace hieuthuoc
{
    public partial class inhoadonxuatthuoc : Form
    {
        public inhoadonxuatthuoc()
        {
            InitializeComponent();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_chinh n = new menu_chinh();
            n.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void hienthi()
        {
            try
            {
                dataGridView1.DataSource = data.thuoc();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo");
            }
        }
        datatil data = new datatil();
        
        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {
            string tim = txt_ctxuat.Text;
            if (!string.IsNullOrEmpty(tim))/*nếu trống rỗng*/
            {
                DataTable table = data.Findchitiethoadonxuat(tim);
                dataGridView1.DataSource = table;
                //
                int sc = dataGridView1.Rows.Count;
                int dem = 0;
                int tong = 0;
                
                for (int i = 0; i < sc - 1; i++)
                    dem += int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                
                for (int i = 0; i < sc - 1; i++)
                    tong += int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                lb_soluongthuoc.Text = dem.ToString();
                lb_tonghoadon.Text = tong.ToString();
            }
            else
            {
                hienthi();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            //PrintDialog pDlg = new PrintDialog();
            //PrintDocument pDoc = new PrintDocument();
            //pDoc.DocumentName = "Print Document";
            //pDlg.Document = pDoc;
            //pDlg.AllowSelection = true;
            //pDlg.AllowSomePages = true;

            //if (pDlg.ShowDialog() == DialogResult.OK)
            //{
            //    pDoc.Print();
            //}
            //else
            //{
            //    MessageBox.Show("Đã hủy in");
            //}

            ExportToExcel excel = new ExportToExcel();
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            // DataTable này mỗi bạn lấy mỗi khác. 
            // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
            // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
            // DataGridView nhé 
            DataTable dt = (DataTable)dataGridView1.DataSource;
            excel.Export(dt, "chitiethoadonxuat", "CHI TIẾT HOÁ ĐƠN XUẤT");
            
        }

        private void btn_rs_Click(object sender, EventArgs e)
        {
            txt_ctxuat.Text = "";
            txt_ctxuat.Focus();
        }
    }
}
