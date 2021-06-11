
namespace hieuthuoc
{
    partial class baocaodoanhthu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baocaodoanhthu));
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_xembaocao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hoadonnhapDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoadonnhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanli_hieuthuocDataSet1 = new hieuthuoc.quanli_hieuthuocDataSet1();
            this.hoadonnhapTableAdapter = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.hoadonnhapTableAdapter();
            this.tableAdapterManager = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager();
            this.hoadonxuatTableAdapter = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.hoadonxuatTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_giatrixuat = new System.Windows.Forms.Label();
            this.lb_hoadonxuat = new System.Windows.Forms.Label();
            this.lb_giatrinhap = new System.Windows.Forms.Label();
            this.lb_hoadonnhap = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hoadonxuatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoadonxuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_tungay = new System.Windows.Forms.DateTimePicker();
            this.txt_denngay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonnhapDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonnhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonxuatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonxuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(1397, 27);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(114, 37);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_denngay);
            this.groupBox1.Controls.Add(this.txt_tungay);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_xembaocao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn khoảng thời gian";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(278, 208);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(137, 43);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_xembaocao
            // 
            this.btn_xembaocao.Location = new System.Drawing.Point(70, 208);
            this.btn_xembaocao.Name = "btn_xembaocao";
            this.btn_xembaocao.Size = new System.Drawing.Size(137, 43);
            this.btn_xembaocao.TabIndex = 2;
            this.btn_xembaocao.Text = "Xem báo cáo";
            this.btn_xembaocao.UseVisualStyleBackColor = true;
            this.btn_xembaocao.Click += new System.EventHandler(this.btn_xembaocao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hoadonnhapDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(561, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(947, 290);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hoá đơn nhập thuốc trong thời gian trên";
            // 
            // hoadonnhapDataGridView
            // 
            this.hoadonnhapDataGridView.AutoGenerateColumns = false;
            this.hoadonnhapDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hoadonnhapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoadonnhapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hoadonnhapDataGridView.DataSource = this.hoadonnhapBindingSource;
            this.hoadonnhapDataGridView.Location = new System.Drawing.Point(0, 31);
            this.hoadonnhapDataGridView.Name = "hoadonnhapDataGridView";
            this.hoadonnhapDataGridView.RowHeadersWidth = 51;
            this.hoadonnhapDataGridView.RowTemplate.Height = 24;
            this.hoadonnhapDataGridView.Size = new System.Drawing.Size(941, 253);
            this.hoadonnhapDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sochungtunhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số chứng từ nhập";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "manhanvien";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ngaygionhap";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày giờ nhập";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tennhacungcap";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên nhà cung cấp";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tongtiennhap";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tổng tiền nhập";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // hoadonnhapBindingSource
            // 
            this.hoadonnhapBindingSource.DataMember = "hoadonnhap";
            this.hoadonnhapBindingSource.DataSource = this.quanli_hieuthuocDataSet1;
            // 
            // quanli_hieuthuocDataSet1
            // 
            this.quanli_hieuthuocDataSet1.DataSetName = "quanli_hieuthuocDataSet1";
            this.quanli_hieuthuocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoadonnhapTableAdapter
            // 
            this.hoadonnhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chitiethoadonnhapTableAdapter = null;
            this.tableAdapterManager.chitiethoadonxuatTableAdapter = null;
            this.tableAdapterManager.hoadonnhapTableAdapter = this.hoadonnhapTableAdapter;
            this.tableAdapterManager.hoadonxuatTableAdapter = this.hoadonxuatTableAdapter;
            this.tableAdapterManager.nhanvienTableAdapter = null;
            this.tableAdapterManager.nhomthuocTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hoadonxuatTableAdapter
            // 
            this.hoadonxuatTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lb_giatrixuat);
            this.groupBox3.Controls.Add(this.lb_hoadonxuat);
            this.groupBox3.Controls.Add(this.lb_giatrinhap);
            this.groupBox3.Controls.Add(this.lb_hoadonnhap);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(29, 470);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 336);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin về báo cáo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "VNĐ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "hoá đơn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "hoá đơn";
            // 
            // lb_giatrixuat
            // 
            this.lb_giatrixuat.AutoSize = true;
            this.lb_giatrixuat.ForeColor = System.Drawing.Color.Red;
            this.lb_giatrixuat.Location = new System.Drawing.Point(201, 235);
            this.lb_giatrixuat.Name = "lb_giatrixuat";
            this.lb_giatrixuat.Size = new System.Drawing.Size(0, 25);
            this.lb_giatrixuat.TabIndex = 1;
            // 
            // lb_hoadonxuat
            // 
            this.lb_hoadonxuat.AutoSize = true;
            this.lb_hoadonxuat.ForeColor = System.Drawing.Color.Red;
            this.lb_hoadonxuat.Location = new System.Drawing.Point(201, 179);
            this.lb_hoadonxuat.Name = "lb_hoadonxuat";
            this.lb_hoadonxuat.Size = new System.Drawing.Size(0, 25);
            this.lb_hoadonxuat.TabIndex = 1;
            // 
            // lb_giatrinhap
            // 
            this.lb_giatrinhap.AutoSize = true;
            this.lb_giatrinhap.ForeColor = System.Drawing.Color.Red;
            this.lb_giatrinhap.Location = new System.Drawing.Point(201, 123);
            this.lb_giatrinhap.Name = "lb_giatrinhap";
            this.lb_giatrinhap.Size = new System.Drawing.Size(0, 25);
            this.lb_giatrinhap.TabIndex = 1;
            // 
            // lb_hoadonnhap
            // 
            this.lb_hoadonnhap.AutoSize = true;
            this.lb_hoadonnhap.ForeColor = System.Drawing.Color.Red;
            this.lb_hoadonnhap.Location = new System.Drawing.Point(201, 67);
            this.lb_hoadonnhap.Name = "lb_hoadonnhap";
            this.lb_hoadonnhap.Size = new System.Drawing.Size(0, 25);
            this.lb_hoadonnhap.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng giá trị xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số hoá đơn xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng giá trị nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số hoá đơn nhập";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hoadonxuatDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(561, 470);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(941, 336);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách các hoá đơn xuất thuốc trong thời gian trên";
            // 
            // hoadonxuatDataGridView
            // 
            this.hoadonxuatDataGridView.AutoGenerateColumns = false;
            this.hoadonxuatDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hoadonxuatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoadonxuatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.hoadonxuatDataGridView.DataSource = this.hoadonxuatBindingSource;
            this.hoadonxuatDataGridView.Location = new System.Drawing.Point(4, 35);
            this.hoadonxuatDataGridView.Name = "hoadonxuatDataGridView";
            this.hoadonxuatDataGridView.RowHeadersWidth = 51;
            this.hoadonxuatDataGridView.RowTemplate.Height = 24;
            this.hoadonxuatDataGridView.Size = new System.Drawing.Size(931, 295);
            this.hoadonxuatDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sochungtuxuat";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số chứng từ xuất";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "manhanvien";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ngaygioxuat";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ngày giờ xuất";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tongtienban";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tổng tiền bán";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // hoadonxuatBindingSource
            // 
            this.hoadonxuatBindingSource.DataMember = "hoadonxuat";
            this.hoadonxuatBindingSource.DataSource = this.quanli_hieuthuocDataSet1;
            // 
            // txt_tungay
            // 
            this.txt_tungay.Location = new System.Drawing.Point(142, 54);
            this.txt_tungay.Name = "txt_tungay";
            this.txt_tungay.Size = new System.Drawing.Size(319, 30);
            this.txt_tungay.TabIndex = 3;
            // 
            // txt_denngay
            // 
            this.txt_denngay.Location = new System.Drawing.Point(142, 112);
            this.txt_denngay.Name = "txt_denngay";
            this.txt_denngay.Size = new System.Drawing.Size(319, 30);
            this.txt_denngay.TabIndex = 3;
            // 
            // baocaodoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1520, 818);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "baocaodoanhthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.baocaodoanhthu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hoadonnhapDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonnhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hoadonxuatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonxuatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_xembaocao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private quanli_hieuthuocDataSet1 quanli_hieuthuocDataSet1;
        private System.Windows.Forms.BindingSource hoadonnhapBindingSource;
        private quanli_hieuthuocDataSet1TableAdapters.hoadonnhapTableAdapter hoadonnhapTableAdapter;
        private quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView hoadonnhapDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private quanli_hieuthuocDataSet1TableAdapters.hoadonxuatTableAdapter hoadonxuatTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_giatrixuat;
        private System.Windows.Forms.Label lb_hoadonxuat;
        private System.Windows.Forms.Label lb_giatrinhap;
        private System.Windows.Forms.Label lb_hoadonnhap;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource hoadonxuatBindingSource;
        private System.Windows.Forms.DataGridView hoadonxuatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DateTimePicker txt_denngay;
        private System.Windows.Forms.DateTimePicker txt_tungay;
    }
}