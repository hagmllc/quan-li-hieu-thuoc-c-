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
    public partial class danhsachhoadonxuat : Form
    {
        public danhsachhoadonxuat()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_chinh n = new menu_chinh();
            n.ShowDialog();
        }

        private void hoadonxuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoadonxuatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanli_hieuthuocDataSet1);

        }

        private void danhsachhoadonxuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.chitiethoadonxuat' table. You can move, or remove it, as needed.
            this.chitiethoadonxuatTableAdapter.Fill(this.quanli_hieuthuocDataSet1.chitiethoadonxuat);
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.hoadonxuat' table. You can move, or remove it, as needed.
            this.hoadonxuatTableAdapter.Fill(this.quanli_hieuthuocDataSet1.hoadonxuat);
            

            
        }
        private void hienthi()
        {
            try
            {
                chitiethoadonxuatDataGridView.DataSource = data.chitiethoadonxuat();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo");
            }
        }
        datatil data = new datatil();
        private void hoadonxuatDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void hoadonxuatDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tim = sochungtuxuatTextBox.Text;
            if (!string.IsNullOrEmpty(tim))/*nếu trống rỗng*/
            {
                DataTable table = data.Findchitiethoadonxuat(tim);
                chitiethoadonxuatDataGridView.DataSource = table;

            }
            else
            {
                hienthi();
            }
        }
    }
}
