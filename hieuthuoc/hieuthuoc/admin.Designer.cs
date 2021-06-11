
namespace hieuthuoc
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanli_hieuthuocDataSet = new hieuthuoc.quanli_hieuthuocDataSet();
            this.nhanvienTableAdapter = new hieuthuoc.quanli_hieuthuocDataSetTableAdapters.nhanvienTableAdapter();
            this.quanli_hieuthuocDataSet1 = new hieuthuoc.quanli_hieuthuocDataSet1();
            this.nhanvienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter1 = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.nhanvienTableAdapter();
            this.tableAdapterManager = new hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager();
            this.nhanvienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Location = new System.Drawing.Point(1393, 62);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(118, 38);
            this.btn_dangxuat.TabIndex = 0;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1531, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíThuốcToolStripMenuItem,
            this.thêmNhânViênToolStripMenuItem,
            this.sửaNhânViênToolStripMenuItem,
            this.xoáNhânViênToolStripMenuItem,
            this.xemChiTiếtToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(95, 33);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // quảnLíThuốcToolStripMenuItem
            // 
            this.quảnLíThuốcToolStripMenuItem.Name = "quảnLíThuốcToolStripMenuItem";
            this.quảnLíThuốcToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.quảnLíThuốcToolStripMenuItem.Text = "Quản lí thuốc";
            this.quảnLíThuốcToolStripMenuItem.Click += new System.EventHandler(this.quảnLíThuốcToolStripMenuItem_Click);
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            this.thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            this.thêmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.thêmNhânViênToolStripMenuItem.Text = "Thêm nhân viên";
            this.thêmNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thêmNhânViênToolStripMenuItem_Click);
            // 
            // sửaNhânViênToolStripMenuItem
            // 
            this.sửaNhânViênToolStripMenuItem.Name = "sửaNhânViênToolStripMenuItem";
            this.sửaNhânViênToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.sửaNhânViênToolStripMenuItem.Text = "Sửa nhân viên";
            this.sửaNhânViênToolStripMenuItem.Click += new System.EventHandler(this.sửaNhânViênToolStripMenuItem_Click);
            // 
            // xoáNhânViênToolStripMenuItem
            // 
            this.xoáNhânViênToolStripMenuItem.Name = "xoáNhânViênToolStripMenuItem";
            this.xoáNhânViênToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.xoáNhânViênToolStripMenuItem.Text = "Xoá nhân viên";
            this.xoáNhânViênToolStripMenuItem.Click += new System.EventHandler(this.xoáNhânViênToolStripMenuItem_Click);
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            this.xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            this.xemChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.xemChiTiếtToolStripMenuItem.Text = "Xem chi tiết";
            this.xemChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.xemChiTiếtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(89, 33);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(583, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.quanli_hieuthuocDataSet;
            // 
            // quanli_hieuthuocDataSet
            // 
            this.quanli_hieuthuocDataSet.DataSetName = "quanli_hieuthuocDataSet";
            this.quanli_hieuthuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // quanli_hieuthuocDataSet1
            // 
            this.quanli_hieuthuocDataSet1.DataSetName = "quanli_hieuthuocDataSet1";
            this.quanli_hieuthuocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienBindingSource1
            // 
            this.nhanvienBindingSource1.DataMember = "nhanvien";
            this.nhanvienBindingSource1.DataSource = this.quanli_hieuthuocDataSet1;
            // 
            // nhanvienTableAdapter1
            // 
            this.nhanvienTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chitiethoadonnhapTableAdapter = null;
            this.tableAdapterManager.chitiethoadonxuatTableAdapter = null;
            this.tableAdapterManager.hoadonnhapTableAdapter = null;
            this.tableAdapterManager.hoadonxuatTableAdapter = null;
            this.tableAdapterManager.nhanvienTableAdapter = this.nhanvienTableAdapter1;
            this.tableAdapterManager.nhomthuocTableAdapter = null;
            this.tableAdapterManager.thuocTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = hieuthuoc.quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanvienDataGridView
            // 
            this.nhanvienDataGridView.AutoGenerateColumns = false;
            this.nhanvienDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhanvienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanvienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewImageColumn1});
            this.nhanvienDataGridView.DataSource = this.nhanvienBindingSource1;
            this.nhanvienDataGridView.Location = new System.Drawing.Point(12, 200);
            this.nhanvienDataGridView.Name = "nhanvienDataGridView";
            this.nhanvienDataGridView.RowHeadersWidth = 51;
            this.nhanvienDataGridView.RowTemplate.Height = 24;
            this.nhanvienDataGridView.Size = new System.Drawing.Size(1499, 587);
            this.nhanvienDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "manhanvien";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "hoten";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "chucvu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Chức vụ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gioitinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tuoi";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tuổi";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "diachi";
            this.dataGridViewTextBoxColumn6.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "sodienthoai";
            this.dataGridViewTextBoxColumn8.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "phanquyen";
            this.dataGridViewTextBoxColumn9.HeaderText = "Phân quyền";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "tendangnhap";
            this.dataGridViewTextBoxColumn10.HeaderText = "Tên đăng nhập";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "matkhau";
            this.dataGridViewTextBoxColumn11.HeaderText = "Mật khẩu";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "hinhanh";
            this.dataGridViewImageColumn1.HeaderText = "Hình ảnh";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1531, 799);
            this.Controls.Add(this.nhanvienDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dangxuat);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - quản lí nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private quanli_hieuthuocDataSet quanli_hieuthuocDataSet;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private quanli_hieuthuocDataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem quảnLíThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtToolStripMenuItem;
        private quanli_hieuthuocDataSet1 quanli_hieuthuocDataSet1;
        private System.Windows.Forms.BindingSource nhanvienBindingSource1;
        private quanli_hieuthuocDataSet1TableAdapters.nhanvienTableAdapter nhanvienTableAdapter1;
        private quanli_hieuthuocDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nhanvienDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}