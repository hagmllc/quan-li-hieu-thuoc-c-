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
    public partial class nhapthuocvaokho : Form
    {
        public nhapthuocvaokho()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_chinh n = new menu_chinh();
            n.ShowDialog();
        }

        private void nhomthuocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhomthuocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanli_hieuthuocDataSet1);

        }

        private void nhapthuocvaokho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.quanli_hieuthuocDataSet1.thuoc);
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.nhomthuoc' table. You can move, or remove it, as needed.
            this.nhomthuocTableAdapter.Fill(this.quanli_hieuthuocDataSet1.nhomthuoc);

        }
        private void hienthi()
        {
            try
            {
                nhomthuocDataGridView.DataSource = data.nhomthuoc();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo");
            }
        }
        private void hienthithuoc()
        {
            try
            {
                thuocDataGridView.DataSource = data.thuoc();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo");
            }
        }
        private void xoatxtthuoc()
        {
            mathuocTextBox.Text = "";
            manhomTextBox.Text = "";
            tenthuocTextBox.Text = "";
            congdungTextBox.Text = "";
            thanhphanTextBox.Text = "";
            xuatxuTextBox.Text = "";
            donvitinhTextBox.Text = "";
            giabanTextBox.Text = "";
            linkanhTextBox.Text = "";
            soluongTextBox.Text = "";
            mathuocTextBox.Focus();
        }
        private void xoatbnhomthuoc()
        {
            txt_manhom.Text = "";
            txt_tennhom.Text = "";
            txt_manhom.Focus();
        }
        datatil data = new datatil();
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                nhomthuoc s = new nhomthuoc();
                s.manhom = txt_manhom.Text;
                s.tennhom = txt_tennhom.Text;
                data.themnhomthuoc(s);
                lb_thongbao.Text = "Thêm nhóm có mã " + txt_manhom.Text + " thành công!!!";
                hienthi();
                xoatbnhomthuoc();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, " Thông báo");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                nhomthuoc s = new nhomthuoc();
                s.manhom = txt_manhom.Text;
                s.tennhom = txt_tennhom.Text;
                data.capnhatnhomthuoc(s);
                lb_thongbao.Text = "Cập nhật nhóm thuốc có mã " + txt_manhom.Text + " thành công!!!";
                hienthi();
                xoatbnhomthuoc();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, " thông báo");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string manhom = txt_manhom.Text;
                data.xoanhomthuoc(manhom);
                hienthi();
                lb_thongbao.Text = "Xoá nhóm thuốc có mã " + txt_manhom.Text + " thành công!!!";
                xoatbnhomthuoc();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, " Thông báo");
            }
        }

        private void btn_themthuoc_Click(object sender, EventArgs e)
        {
            
                
            try
            {
                thuoc s = new thuoc();
                s.mathuoc = mathuocTextBox.Text;
                s.manhom = manhomTextBox.Text;
                s.tenthuoc = tenthuocTextBox.Text;
                s.congdung = congdungTextBox.Text;
                s.thanhphan = thanhphanTextBox.Text;
                s.donvitinh = donvitinhTextBox.Text;
                s.xuatxu = xuatxuTextBox.Text;
                s.giaban = Convert.ToInt32(giabanTextBox.Text);
                s.soluong = Convert.ToInt32(soluongTextBox.Text);
                s.hinhanh = linkanhTextBox.Text;
                data.themthuoc(s);
                hienthithuoc();
                xoatxtthuoc();
                lb_thongbaothuoc.Text = "Thêm thuốc thành công!!!";
            }
            catch (Exception ex)
            {

                MessageBox.Show("có lỗi " + ex.Message, "Thông báo");
            }
            
        }

        private void btn_suathuoc_Click(object sender, EventArgs e)
        {
            try
            {
                thuoc s = new thuoc();
                s.mathuoc = mathuocTextBox.Text;
                s.manhom = manhomTextBox.Text;
                s.tenthuoc = tenthuocTextBox.Text;
                s.congdung = congdungTextBox.Text;
                s.thanhphan = thanhphanTextBox.Text;
                s.donvitinh = donvitinhTextBox.Text;
                s.xuatxu = xuatxuTextBox.Text;
                s.giaban = Convert.ToInt32(giabanTextBox.Text);
                s.soluong = Convert.ToInt32(soluongTextBox.Text);
                s.hinhanh = linkanhTextBox.Text;
                data.capnhatthuoc(s);
                hienthithuoc();
                xoatxtthuoc();
                lb_thongbaothuoc.Text = "Cập nhật thuốc thành công!!!";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo");
            }
        }

        private void btn_xoathuoc_Click(object sender, EventArgs e)
        {
            try
            {
                string mathuoc = mathuocTextBox.Text;
                data.xoathuoc(mathuoc);
                hienthithuoc();
                xoatxtthuoc();
                lb_thongbaothuoc.Text = "Xoá thuốc có mã thành công!!!";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message,"Thông báo");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
