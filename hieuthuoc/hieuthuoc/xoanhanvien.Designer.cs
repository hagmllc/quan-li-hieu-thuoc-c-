
namespace hieuthuoc
{
    partial class xoanhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xoanhanvien));
            this.quanli_hieuthuocDataSet = new hieuthuoc.quanli_hieuthuocDataSet();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new hieuthuoc.quanli_hieuthuocDataSetTableAdapters.nhanvienTableAdapter();
            this.tableAdapterManager = new hieuthuoc.quanli_hieuthuocDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.wn_lb = new System.Windows.Forms.Label();
            this.manhanvienTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quanli_hieuthuocDataSet
            // 
            this.quanli_hieuthuocDataSet.DataSetName = "quanli_hieuthuocDataSet";
            this.quanli_hieuthuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.quanli_hieuthuocDataSet;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.nhanvienTableAdapter = this.nhanvienTableAdapter;
            this.tableAdapterManager.UpdateOrder = hieuthuoc.quanli_hieuthuocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã nhân viên muốn xoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "XOÁ NHÂN VIÊN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(131, 394);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(110, 39);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(453, 394);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(105, 39);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb_thongbao.Location = new System.Drawing.Point(131, 192);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(0, 25);
            this.lb_thongbao.TabIndex = 5;
            // 
            // wn_lb
            // 
            this.wn_lb.AutoSize = true;
            this.wn_lb.ForeColor = System.Drawing.Color.Red;
            this.wn_lb.Location = new System.Drawing.Point(150, 199);
            this.wn_lb.Name = "wn_lb";
            this.wn_lb.Size = new System.Drawing.Size(0, 25);
            this.wn_lb.TabIndex = 6;
            // 
            // manhanvienTextBox
            // 
            this.manhanvienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "manhanvien", true));
            this.manhanvienTextBox.Location = new System.Drawing.Point(136, 310);
            this.manhanvienTextBox.Name = "manhanvienTextBox";
            this.manhanvienTextBox.Size = new System.Drawing.Size(254, 30);
            this.manhanvienTextBox.TabIndex = 7;
            // 
            // xoanhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 498);
            this.Controls.Add(this.manhanvienTextBox);
            this.Controls.Add(this.wn_lb);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "xoanhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoá nhân viên";
            this.Load += new System.EventHandler(this.xoanhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private quanli_hieuthuocDataSet quanli_hieuthuocDataSet;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private quanli_hieuthuocDataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
        private quanli_hieuthuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.Label wn_lb;
        private System.Windows.Forms.TextBox manhanvienTextBox;
    }
}