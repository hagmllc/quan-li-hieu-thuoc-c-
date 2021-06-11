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
    public partial class danhsachthuoc : Form
    {
        public danhsachthuoc()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_chinh n = new menu_chinh();
            n.ShowDialog();
        }

        private void thuocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.thuocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanli_hieuthuocDataSet1);

        }

        private void danhsachthuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.nhomthuoc' table. You can move, or remove it, as needed.
            this.nhomthuocTableAdapter.Fill(this.quanli_hieuthuocDataSet1.nhomthuoc);
            // TODO: This line of code loads data into the 'quanli_hieuthuocDataSet1.thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.quanli_hieuthuocDataSet1.thuoc);

        }
        datatil data = new datatil();
        private void hienthi()
        {
            try
            {
                thuocDataGridView1.DataSource = data.thuoc();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi" + ex.Message, "Thông báo");
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tim = txt_noidung.Text;
            if (cb_dmtimkiem.Text == "Theo mã thuốc")
            {
                if (!string.IsNullOrEmpty(tim))/*nếu trống rỗng*/
                {
                    DataTable table = data.Findthuoc(tim);
                    thuocDataGridView1.DataSource = table;

                }
                else
                {
                    hienthi();
                }
            }
            if (cb_dmtimkiem.Text == "Theo mã nhóm")
            {
                if (!string.IsNullOrEmpty(tim))/*nếu trống rỗng*/
                {
                    DataTable table = data.Findthuoctheomanhom(tim);
                    thuocDataGridView1.DataSource = table;

                }
                else
                {
                    hienthi();
                }
            }
            if (cb_dmtimkiem.Text == "Theo tên thuốc")
            {
                if (!string.IsNullOrEmpty(tim))/*nếu trống rỗng*/
                {
                    DataTable table = data.Findthuoctheoten(tim);
                    thuocDataGridView1.DataSource = table;

                }
                else
                {
                    hienthi();
                }
            }
            if (cb_dmtimkiem.Text == "Theo công dụng")
            {
                if (!string.IsNullOrEmpty(tim))/*nếu trống rỗng*/
                {
                    DataTable table = data.Findthuoctheocongdung(tim);
                    thuocDataGridView1.DataSource = table;

                }
                else
                {
                    hienthi();
                }
            }
            if (cb_dmtimkiem.Text == "Theo thành phần")
            {
                if (!string.IsNullOrEmpty(tim))/*nếu trống rỗng*/
                {
                    DataTable table = data.Findthuoctheothanhphan(tim);
                    thuocDataGridView1.DataSource = table;

                }
                else
                {
                    hienthi();
                }
            }
        }
    }
}
