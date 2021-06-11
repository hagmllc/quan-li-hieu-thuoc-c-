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
    public partial class xoanhanvien : Form
    {
        public xoanhanvien()
        {
            InitializeComponent();
        }

        private void nhanvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanli_hieuthuocDataSet);

        }

        private void xoanhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.quanli_hieuthuocDataSet.nhanvien);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        datatil data = new datatil();
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string manhanvien = manhanvienTextBox.Text;
                data.xoanhanvien(manhanvien);
                lb_thongbao.Text = "Xoá thành công nhân viên có mã " + manhanvienTextBox.Text +"!!!!";
                manhanvienTextBox.Text = "";
                manhanvienTextBox.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi khi xoá" + ex.Message, "Thông báo");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.ShowDialog();
        }
    }
}
