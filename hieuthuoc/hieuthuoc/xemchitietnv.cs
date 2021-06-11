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
    public partial class xemchitietnv : Form
    {
        public xemchitietnv()
        {
            InitializeComponent();
        }

        private void nhanvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanli_hieuthuocDataSet);

        }

        private void xemchitietnv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter1.Fill(this.quanli_hieuthuocDataSet1.nhanvien);
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.quanli_hieuthuocDataSet.nhanvien);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin n = new admin();
            n.ShowDialog();
        }

        private void hinhanhPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void hinhanhLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
