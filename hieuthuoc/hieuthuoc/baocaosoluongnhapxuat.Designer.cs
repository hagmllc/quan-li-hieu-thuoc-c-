
namespace hieuthuoc
{
    partial class baocaosoluongnhapxuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baocaosoluongnhapxuat));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_xembaocao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.data_dsthuocnhap = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_luongban = new System.Windows.Forms.Label();
            this.lb_luongnhap = new System.Windows.Forms.Label();
            this.lb_lanban = new System.Windows.Forms.Label();
            this.lb_lannhap = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.data_dsthuocxuat = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_dsthuocnhap)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_dsthuocxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO SỐ LƯỢNG NHẬP XUẤT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btn_xembaocao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 303);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn khoảng thời gian";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(122, 148);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(306, 30);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btn_xembaocao
            // 
            this.btn_xembaocao.Location = new System.Drawing.Point(135, 205);
            this.btn_xembaocao.Name = "btn_xembaocao";
            this.btn_xembaocao.Size = new System.Drawing.Size(162, 52);
            this.btn_xembaocao.TabIndex = 1;
            this.btn_xembaocao.Text = "Xem báo cáo";
            this.btn_xembaocao.UseVisualStyleBackColor = true;
            this.btn_xembaocao.Click += new System.EventHandler(this.btn_xembaocao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data_dsthuocnhap);
            this.groupBox2.Location = new System.Drawing.Point(536, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(967, 303);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thuốc nhập trong thời gian trên";
            // 
            // data_dsthuocnhap
            // 
            this.data_dsthuocnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_dsthuocnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dsthuocnhap.Location = new System.Drawing.Point(0, 30);
            this.data_dsthuocnhap.Name = "data_dsthuocnhap";
            this.data_dsthuocnhap.RowHeadersWidth = 51;
            this.data_dsthuocnhap.RowTemplate.Height = 24;
            this.data_dsthuocnhap.Size = new System.Drawing.Size(961, 267);
            this.data_dsthuocnhap.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_luongban);
            this.groupBox3.Controls.Add(this.lb_luongnhap);
            this.groupBox3.Controls.Add(this.lb_lanban);
            this.groupBox3.Controls.Add(this.lb_lannhap);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(32, 507);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 396);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Báo cáo";
            // 
            // lb_luongban
            // 
            this.lb_luongban.AutoSize = true;
            this.lb_luongban.ForeColor = System.Drawing.Color.Red;
            this.lb_luongban.Location = new System.Drawing.Point(197, 287);
            this.lb_luongban.Name = "lb_luongban";
            this.lb_luongban.Size = new System.Drawing.Size(0, 25);
            this.lb_luongban.TabIndex = 8;
            // 
            // lb_luongnhap
            // 
            this.lb_luongnhap.AutoSize = true;
            this.lb_luongnhap.ForeColor = System.Drawing.Color.Red;
            this.lb_luongnhap.Location = new System.Drawing.Point(210, 155);
            this.lb_luongnhap.Name = "lb_luongnhap";
            this.lb_luongnhap.Size = new System.Drawing.Size(0, 25);
            this.lb_luongnhap.TabIndex = 8;
            // 
            // lb_lanban
            // 
            this.lb_lanban.AutoSize = true;
            this.lb_lanban.ForeColor = System.Drawing.Color.Red;
            this.lb_lanban.Location = new System.Drawing.Point(160, 221);
            this.lb_lanban.Name = "lb_lanban";
            this.lb_lanban.Size = new System.Drawing.Size(0, 25);
            this.lb_lanban.TabIndex = 8;
            // 
            // lb_lannhap
            // 
            this.lb_lannhap.AutoSize = true;
            this.lb_lannhap.ForeColor = System.Drawing.Color.Red;
            this.lb_lannhap.Location = new System.Drawing.Point(195, 89);
            this.lb_lannhap.Name = "lb_lannhap";
            this.lb_lannhap.Size = new System.Drawing.Size(0, 25);
            this.lb_lannhap.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(343, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "VNĐ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Lần";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Lần";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tổng số lượng bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số lần bán ra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng số lượng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lần nhập vào\r\n";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.data_dsthuocxuat);
            this.groupBox4.Location = new System.Drawing.Point(536, 507);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(961, 396);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách thuốc xuất trong thời gian trên";
            // 
            // data_dsthuocxuat
            // 
            this.data_dsthuocxuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_dsthuocxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dsthuocxuat.Location = new System.Drawing.Point(0, 42);
            this.data_dsthuocxuat.Name = "data_dsthuocxuat";
            this.data_dsthuocxuat.RowHeadersWidth = 51;
            this.data_dsthuocxuat.RowTemplate.Height = 24;
            this.data_dsthuocxuat.Size = new System.Drawing.Size(955, 348);
            this.data_dsthuocxuat.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(1367, 26);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(130, 39);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // baocaosoluongnhapxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1541, 928);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "baocaosoluongnhapxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo số lượng nhập xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_dsthuocnhap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_dsthuocxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_xembaocao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView data_dsthuocnhap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_luongban;
        private System.Windows.Forms.Label lb_luongnhap;
        private System.Windows.Forms.Label lb_lanban;
        private System.Windows.Forms.Label lb_lannhap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView data_dsthuocxuat;
        private System.Windows.Forms.Button btn_thoat;
    }
}