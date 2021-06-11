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
    public partial class themnhanvien : Form
    {
        public themnhanvien()
        {
            InitializeComponent();
        }

        private void nhanvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanli_hieuthuocDataSet);

        }

        private void themnhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.quanli_hieuthuocDataSet.nhanvien);

        }
        datatil data = new datatil();
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                
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
                s.hinhanh = txt_linkanh.Text;
                data.themnhanvien(s);
                lbl_thongbao.Text = "Thêm nhân viên có mã " + manhanvienTextBox.Text + " thành công!!!";
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo");
            }
        }

        private void hinhanhPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void hinhanhLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void diachiLabel_Click(object sender, EventArgs e)
        {

        }

        private void sodienthoaiLabel_Click(object sender, EventArgs e)
        {

        }

        private void matkhauLabel_Click(object sender, EventArgs e)
        {

        }

        private void tendangnhapLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.ShowDialog();
        }

        private void nhaplai_Click(object sender, EventArgs e)
        {
            manhanvienTextBox.Text = "";
            hotenTextBox.Text = "";
            chucvuTextBox.Text = "";
            gioitinhTextBox.Text = "";
            tuoiTextBox.Text = "";
            diachiTextBox.Text = "";
            emailTextBox.Text = "";
            sodienthoaiTextBox.Text = "";
            phanquyenTextBox.Text = "";
            tendangnhapTextBox.Text = "";
            matkhauTextBox.Text = "";
            txt_linkanh.Text = "";
            manhanvienTextBox.Focus();
        }
    }
}
