
namespace hieuthuoc
{
    partial class danhsachhoadonnhap
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
            System.Windows.Forms.Label mathuocLabel;
            System.Windows.Forms.Label dongiavonLabel;
            System.Windows.Forms.Label soluongnhapLabel;
            System.Windows.Forms.Label sochungtunhapLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(danhsachhoadonnhap));
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hoadonnhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanli_hieuthuocDataSet1 = new hieuthuoc.quanli_hieuthuocDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chitiethoadonnhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chitiethoadonnhapDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoadonnhapTableAdapter = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.hoadonnhapTableAdapter();
            this.tableAdapterManager = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager();
            this.chitiethoadonnhapTableAdapter = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.chitiethoadonnhapTableAdapter();
            this.txt_soctnhap = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoadonnhapDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            mathuocLabel = new System.Windows.Forms.Label();
            dongiavonLabel = new System.Windows.Forms.Label();
            soluongnhapLabel = new System.Windows.Forms.Label();
            sochungtunhapLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonnhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadonnhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadonnhapDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonnhapDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mathuocLabel
            // 
            mathuocLabel.AutoSize = true;
            mathuocLabel.Location = new System.Drawing.Point(36, 97);
            mathuocLabel.Name = "mathuocLabel";
            mathuocLabel.Size = new System.Drawing.Size(93, 25);
            mathuocLabel.TabIndex = 3;
            mathuocLabel.Text = "Mã thuốc";
            // 
            // dongiavonLabel
            // 
            dongiavonLabel.AutoSize = true;
            dongiavonLabel.Location = new System.Drawing.Point(36, 144);
            dongiavonLabel.Name = "dongiavonLabel";
            dongiavonLabel.Size = new System.Drawing.Size(116, 25);
            dongiavonLabel.TabIndex = 5;
            dongiavonLabel.Text = "Đơn giá vốn";
            // 
            // soluongnhapLabel
            // 
            soluongnhapLabel.AutoSize = true;
            soluongnhapLabel.Location = new System.Drawing.Point(36, 191);
            soluongnhapLabel.Name = "soluongnhapLabel";
            soluongnhapLabel.Size = new System.Drawing.Size(139, 25);
            soluongnhapLabel.TabIndex = 7;
            soluongnhapLabel.Text = "Số lượng nhập";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(1396, 12);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(111, 39);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH HOÁ ĐƠN NHẬP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hoadonnhapDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 636);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hoá đơn nhập";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.txt_soctnhap);
            this.groupBox2.Controls.Add(sochungtunhapLabel);
            this.groupBox2.Controls.Add(soluongnhapLabel);
            this.groupBox2.Controls.Add(dongiavonLabel);
            this.groupBox2.Controls.Add(mathuocLabel);
            this.groupBox2.Controls.Add(this.chitiethoadonnhapDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(793, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 636);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hoá đơn nhập";
            // 
            // chitiethoadonnhapBindingSource
            // 
            this.chitiethoadonnhapBindingSource.DataMember = "chitiethoadonnhap";
            this.chitiethoadonnhapBindingSource.DataSource = this.quanli_hieuthuocDataSet1;
            // 
            // chitiethoadonnhapDataGridView
            // 
            this.chitiethoadonnhapDataGridView.AutoGenerateColumns = false;
            this.chitiethoadonnhapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chitiethoadonnhapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.chitiethoadonnhapDataGridView.DataSource = this.chitiethoadonnhapBindingSource;
            this.chitiethoadonnhapDataGridView.Location = new System.Drawing.Point(6, 252);
            this.chitiethoadonnhapDataGridView.Name = "chitiethoadonnhapDataGridView";
            this.chitiethoadonnhapDataGridView.RowHeadersWidth = 51;
            this.chitiethoadonnhapDataGridView.RowTemplate.Height = 24;
            this.chitiethoadonnhapDataGridView.Size = new System.Drawing.Size(702, 364);
            this.chitiethoadonnhapDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sochungtunhap";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số chứng từ nhập";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 170;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "mathuoc";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã thuốc";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 170;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dongiavon";
            this.dataGridViewTextBoxColumn8.HeaderText = "Đơn giá vốn";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "soluongnhap";
            this.dataGridViewTextBoxColumn9.HeaderText = "Số lượng nhập";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // hoadonnhapTableAdapter
            // 
            this.hoadonnhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chitiethoadonnhapTableAdapter = this.chitiethoadonnhapTableAdapter;
            this.tableAdapterManager.chitiethoadonxuatTableAdapter = null;
            this.tableAdapterManager.hoadonnhapTableAdapter = this.hoadonnhapTableAdapter;
            this.tableAdapterManager.hoadonxuatTableAdapter = null;
            this.tableAdapterManager.nhanvienTableAdapter = null;
            this.tableAdapterManager.nhomthuocTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chitiethoadonnhapTableAdapter
            // 
            this.chitiethoadonnhapTableAdapter.ClearBeforeFill = true;
            // 
            // sochungtunhapLabel
            // 
            sochungtunhapLabel.AutoSize = true;
            sochungtunhapLabel.Location = new System.Drawing.Point(36, 40);
            sochungtunhapLabel.Name = "sochungtunhapLabel";
            sochungtunhapLabel.Size = new System.Drawing.Size(166, 25);
            sochungtunhapLabel.TabIndex = 8;
            sochungtunhapLabel.Text = "Số chứng từ nhập";
            // 
            // txt_soctnhap
            // 
            this.txt_soctnhap.Location = new System.Drawing.Point(209, 40);
            this.txt_soctnhap.Name = "txt_soctnhap";
            this.txt_soctnhap.Size = new System.Drawing.Size(346, 30);
            this.txt_soctnhap.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tongtiennhap";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tổng tiền nhập";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tennhacungcap";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên nhà cung cấp";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ngaygionhap";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày giờ nhập";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "manhanvien";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sochungtunhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số chứng từ nhập";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // hoadonnhapDataGridView
            // 
            this.hoadonnhapDataGridView.AutoGenerateColumns = false;
            this.hoadonnhapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoadonnhapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hoadonnhapDataGridView.DataSource = this.hoadonnhapBindingSource;
            this.hoadonnhapDataGridView.Location = new System.Drawing.Point(6, 40);
            this.hoadonnhapDataGridView.Name = "hoadonnhapDataGridView";
            this.hoadonnhapDataGridView.RowHeadersWidth = 51;
            this.hoadonnhapDataGridView.RowTemplate.Height = 24;
            this.hoadonnhapDataGridView.Size = new System.Drawing.Size(702, 576);
            this.hoadonnhapDataGridView.TabIndex = 0;
            this.hoadonnhapDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hoadonnhapDataGridView_CellClick);
            this.hoadonnhapDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hoadonnhapDataGridView_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 30);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(346, 30);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(209, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(346, 30);
            this.textBox3.TabIndex = 9;
            // 
            // danhsachhoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1559, 804);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "danhsachhoadonnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hoá đơn nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.danhsachhoadonnhap_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hoadonnhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadonnhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadonnhapDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonnhapDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private quanli_hieuthuocDataSet1 quanli_hieuthuocDataSet1;
        private System.Windows.Forms.BindingSource hoadonnhapBindingSource;
        private quanli_hieuthuocDataSet1TableAdapters.hoadonnhapTableAdapter hoadonnhapTableAdapter;
        private quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private quanli_hieuthuocDataSet1TableAdapters.chitiethoadonnhapTableAdapter chitiethoadonnhapTableAdapter;
        private System.Windows.Forms.BindingSource chitiethoadonnhapBindingSource;
        private System.Windows.Forms.DataGridView chitiethoadonnhapDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox txt_soctnhap;
        private System.Windows.Forms.DataGridView hoadonnhapDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}