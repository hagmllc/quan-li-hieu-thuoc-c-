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
    public partial class laphoadonnhap : Form
    {
        public laphoadonnhap()
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
        private void laphoadonnhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.chitiethoadonxuat' table. You can move, or remove it, as needed.
            this.chitiethoadonxuatTableAdapter.Fill(this.quanli_hieuthuocDataSet1.chitiethoadonxuat);
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.chitiethoadonnhap' table. You can move, or remove it, as needed.
            this.chitiethoadonnhapTableAdapter.Fill(this.quanli_hieuthuocDataSet1.chitiethoadonnhap);
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.hoadonnhap' table. You can move, or remove it, as needed.
            hienthi();

        }
        datatil data = new datatil();
        private void xoatxt()
        {
            sochungtunhapTextBox.Text = "";
            manhanvienTextBox.Text = "";
            tennhacungcapTextBox.Text = "";
            ngaygionhapDateTimePicker.Text = "";
        }
        private void btn_laphoadonnhapthem_Click(object sender, EventArgs e)
        {
            try
            {
                hoadonnhap n = new hoadonnhap();
                n.sochungtunhap = sochungtunhapTextBox.Text;
                n.manhanvien = manhanvienTextBox.Text;
                n.ngaygionhap = ngaygionhapDateTimePicker.Value.ToString("yyyy-MM-dd");
                n.tennhacungcap = tennhacungcapTextBox.Text;
                n.tongtiennhap = 0;
                data.themhoadonnhap(n);
                hienthi();
                xoa1();
                lbl_thongbso.Text = "Thêm hoá đơn nhập thành công!!!";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message,"Thông báo");
            }

        }

        private void btn_lhdnsua_Click(object sender, EventArgs e)
        {
            try
            {
                hoadonnhap n = new hoadonnhap();
                n.sochungtunhap = sochungtunhapTextBox.Text;
                n.manhanvien = manhanvienTextBox.Text;
                n.ngaygionhap = ngaygionhapDateTimePicker.Value.ToString("yyyy-MM-dd");
                n.tennhacungcap = tennhacungcapTextBox.Text;
                
                data.capnhathoadonnhap(n);
                hienthi();
                xoa1();
                lbl_thongbso.Text = "Sửa hoá đơn nhập thành công!!!";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo");
            }
        }

        private void btn_lhdnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                hoadonnhap n = new hoadonnhap();
                string sochungtunhap = sochungtunhapTextBox.Text;
                data.xoahoadonnhap(sochungtunhap);
                
                lbl_thongbso.Text = "Xoá hoá đơn nhập thành công!!!";
                hienthi();
                xoa1();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                chitiethoadonnhap n = new chitiethoadonnhap();
                n.sochungtunhap = sochungtunhapTextBox1.Text;
                n.mathuoc = mathuocTextBox.Text;
                n.dongiavon = Convert.ToInt32(dongiavonTextBox.Text);
                n.soluongnhap = Convert.ToInt32(soluongnhapTextBox.Text);
                data.themchitiethoadonnhap(n);
                hienthi1();
                hienthi();
                xoa2();
                lbl_thongbao2.Text = "Thêm chi tiết hoá đơn nhập thành công!!!";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                chitiethoadonnhap n = new chitiethoadonnhap();
                n.sochungtunhap = sochungtunhapTextBox1.Text;
                n.mathuoc = mathuocTextBox.Text;
                n.dongiavon = Convert.ToInt32(dongiavonTextBox.Text);
                n.soluongnhap = Convert.ToInt32(soluongnhapTextBox.Text);
                data.capnhatchitiethoadonnhap(n);
                hienthi1();
                hienthi();
                xoa2();
                lbl_thongbao2.Text = "Sửa chi tiết hoá đơn nhập thành công!!!";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                chitiethoadonnhap n = new chitiethoadonnhap();
                string sochungtunhap = sochungtunhapTextBox1.Text;
                data.xoachitiethoadonnhap(sochungtunhap);

                lbl_thongbao2.Text = "Xoá chi tiết hoá đơn nhập thành công!!!";
                hienthi1();
                hienthi();
                xoa2();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo");
            }
        }
        private void xoa1()
        {
            sochungtunhapTextBox.Text = "";
            manhanvienTextBox.Text = "";
            ngaygionhapDateTimePicker.Text = "";
            tennhacungcapTextBox.Text = "";
            sochungtunhapTextBox.Focus();
        }
        private void xoa2()
        {
            sochungtunhapTextBox1.Text = "";
            mathuocTextBox.Text = "";
            dongiavonTextBox.Text = "";
            soluongnhapTextBox.Text = "";
            sochungtunhapTextBox1.Focus();
        }
    }
}
