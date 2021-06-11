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
    public partial class danhsachhoadonnhap : Form
    {
        public danhsachhoadonnhap()
        {
            InitializeComponent();
        }

        private void hoadonnhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoadonnhapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanli_hieuthuocDataSet1);

        }
        datatil data = new datatil();
        private void hienthi()
        {
            try
            {
                
                hoadonnhapDataGridView.DataSource = data.hoadonnhap();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo");
            }
        }
        private void hienthi1()
        {
            try
            {
                chitiethoadonnhapDataGridView.DataSource = data.chitiethoadonnhap();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo");
            }
        }

        private void danhsachhoadonnhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.chitiethoadonnhap' table. You can move, or remove it, as needed.
            this.chitiethoadonnhapTableAdapter.Fill(this.quanli_hieuthuocDataSet1.chitiethoadonnhap);
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.hoadonnhap' table. You can move, or remove it, as needed.
            this.hoadonnhapTableAdapter.Fill(this.quanli_hieuthuocDataSet1.hoadonnhap);
            hienthi();
            hienthi1();
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_chinh n = new menu_chinh();
            n.ShowDialog();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            
        }

        private void hoadonnhapDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tim = txt_soctnhap.Text;

            if (!string.IsNullOrEmpty(tim))/*nếu trống rỗng*/
            {
                DataTable table = data.Findchitiethoadonnhap(tim);
                chitiethoadonnhapDataGridView.DataSource = table;

            }
            else
            {
                hienthi1();
            }
        }
        int d;
        private void hoadonnhapDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            txt_soctnhap.Text = hoadonnhapDataGridView.Rows[d].Cells[0].Value.ToString();
        }

        
    }
}
