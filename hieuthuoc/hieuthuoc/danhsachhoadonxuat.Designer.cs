
namespace hieuthuoc
{
    partial class danhsachhoadonxuat
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
            System.Windows.Forms.Label sochungtuxuatLabel;
            System.Windows.Forms.Label mathuocLabel;
            System.Windows.Forms.Label dongiabanLabel;
            System.Windows.Forms.Label soluongxuatLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(danhsachhoadonxuat));
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.quanli_hieuthuocDataSet1 = new hieuthuoc.quanli_hieuthuocDataSet1();
            this.hoadonxuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoadonxuatTableAdapter = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.hoadonxuatTableAdapter();
            this.tableAdapterManager = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager();
            this.hoadonxuatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sochungtuxuatTextBox = new System.Windows.Forms.TextBox();
            this.chitiethoadonxuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chitiethoadonxuatTableAdapter = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.chitiethoadonxuatTableAdapter();
            this.chitiethoadonxuatDataGridView = new System.Windows.Forms.DataGridView();
            this.mathuocTextBox = new System.Windows.Forms.TextBox();
            this.dongiabanTextBox = new System.Windows.Forms.TextBox();
            this.soluongxuatTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sochungtuxuatLabel = new System.Windows.Forms.Label();
            mathuocLabel = new System.Windows.Forms.Label();
            dongiabanLabel = new System.Windows.Forms.Label();
            soluongxuatLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonxuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonxuatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadonxuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadonxuatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(1414, 32);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(96, 37);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH HOÁ ĐƠN XUẤT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hoadonxuatDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(13, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 600);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hoá đơn xuất";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(soluongxuatLabel);
            this.groupBox2.Controls.Add(this.soluongxuatTextBox);
            this.groupBox2.Controls.Add(dongiabanLabel);
            this.groupBox2.Controls.Add(this.dongiabanTextBox);
            this.groupBox2.Controls.Add(mathuocLabel);
            this.groupBox2.Controls.Add(this.mathuocTextBox);
            this.groupBox2.Controls.Add(this.chitiethoadonxuatDataGridView);
            this.groupBox2.Controls.Add(sochungtuxuatLabel);
            this.groupBox2.Controls.Add(this.sochungtuxuatTextBox);
            this.groupBox2.Location = new System.Drawing.Point(798, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 600);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hoá đơn xuất";
            // 
            // quanli_hieuthuocDataSet1
            // 
            this.quanli_hieuthuocDataSet1.DataSetName = "quanli_hieuthuocDataSet1";
            this.quanli_hieuthuocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoadonxuatBindingSource
            // 
            this.hoadonxuatBindingSource.DataMember = "hoadonxuat";
            this.hoadonxuatBindingSource.DataSource = this.quanli_hieuthuocDataSet1;
            // 
            // hoadonxuatTableAdapter
            // 
            this.hoadonxuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chitiethoadonnhapTableAdapter = null;
            this.tableAdapterManager.chitiethoadonxuatTableAdapter = this.chitiethoadonxuatTableAdapter;
            this.tableAdapterManager.hoadonnhapTableAdapter = null;
            this.tableAdapterManager.hoadonxuatTableAdapter = this.hoadonxuatTableAdapter;
            this.tableAdapterManager.nhanvienTableAdapter = null;
            this.tableAdapterManager.nhomthuocTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hoadonxuatDataGridView
            // 
            this.hoadonxuatDataGridView.AutoGenerateColumns = false;
            this.hoadonxuatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoadonxuatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.hoadonxuatDataGridView.DataSource = this.hoadonxuatBindingSource;
            this.hoadonxuatDataGridView.Location = new System.Drawing.Point(13, 41);
            this.hoadonxuatDataGridView.Name = "hoadonxuatDataGridView";
            this.hoadonxuatDataGridView.RowHeadersWidth = 51;
            this.hoadonxuatDataGridView.RowTemplate.Height = 24;
            this.hoadonxuatDataGridView.Size = new System.Drawing.Size(678, 553);
            this.hoadonxuatDataGridView.TabIndex = 0;
            this.hoadonxuatDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hoadonxuatDataGridView_CellClick);
            this.hoadonxuatDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hoadonxuatDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sochungtuxuat";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số chứng từ xuất";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 170;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "manhanvien";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ngaygioxuat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày giờ xuất";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tongtienban";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tổng tiền bán";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // sochungtuxuatLabel
            // 
            sochungtuxuatLabel.AutoSize = true;
            sochungtuxuatLabel.Location = new System.Drawing.Point(32, 59);
            sochungtuxuatLabel.Name = "sochungtuxuatLabel";
            sochungtuxuatLabel.Size = new System.Drawing.Size(159, 25);
            sochungtuxuatLabel.TabIndex = 0;
            sochungtuxuatLabel.Text = "Số chứng từ xuất";
            // 
            // sochungtuxuatTextBox
            // 
            this.sochungtuxuatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoadonxuatBindingSource, "sochungtuxuat", true));
            this.sochungtuxuatTextBox.Location = new System.Drawing.Point(215, 56);
            this.sochungtuxuatTextBox.Name = "sochungtuxuatTextBox";
            this.sochungtuxuatTextBox.Size = new System.Drawing.Size(468, 30);
            this.sochungtuxuatTextBox.TabIndex = 1;
            // 
            // chitiethoadonxuatBindingSource
            // 
            this.chitiethoadonxuatBindingSource.DataMember = "chitiethoadonxuat";
            this.chitiethoadonxuatBindingSource.DataSource = this.quanli_hieuthuocDataSet1;
            // 
            // chitiethoadonxuatTableAdapter
            // 
            this.chitiethoadonxuatTableAdapter.ClearBeforeFill = true;
            // 
            // chitiethoadonxuatDataGridView
            // 
            this.chitiethoadonxuatDataGridView.AutoGenerateColumns = false;
            this.chitiethoadonxuatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chitiethoadonxuatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.chitiethoadonxuatDataGridView.DataSource = this.chitiethoadonxuatBindingSource;
            this.chitiethoadonxuatDataGridView.Location = new System.Drawing.Point(5, 252);
            this.chitiethoadonxuatDataGridView.Name = "chitiethoadonxuatDataGridView";
            this.chitiethoadonxuatDataGridView.RowHeadersWidth = 51;
            this.chitiethoadonxuatDataGridView.RowTemplate.Height = 24;
            this.chitiethoadonxuatDataGridView.Size = new System.Drawing.Size(692, 220);
            this.chitiethoadonxuatDataGridView.TabIndex = 2;
            // 
            // mathuocLabel
            // 
            mathuocLabel.AutoSize = true;
            mathuocLabel.Location = new System.Drawing.Point(32, 99);
            mathuocLabel.Name = "mathuocLabel";
            mathuocLabel.Size = new System.Drawing.Size(93, 25);
            mathuocLabel.TabIndex = 3;
            mathuocLabel.Text = "Mã thuốc";
            // 
            // mathuocTextBox
            // 
            this.mathuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chitiethoadonxuatBindingSource, "mathuoc", true));
            this.mathuocTextBox.Location = new System.Drawing.Point(215, 96);
            this.mathuocTextBox.Name = "mathuocTextBox";
            this.mathuocTextBox.Size = new System.Drawing.Size(468, 30);
            this.mathuocTextBox.TabIndex = 4;
            // 
            // dongiabanLabel
            // 
            dongiabanLabel.AutoSize = true;
            dongiabanLabel.Location = new System.Drawing.Point(32, 139);
            dongiabanLabel.Name = "dongiabanLabel";
            dongiabanLabel.Size = new System.Drawing.Size(117, 25);
            dongiabanLabel.TabIndex = 5;
            dongiabanLabel.Text = "Đơn giá bán";
            // 
            // dongiabanTextBox
            // 
            this.dongiabanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chitiethoadonxuatBindingSource, "dongiaban", true));
            this.dongiabanTextBox.Location = new System.Drawing.Point(215, 136);
            this.dongiabanTextBox.Name = "dongiabanTextBox";
            this.dongiabanTextBox.Size = new System.Drawing.Size(468, 30);
            this.dongiabanTextBox.TabIndex = 6;
            // 
            // soluongxuatLabel
            // 
            soluongxuatLabel.AutoSize = true;
            soluongxuatLabel.Location = new System.Drawing.Point(32, 179);
            soluongxuatLabel.Name = "soluongxuatLabel";
            soluongxuatLabel.Size = new System.Drawing.Size(132, 25);
            soluongxuatLabel.TabIndex = 7;
            soluongxuatLabel.Text = "Số lượng xuất";
            // 
            // soluongxuatTextBox
            // 
            this.soluongxuatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chitiethoadonxuatBindingSource, "soluongxuat", true));
            this.soluongxuatTextBox.Location = new System.Drawing.Point(215, 176);
            this.soluongxuatTextBox.Name = "soluongxuatTextBox";
            this.soluongxuatTextBox.Size = new System.Drawing.Size(468, 30);
            this.soluongxuatTextBox.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "mathuoc";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã thuốc";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "dongiaban";
            this.dataGridViewTextBoxColumn7.HeaderText = "Đơn giá bán";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 230;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "soluongxuat";
            this.dataGridViewTextBoxColumn8.HeaderText = "Số lượng xuất";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // danhsachhoadonxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1536, 747);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "danhsachhoadonxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hoá đơn xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.danhsachhoadonxuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonxuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonxuatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadonxuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadonxuatDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private quanli_hieuthuocDataSet1 quanli_hieuthuocDataSet1;
        private System.Windows.Forms.BindingSource hoadonxuatBindingSource;
        private quanli_hieuthuocDataSet1TableAdapters.hoadonxuatTableAdapter hoadonxuatTableAdapter;
        private quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView hoadonxuatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox sochungtuxuatTextBox;
        private quanli_hieuthuocDataSet1TableAdapters.chitiethoadonxuatTableAdapter chitiethoadonxuatTableAdapter;
        private System.Windows.Forms.BindingSource chitiethoadonxuatBindingSource;
        private System.Windows.Forms.DataGridView chitiethoadonxuatDataGridView;
        private System.Windows.Forms.TextBox soluongxuatTextBox;
        private System.Windows.Forms.TextBox dongiabanTextBox;
        private System.Windows.Forms.TextBox mathuocTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}