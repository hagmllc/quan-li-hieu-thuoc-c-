
namespace hieuthuoc
{
    partial class suanhanvien
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
            System.Windows.Forms.Label manhanvienLabel;
            System.Windows.Forms.Label hotenLabel;
            System.Windows.Forms.Label chucvuLabel;
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label tuoiLabel;
            System.Windows.Forms.Label diachiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label sodienthoaiLabel;
            System.Windows.Forms.Label phanquyenLabel;
            System.Windows.Forms.Label tendangnhapLabel;
            System.Windows.Forms.Label matkhauLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suanhanvien));
            this.label1 = new System.Windows.Forms.Label();
            this.quanli_hieuthuocDataSet = new hieuthuoc.quanli_hieuthuocDataSet();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new hieuthuoc.quanli_hieuthuocDataSetTableAdapters.nhanvienTableAdapter();
            this.tableAdapterManager = new hieuthuoc.quanli_hieuthuocDataSetTableAdapters.TableAdapterManager();
            this.btn_sua = new System.Windows.Forms.Button();
            this.manhanvienTextBox = new System.Windows.Forms.TextBox();
            this.hotenTextBox = new System.Windows.Forms.TextBox();
            this.chucvuTextBox = new System.Windows.Forms.TextBox();
            this.gioitinhTextBox = new System.Windows.Forms.TextBox();
            this.tuoiTextBox = new System.Windows.Forms.TextBox();
            this.diachiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sodienthoaiTextBox = new System.Windows.Forms.TextBox();
            this.phanquyenTextBox = new System.Windows.Forms.TextBox();
            this.tendangnhapTextBox = new System.Windows.Forms.TextBox();
            this.matkhauTextBox = new System.Windows.Forms.TextBox();
            manhanvienLabel = new System.Windows.Forms.Label();
            hotenLabel = new System.Windows.Forms.Label();
            chucvuLabel = new System.Windows.Forms.Label();
            gioitinhLabel = new System.Windows.Forms.Label();
            tuoiLabel = new System.Windows.Forms.Label();
            diachiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            sodienthoaiLabel = new System.Windows.Forms.Label();
            phanquyenLabel = new System.Windows.Forms.Label();
            tendangnhapLabel = new System.Windows.Forms.Label();
            matkhauLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // manhanvienLabel
            // 
            manhanvienLabel.AutoSize = true;
            manhanvienLabel.Location = new System.Drawing.Point(59, 170);
            manhanvienLabel.Name = "manhanvienLabel";
            manhanvienLabel.Size = new System.Drawing.Size(130, 25);
            manhanvienLabel.TabIndex = 2;
            manhanvienLabel.Text = "Mã nhân viên";
            // 
            // hotenLabel
            // 
            hotenLabel.AutoSize = true;
            hotenLabel.Location = new System.Drawing.Point(59, 225);
            hotenLabel.Name = "hotenLabel";
            hotenLabel.Size = new System.Drawing.Size(69, 25);
            hotenLabel.TabIndex = 3;
            hotenLabel.Text = "Họ tên";
            // 
            // chucvuLabel
            // 
            chucvuLabel.AutoSize = true;
            chucvuLabel.Location = new System.Drawing.Point(59, 280);
            chucvuLabel.Name = "chucvuLabel";
            chucvuLabel.Size = new System.Drawing.Size(85, 25);
            chucvuLabel.TabIndex = 5;
            chucvuLabel.Text = "Chức vụ";
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(59, 335);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(82, 25);
            gioitinhLabel.TabIndex = 7;
            gioitinhLabel.Text = "Giới tính";
            // 
            // tuoiLabel
            // 
            tuoiLabel.AutoSize = true;
            tuoiLabel.Location = new System.Drawing.Point(59, 390);
            tuoiLabel.Name = "tuoiLabel";
            tuoiLabel.Size = new System.Drawing.Size(51, 25);
            tuoiLabel.TabIndex = 9;
            tuoiLabel.Text = "Tuổi";
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Location = new System.Drawing.Point(59, 445);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(71, 25);
            diachiLabel.TabIndex = 11;
            diachiLabel.Text = "Địa chỉ";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(667, 166);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(60, 25);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // sodienthoaiLabel
            // 
            sodienthoaiLabel.AutoSize = true;
            sodienthoaiLabel.Location = new System.Drawing.Point(658, 223);
            sodienthoaiLabel.Name = "sodienthoaiLabel";
            sodienthoaiLabel.Size = new System.Drawing.Size(126, 25);
            sodienthoaiLabel.TabIndex = 15;
            sodienthoaiLabel.Text = "Số điện thoại";
            // 
            // phanquyenLabel
            // 
            phanquyenLabel.AutoSize = true;
            phanquyenLabel.Location = new System.Drawing.Point(658, 280);
            phanquyenLabel.Name = "phanquyenLabel";
            phanquyenLabel.Size = new System.Drawing.Size(117, 25);
            phanquyenLabel.TabIndex = 17;
            phanquyenLabel.Text = "Phân quyền";
            // 
            // tendangnhapLabel
            // 
            tendangnhapLabel.AutoSize = true;
            tendangnhapLabel.Location = new System.Drawing.Point(658, 337);
            tendangnhapLabel.Name = "tendangnhapLabel";
            tendangnhapLabel.Size = new System.Drawing.Size(145, 25);
            tendangnhapLabel.TabIndex = 19;
            tendangnhapLabel.Text = "Tên đăng nhập";
            // 
            // matkhauLabel
            // 
            matkhauLabel.AutoSize = true;
            matkhauLabel.Location = new System.Drawing.Point(667, 394);
            matkhauLabel.Name = "matkhauLabel";
            matkhauLabel.Size = new System.Drawing.Size(93, 25);
            matkhauLabel.TabIndex = 21;
            matkhauLabel.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỬA NHÂN VIÊN";
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
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(518, 534);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(164, 41);
            this.btn_sua.TabIndex = 23;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // manhanvienTextBox
            // 
            this.manhanvienTextBox.Location = new System.Drawing.Point(214, 165);
            this.manhanvienTextBox.Name = "manhanvienTextBox";
            this.manhanvienTextBox.Size = new System.Drawing.Size(318, 30);
            this.manhanvienTextBox.TabIndex = 24;
            // 
            // hotenTextBox
            // 
            this.hotenTextBox.Location = new System.Drawing.Point(214, 220);
            this.hotenTextBox.Name = "hotenTextBox";
            this.hotenTextBox.Size = new System.Drawing.Size(318, 30);
            this.hotenTextBox.TabIndex = 24;
            // 
            // chucvuTextBox
            // 
            this.chucvuTextBox.Location = new System.Drawing.Point(214, 275);
            this.chucvuTextBox.Name = "chucvuTextBox";
            this.chucvuTextBox.Size = new System.Drawing.Size(318, 30);
            this.chucvuTextBox.TabIndex = 24;
            // 
            // gioitinhTextBox
            // 
            this.gioitinhTextBox.Location = new System.Drawing.Point(214, 330);
            this.gioitinhTextBox.Name = "gioitinhTextBox";
            this.gioitinhTextBox.Size = new System.Drawing.Size(318, 30);
            this.gioitinhTextBox.TabIndex = 24;
            // 
            // tuoiTextBox
            // 
            this.tuoiTextBox.Location = new System.Drawing.Point(214, 385);
            this.tuoiTextBox.Name = "tuoiTextBox";
            this.tuoiTextBox.Size = new System.Drawing.Size(318, 30);
            this.tuoiTextBox.TabIndex = 24;
            // 
            // diachiTextBox
            // 
            this.diachiTextBox.Location = new System.Drawing.Point(214, 440);
            this.diachiTextBox.Name = "diachiTextBox";
            this.diachiTextBox.Size = new System.Drawing.Size(318, 30);
            this.diachiTextBox.TabIndex = 24;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(803, 161);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(318, 30);
            this.emailTextBox.TabIndex = 24;
            // 
            // sodienthoaiTextBox
            // 
            this.sodienthoaiTextBox.Location = new System.Drawing.Point(803, 217);
            this.sodienthoaiTextBox.Name = "sodienthoaiTextBox";
            this.sodienthoaiTextBox.Size = new System.Drawing.Size(318, 30);
            this.sodienthoaiTextBox.TabIndex = 24;
            // 
            // phanquyenTextBox
            // 
            this.phanquyenTextBox.Location = new System.Drawing.Point(803, 273);
            this.phanquyenTextBox.Name = "phanquyenTextBox";
            this.phanquyenTextBox.Size = new System.Drawing.Size(318, 30);
            this.phanquyenTextBox.TabIndex = 24;
            // 
            // tendangnhapTextBox
            // 
            this.tendangnhapTextBox.Location = new System.Drawing.Point(803, 329);
            this.tendangnhapTextBox.Name = "tendangnhapTextBox";
            this.tendangnhapTextBox.Size = new System.Drawing.Size(318, 30);
            this.tendangnhapTextBox.TabIndex = 24;
            // 
            // matkhauTextBox
            // 
            this.matkhauTextBox.Location = new System.Drawing.Point(803, 385);
            this.matkhauTextBox.Name = "matkhauTextBox";
            this.matkhauTextBox.Size = new System.Drawing.Size(318, 30);
            this.matkhauTextBox.TabIndex = 24;
            // 
            // suanhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.diachiTextBox);
            this.Controls.Add(this.tuoiTextBox);
            this.Controls.Add(this.gioitinhTextBox);
            this.Controls.Add(this.chucvuTextBox);
            this.Controls.Add(this.hotenTextBox);
            this.Controls.Add(this.matkhauTextBox);
            this.Controls.Add(this.tendangnhapTextBox);
            this.Controls.Add(this.phanquyenTextBox);
            this.Controls.Add(this.sodienthoaiTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.manhanvienTextBox);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(matkhauLabel);
            this.Controls.Add(tendangnhapLabel);
            this.Controls.Add(phanquyenLabel);
            this.Controls.Add(sodienthoaiLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(diachiLabel);
            this.Controls.Add(tuoiLabel);
            this.Controls.Add(gioitinhLabel);
            this.Controls.Add(chucvuLabel);
            this.Controls.Add(hotenLabel);
            this.Controls.Add(manhanvienLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "suanhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa nhân viên";
            this.Load += new System.EventHandler(this.suanhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private quanli_hieuthuocDataSet quanli_hieuthuocDataSet;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private quanli_hieuthuocDataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
        private quanli_hieuthuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox manhanvienTextBox;
        private System.Windows.Forms.TextBox hotenTextBox;
        private System.Windows.Forms.TextBox chucvuTextBox;
        private System.Windows.Forms.TextBox gioitinhTextBox;
        private System.Windows.Forms.TextBox tuoiTextBox;
        private System.Windows.Forms.TextBox diachiTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox sodienthoaiTextBox;
        private System.Windows.Forms.TextBox phanquyenTextBox;
        private System.Windows.Forms.TextBox tendangnhapTextBox;
        private System.Windows.Forms.TextBox matkhauTextBox;
    }
}