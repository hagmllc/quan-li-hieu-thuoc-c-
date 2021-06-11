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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap n = new dangnhap();
            n.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter1.Fill(this.quanli_hieuthuocDataSet1.nhanvien);
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.quanli_hieuthuocDataSet.nhanvien);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            themnhanvien n = new themnhanvien();
            n.ShowDialog();
        }

        private void xoáNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            xoanhanvien xoa = new xoanhanvien();
            xoa.ShowDialog();
        }

        private void sửaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            suanhanvien n = new suanhanvien();
            n.ShowDialog();
        }

        private void quảnLíThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_chinh n = new menu_chinh();
            n.ShowDialog();
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            xemchitietnv n = new xemchitietnv();
            n.ShowDialog();
        }
    }
}
