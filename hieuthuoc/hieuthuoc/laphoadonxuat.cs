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
    public partial class laphoadonxuat : Form
    {
        public laphoadonxuat()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_chinh n = new menu_chinh();
            n.ShowDialog();
        }
        datatil data = new datatil();
        private void hienthi()
        {
            try
            {
                hoadonxuatDataGridView.DataSource = data.hoadonxuat();
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
                chitiethoadonxuatDataGridView.DataSource = data.chitiethoadonxuat();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo");
            }
        }
        private void thuocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.thuocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanli_hieuthuocDataSet1);

        }

        private void laphoadonxuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.chitiethoadonxuat' table. You can move, or remove it, as needed.
            this.chitiethoadonxuatTableAdapter.Fill(this.quanli_hieuthuocDataSet1.chitiethoadonxuat);
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.hoadonxuat' table. You can move, or remove it, as needed.
            hienthi();
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.quanli_hieuthuocDataSet1.thuoc);

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                hoadonxuat n = new hoadonxuat();
                n.sochungtuxuat = sochungtuxuatTextBox.Text;
                n.manhanvien = manhanvienTextBox.Text;
                n.ngaygioxuat = ngaygioxuatDateTimePicker.Value.ToString("yyyy-MM-dd");
                
                n.tongtienban = 0;
                data.themhoadonxuat(n);
                hienthi();
                xoa1();
                lb_thongbao1.Text = "Thêm hoá đơn xuất thành công!!!";
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
                hoadonxuat n = new hoadonxuat();
                n.sochungtuxuat = sochungtuxuatTextBox.Text;
                n.manhanvien = manhanvienTextBox.Text;
                n.ngaygioxuat = ngaygioxuatDateTimePicker.Text;

                n.tongtienban = 0;
                data.capnhathoadonxuat(n);
                hienthi();
                xoa1();
                lb_thongbao1.Text = "Sửa hoá đơn xuất thành công!!!";
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
                hoadonxuat n = new hoadonxuat();
                string sochungtuxuat = sochungtuxuatTextBox.Text;
                data.xoahoadonxuat(sochungtuxuat);

                lb_thongbao1.Text = "Xoá hoá đơn xuất thành công!!!";
                hienthi();
                xoa1();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo");
            }
        }

        private void btn_them1_Click(object sender, EventArgs e)
        {
            try
            {
                chitiethoadonxuat n = new chitiethoadonxuat();
                n.sochungtuxuat = sochungtuxuatTextBox1.Text;
                n.mathuoc = mathuocTextBox.Text;
                n.dongiaban = Convert.ToInt32(dongiabanTextBox.Text);
                n.soluongxuat = Convert.ToInt32(soluongxuatTextBox.Text);
                data.themchitiethoadonxuat(n);
                hienthi1();
                hienthi();
                xoa2();
                lb_thongbao2.Text = "Thêm chi tiết hoá đơn xuất thành công!!!";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo");
            }
        }

        private void btn_sua1_Click(object sender, EventArgs e)
        {
            try
            {
                chitiethoadonxuat n = new chitiethoadonxuat();
                n.sochungtuxuat = sochungtuxuatTextBox1.Text;
                n.mathuoc = mathuocTextBox.Text;
                n.dongiaban = Convert.ToInt32(dongiabanTextBox.Text);
                n.soluongxuat = Convert.ToInt32(soluongxuatTextBox.Text);
                data.capnhatchitiethoadonxuat(n);
                hienthi1();
                hienthi();
                xoa2();
                lb_thongbao2.Text = "Sửa chi tiết hoá đơn xuất thành công!!!";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo");
            }
        }

        private void btn_xoa1_Click(object sender, EventArgs e)
        {
            try
            {
                chitiethoadonxuat n = new chitiethoadonxuat();
                string sochungtuxuat = sochungtuxuatTextBox1.Text;
                data.xoachitiethoadonxuat(sochungtuxuat);

                lb_thongbao2.Text = "Xoá chi tiết hoá đơn xuất thành công!!!";
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
            sochungtuxuatTextBox.Text = "";
            manhanvienTextBox.Text = "";
            ngaygioxuatDateTimePicker.Text = "";
            sochungtuxuatTextBox.Focus();
        }
        private void xoa2()
        {
            sochungtuxuatTextBox1.Text="";
            mathuocTextBox.Text= "";
            dongiabanTextBox.Text = "";
            soluongxuatTextBox.Text = "";
            sochungtuxuatTextBox1.Focus();
        }
    }
}
