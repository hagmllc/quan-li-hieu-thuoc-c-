
namespace hieuthuoc
{
    partial class inhoadonxuatthuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inhoadonxuatthuoc));
            this.thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_in = new System.Windows.Forms.Button();
            this.lb_tonghoadon = new System.Windows.Forms.Label();
            this.lb_soluongthuoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_rs = new System.Windows.Forms.Button();
            this.btn_xemchitiet = new System.Windows.Forms.Button();
            this.txt_ctxuat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(1414, 36);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(95, 31);
            this.thoat.TabIndex = 0;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "IN THÔNG TIN HOÁ ĐƠN THUỐC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_in);
            this.groupBox1.Controls.Add(this.lb_tonghoadon);
            this.groupBox1.Controls.Add(this.lb_soluongthuoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_rs);
            this.groupBox1.Controls.Add(this.btn_xemchitiet);
            this.groupBox1.Controls.Add(this.txt_ctxuat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1478, 263);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(1006, 187);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(208, 50);
            this.btn_in.TabIndex = 5;
            this.btn_in.Text = "In hoá đơn";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // lb_tonghoadon
            // 
            this.lb_tonghoadon.AutoSize = true;
            this.lb_tonghoadon.ForeColor = System.Drawing.Color.Red;
            this.lb_tonghoadon.Location = new System.Drawing.Point(1001, 137);
            this.lb_tonghoadon.Name = "lb_tonghoadon";
            this.lb_tonghoadon.Size = new System.Drawing.Size(0, 25);
            this.lb_tonghoadon.TabIndex = 4;
            // 
            // lb_soluongthuoc
            // 
            this.lb_soluongthuoc.AutoSize = true;
            this.lb_soluongthuoc.ForeColor = System.Drawing.Color.Red;
            this.lb_soluongthuoc.Location = new System.Drawing.Point(959, 69);
            this.lb_soluongthuoc.Name = "lb_soluongthuoc";
            this.lb_soluongthuoc.Size = new System.Drawing.Size(0, 25);
            this.lb_soluongthuoc.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1175, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(810, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng giá trị hoá đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(810, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng thuốc";
            // 
            // btn_rs
            // 
            this.btn_rs.Location = new System.Drawing.Point(456, 158);
            this.btn_rs.Name = "btn_rs";
            this.btn_rs.Size = new System.Drawing.Size(138, 38);
            this.btn_rs.TabIndex = 2;
            this.btn_rs.Text = "Reset";
            this.btn_rs.UseVisualStyleBackColor = true;
            this.btn_rs.Click += new System.EventHandler(this.btn_rs_Click);
            // 
            // btn_xemchitiet
            // 
            this.btn_xemchitiet.Location = new System.Drawing.Point(153, 158);
            this.btn_xemchitiet.Name = "btn_xemchitiet";
            this.btn_xemchitiet.Size = new System.Drawing.Size(138, 38);
            this.btn_xemchitiet.TabIndex = 2;
            this.btn_xemchitiet.Text = "Xem chi tiết";
            this.btn_xemchitiet.UseVisualStyleBackColor = true;
            this.btn_xemchitiet.Click += new System.EventHandler(this.btn_xemchitiet_Click);
            // 
            // txt_ctxuat
            // 
            this.txt_ctxuat.Location = new System.Drawing.Point(223, 71);
            this.txt_ctxuat.Name = "txt_ctxuat";
            this.txt_ctxuat.Size = new System.Drawing.Size(418, 30);
            this.txt_ctxuat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số chứng từ xuất";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(31, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1478, 405);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hoá đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1465, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // inhoadonxuatthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1523, 917);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "inhoadonxuatthuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hoá đơn xuất thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_tonghoadon;
        private System.Windows.Forms.Label lb_soluongthuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_rs;
        private System.Windows.Forms.Button btn_xemchitiet;
        private System.Windows.Forms.TextBox txt_ctxuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}