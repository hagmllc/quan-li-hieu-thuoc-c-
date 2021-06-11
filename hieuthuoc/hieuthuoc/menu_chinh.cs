using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hieuthuoc
{
    public partial class menu_chinh : Form
    {
        public menu_chinh()
        {
            InitializeComponent();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gioithieu n = new gioithieu();
            n.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap n = new dangnhap();
            n.ShowDialog();
        }

        private void laphoadonnhapthuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            laphoadonnhap n = new laphoadonnhap();
            n.ShowDialog();
        }

        private void danhSáchThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            danhsachthuoc n = new danhsachthuoc();
            n.ShowDialog();
        }

        private void nhậpThuốcVàoKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            nhapthuocvaokho n = new nhapthuocvaokho();
            n.ShowDialog();
        }

        private void tạoHoáĐơnXuấtThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            laphoadonxuat n = new laphoadonxuat();
            n.ShowDialog();
        }

        private void inHoáĐơnXuấtThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            inhoadonxuatthuoc n = new inhoadonxuatthuoc();
            n.ShowDialog();
        }

        private void danhSáchHoáĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            dshoadonhap n = new dshoadonhap();
            n.ShowDialog();
        }

        private void danhSáchHoáĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            danhsachhoadonxuat n = new danhsachhoadonxuat();
            n.ShowDialog();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            baocaodoanhthu n = new baocaodoanhthu();
            n.ShowDialog();
        }

        private void báoCáoSốLượngNhậpXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            baocaosoluongnhapxuat n = new baocaosoluongnhapxuat();
            n.ShowDialog();
        }

        private void menu_chinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet2.thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.quanli_hieuthuocDataSet2.thuoc);

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
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tim = txt_noidung.Text;

            if (!string.IsNullOrEmpty(tim))/*nếu trống rỗng*/
            {
                DataTable table = data.Findthuoc(tim);
                dataGridView1.DataSource = table;

            }
            else
            {
                hienthi();
            }
        }
        int d;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            mathuocTextBox.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            manhomTextBox.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            tenthuocTextBox.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            congdungTextBox.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
            thanhphanTextBox.Text = dataGridView1.Rows[d].Cells[4].Value.ToString();
            donvitinhTextBox.Text = dataGridView1.Rows[d].Cells[5].Value.ToString();
            xuatxuTextBox.Text = dataGridView1.Rows[d].Cells[6].Value.ToString();
            byte[] hinhanhPictureBox = (byte[])dataGridView1.Rows[d].Cells[7].Value;
            
        }
        
    }
}
