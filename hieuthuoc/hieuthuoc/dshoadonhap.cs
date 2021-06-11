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
    public partial class dshoadonhap : Form
    {
        public dshoadonhap()
        {
            InitializeComponent();
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
        datatil data = new datatil();
        private void hienthi()
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

        private void dshoadonhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.chitiethoadonnhap' table. You can move, or remove it, as needed.
            this.chitiethoadonnhapTableAdapter.Fill(this.quanli_hieuthuocDataSet1.chitiethoadonnhap);
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.hoadonnhap' table. You can move, or remove it, as needed.
            this.hoadonnhapTableAdapter.Fill(this.quanli_hieuthuocDataSet1.hoadonnhap);

        }

        private void hoadonnhapDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tim = sochungtunhapTextBox.Text;

            if (!string.IsNullOrEmpty(tim))/*nếu trống rỗng*/
            {
                DataTable table = data.Findchitiethoadonnhap(tim);
                chitiethoadonnhapDataGridView.DataSource = table;

            }
            else
            {
                hienthi();
            }
        }
    }
}
