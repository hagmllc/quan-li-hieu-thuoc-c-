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
    public partial class suanhanvien : Form
    {
        public suanhanvien()
        {
            InitializeComponent();
        }

        private void nhanvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanli_hieuthuocDataSet);

        }

        private void suanhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet.nhanvien' table. You can move, or remove it, as needed.
            

        }
        datatil data = new datatil();
        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                manhanvienTextBox.Enabled = false;
                nhanvien s = new nhanvien();
                s.manhanvien = manhanvienTextBox.Text;
                s.hoten = hotenTextBox.Text;
                s.chucvu = chucvuTextBox.Text;
                s.gioitinh = gioitinhTextBox.Text;
                s.tuoi = Convert.ToInt32(tuoiTextBox.Text);
                s.diachi = diachiTextBox.Text;
                s.email = emailTextBox.Text;
                s.sodienthoai = sodienthoaiTextBox.Text;
                s.phanquyen = phanquyenTextBox.Text;
                s.tendangnhap = tendangnhapTextBox.Text;
                s.matkhau = matkhauTextBox.Text;

                data.capnhatnhanvien(s);
                this.Hide();
                admin ad = new admin();
                ad.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo");
            }
        }

        private void tuoiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gioitinhTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chucvuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hotenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void manhanvienTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void matkhauTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void diachiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tendangnhapTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phanquyenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sodienthoaiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
