
namespace hieuthuoc
{
    partial class danhsachthuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(danhsachthuoc));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quanli_hieuthuocDataSet1 = new hieuthuoc.quanli_hieuthuocDataSet1();
            this.thuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuocTableAdapter = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.thuocTableAdapter();
            this.tableAdapterManager = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager();
            this.thuocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nhomthuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomthuocTableAdapter = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.nhomthuocTableAdapter();
            this.nhomthuocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_dmtimkiem = new System.Windows.Forms.ComboBox();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.thuocDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomthuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomthuocDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuocDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(582, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH THUỐC";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(1408, 97);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(104, 36);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thuocDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(23, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1489, 350);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tất cả thuốc trong kho";
            // 
            // quanli_hieuthuocDataSet1
            // 
            this.quanli_hieuthuocDataSet1.DataSetName = "quanli_hieuthuocDataSet1";
            this.quanli_hieuthuocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuocBindingSource
            // 
            this.thuocBindingSource.DataMember = "thuoc";
            this.thuocBindingSource.DataSource = this.quanli_hieuthuocDataSet1;
            // 
            // thuocTableAdapter
            // 
            this.thuocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chitiethoadonnhapTableAdapter = null;
            this.tableAdapterManager.chitiethoadonxuatTableAdapter = null;
            this.tableAdapterManager.hoadonnhapTableAdapter = null;
            this.tableAdapterManager.hoadonxuatTableAdapter = null;
            this.tableAdapterManager.nhanvienTableAdapter = null;
            this.tableAdapterManager.nhomthuocTableAdapter = this.nhomthuocTableAdapter;
            this.tableAdapterManager.thuocTableAdapter = this.thuocTableAdapter;
            this.tableAdapterManager.UpdateOrder = hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // thuocDataGridView
            // 
            this.thuocDataGridView.AutoGenerateColumns = false;
            this.thuocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thuocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewImageColumn1});
            this.thuocDataGridView.DataSource = this.thuocBindingSource;
            this.thuocDataGridView.Location = new System.Drawing.Point(6, 26);
            this.thuocDataGridView.Name = "thuocDataGridView";
            this.thuocDataGridView.RowHeadersWidth = 51;
            this.thuocDataGridView.RowTemplate.Height = 24;
            this.thuocDataGridView.Size = new System.Drawing.Size(1477, 318);
            this.thuocDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mathuoc";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã thuốc";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "manhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã nhóm";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tenthuoc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên thuốc";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "congdung";
            this.dataGridViewTextBoxColumn4.HeaderText = "Công dụng";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "thanhphan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Thành phần";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "donvitinh";
            this.dataGridViewTextBoxColumn6.HeaderText = "Đơn vị tính";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "xuatxu";
            this.dataGridViewTextBoxColumn7.HeaderText = "Xuất xứ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "giaban";
            this.dataGridViewTextBoxColumn8.HeaderText = "Giá bán";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "soluong";
            this.dataGridViewTextBoxColumn9.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "hinhanh";
            this.dataGridViewImageColumn1.HeaderText = "Hình ảnh";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 140;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nhomthuocDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(29, 532);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 409);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các nhóm thuốc";
            // 
            // nhomthuocBindingSource
            // 
            this.nhomthuocBindingSource.DataMember = "nhomthuoc";
            this.nhomthuocBindingSource.DataSource = this.quanli_hieuthuocDataSet1;
            // 
            // nhomthuocTableAdapter
            // 
            this.nhomthuocTableAdapter.ClearBeforeFill = true;
            // 
            // nhomthuocDataGridView
            // 
            this.nhomthuocDataGridView.AutoGenerateColumns = false;
            this.nhomthuocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomthuocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.nhomthuocDataGridView.DataSource = this.nhomthuocBindingSource;
            this.nhomthuocDataGridView.Location = new System.Drawing.Point(6, 42);
            this.nhomthuocDataGridView.Name = "nhomthuocDataGridView";
            this.nhomthuocDataGridView.RowHeadersWidth = 51;
            this.nhomthuocDataGridView.RowTemplate.Height = 24;
            this.nhomthuocDataGridView.Size = new System.Drawing.Size(482, 361);
            this.nhomthuocDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "manhom";
            this.dataGridViewTextBoxColumn10.HeaderText = "Mã nhóm";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 170;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "tennhom";
            this.dataGridViewTextBoxColumn11.HeaderText = "Tên nhóm";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 250;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.thuocDataGridView1);
            this.groupBox3.Controls.Add(this.btn_timkiem);
            this.groupBox3.Controls.Add(this.txt_noidung);
            this.groupBox3.Controls.Add(this.cb_dmtimkiem);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(591, 532);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(915, 403);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh mục tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nội dung tìm kiếm";
            // 
            // cb_dmtimkiem
            // 
            this.cb_dmtimkiem.FormattingEnabled = true;
            this.cb_dmtimkiem.Items.AddRange(new object[] {
            "Theo mã thuốc",
            "Theo mã nhóm",
            "Theo tên thuốc",
            "Theo công dụng",
            "Theo thành phần"});
            this.cb_dmtimkiem.Location = new System.Drawing.Point(227, 39);
            this.cb_dmtimkiem.Name = "cb_dmtimkiem";
            this.cb_dmtimkiem.Size = new System.Drawing.Size(372, 28);
            this.cb_dmtimkiem.TabIndex = 1;
            // 
            // txt_noidung
            // 
            this.txt_noidung.Location = new System.Drawing.Point(227, 83);
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new System.Drawing.Size(372, 27);
            this.txt_noidung.TabIndex = 2;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(688, 57);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(166, 46);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // thuocDataGridView1
            // 
            this.thuocDataGridView1.AutoGenerateColumns = false;
            this.thuocDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thuocDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewImageColumn2});
            this.thuocDataGridView1.DataSource = this.thuocBindingSource;
            this.thuocDataGridView1.Location = new System.Drawing.Point(6, 118);
            this.thuocDataGridView1.Name = "thuocDataGridView1";
            this.thuocDataGridView1.RowHeadersWidth = 51;
            this.thuocDataGridView1.RowTemplate.Height = 24;
            this.thuocDataGridView1.Size = new System.Drawing.Size(903, 279);
            this.thuocDataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "mathuoc";
            this.dataGridViewTextBoxColumn12.HeaderText = "Mã thuốc";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "manhom";
            this.dataGridViewTextBoxColumn13.HeaderText = "Mã nhóm";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "tenthuoc";
            this.dataGridViewTextBoxColumn14.HeaderText = "Tên thuốc";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "congdung";
            this.dataGridViewTextBoxColumn15.HeaderText = "Công dụng";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "thanhphan";
            this.dataGridViewTextBoxColumn16.HeaderText = "Thành phần";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "donvitinh";
            this.dataGridViewTextBoxColumn17.HeaderText = "Đơn vị tính";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "xuatxu";
            this.dataGridViewTextBoxColumn18.HeaderText = "Xuất xứ";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "giaban";
            this.dataGridViewTextBoxColumn19.HeaderText = "Giá bán";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "soluong";
            this.dataGridViewTextBoxColumn20.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "hinhanh";
            this.dataGridViewImageColumn2.HeaderText = "Hình ảnh";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // danhsachthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1559, 953);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "danhsachthuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.danhsachthuoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuocDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhomthuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomthuocDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuocDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private quanli_hieuthuocDataSet1 quanli_hieuthuocDataSet1;
        private System.Windows.Forms.BindingSource thuocBindingSource;
        private quanli_hieuthuocDataSet1TableAdapters.thuocTableAdapter thuocTableAdapter;
        private quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView thuocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private quanli_hieuthuocDataSet1TableAdapters.nhomthuocTableAdapter nhomthuocTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource nhomthuocBindingSource;
        private System.Windows.Forms.DataGridView nhomthuocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView thuocDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_noidung;
        private System.Windows.Forms.ComboBox cb_dmtimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}