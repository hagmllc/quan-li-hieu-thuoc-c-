using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace hieuthuoc
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked = true)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_matkhau.Text = "";
            txt_tendangnhap.Text = "";
            txt_tendangnhap.Focus();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PHAMHAIANH\SQLEXPRESS;Initial Catalog=quanli_hieuthuoc;Integrated Security=True");

            try
            {
                //nếu chọn đăng nhập bằng admin thì check cả phân quyền
                if (cb_admin.Checked == true)
                {
                    conn.Open();
                    string SqlSelect = "Select * from nhanvien where tendangnhap = '" + txt_tendangnhap.Text + "'and matkhau = '" + txt_matkhau.Text + "'" + "and phanquyen = 'admin'";
                    SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        MessageBox.Show("Đăng nhập thành công dưới quyền admin, chuyển đến giao diện quản lí nhân viên", "Thông báo");
                        this.Hide();
                        admin n = new admin();
                        n.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn không đúng hoặc không có quyền truy cập", "Thông báo");
                    }

                }
                else
                {
                    conn.Open();
                    string SqlSelect = "Select * from nhanvien where tendangnhap = '" + txt_tendangnhap.Text + "'and matkhau = '" + txt_matkhau.Text + "'" ;
                    SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        MessageBox.Show("Đăng nhập thành công, chuyển đến giao diện quản lí thuốc", "Thông báo");
                        this.Hide();
                        menu_chinh n = new menu_chinh();
                        n.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn không đúng", "Thông báo");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo");
            }
        }

        private void dangnhap_DragEnter(object sender, DragEventArgs e)
        {
        }
    }
}
