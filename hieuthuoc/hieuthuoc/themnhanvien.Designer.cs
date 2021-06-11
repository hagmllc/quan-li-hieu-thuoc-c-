
namespace hieuthuoc
{
    partial class themnhanvien
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
            System.Windows.Forms.Label hinhanhLabel;
            this.quanli_hieuthuocDataSet = new hieuthuoc.quanli_hieuthuocDataSet();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new hieuthuoc.quanli_hieuthuocDataSetTableAdapters.nhanvienTableAdapter();
            this.tableAdapterManager = new hieuthuoc.quanli_hieuthuocDataSetTableAdapters.TableAdapterManager();
            this.manhanvienTextBox = new System.Windows.Forms.TextBox();
            this.hotenTextBox = new System.Windows.Forms.TextBox();
            this.chucvuTextBox = new System.Windows.Forms.TextBox();
            this.tuoiTextBox = new System.Windows.Forms.TextBox();
            this.diachiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sodienthoaiTextBox = new System.Windows.Forms.TextBox();
            this.tendangnhapTextBox = new System.Windows.Forms.TextBox();
            this.matkhauTextBox = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_linkanh = new System.Windows.Forms.TextBox();
            this.hinhanhPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_thongbao = new System.Windows.Forms.Label();
            this.nhaplai = new System.Windows.Forms.Button();
            this.gioitinhTextBox = new System.Windows.Forms.ComboBox();
            this.phanquyenTextBox = new System.Windows.Forms.ComboBox();
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
            hinhanhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // manhanvienLabel
            // 
            manhanvienLabel.AutoSize = true;
            manhanvienLabel.Location = new System.Drawing.Point(59, 206);
            manhanvienLabel.Name = "manhanvienLabel";
            manhanvienLabel.Size = new System.Drawing.Size(130, 25);
            manhanvienLabel.TabIndex = 1;
            manhanvienLabel.Text = "Mã nhân viên";
            // 
            // hotenLabel
            // 
            hotenLabel.AutoSize = true;
            hotenLabel.Location = new System.Drawing.Point(59, 272);
            hotenLabel.Name = "hotenLabel";
            hotenLabel.Size = new System.Drawing.Size(69, 25);
            hotenLabel.TabIndex = 3;
            hotenLabel.Text = "Họ tên";
            // 
            // chucvuLabel
            // 
            chucvuLabel.AutoSize = true;
            chucvuLabel.Location = new System.Drawing.Point(59, 335);
            chucvuLabel.Name = "chucvuLabel";
            chucvuLabel.Size = new System.Drawing.Size(85, 25);
            chucvuLabel.TabIndex = 5;
            chucvuLabel.Text = "Chức vụ";
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(59, 403);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(82, 25);
            gioitinhLabel.TabIndex = 7;
            gioitinhLabel.Text = "Giới tính";
            // 
            // tuoiLabel
            // 
            tuoiLabel.AutoSize = true;
            tuoiLabel.Location = new System.Drawing.Point(59, 466);
            tuoiLabel.Name = "tuoiLabel";
            tuoiLabel.Size = new System.Drawing.Size(51, 25);
            tuoiLabel.TabIndex = 9;
            tuoiLabel.Text = "Tuổi";
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Location = new System.Drawing.Point(732, 209);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(71, 25);
            diachiLabel.TabIndex = 11;
            diachiLabel.Text = "Địa chỉ";
            diachiLabel.Click += new System.EventHandler(this.diachiLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(732, 266);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(60, 25);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // sodienthoaiLabel
            // 
            sodienthoaiLabel.AutoSize = true;
            sodienthoaiLabel.Location = new System.Drawing.Point(732, 323);
            sodienthoaiLabel.Name = "sodienthoaiLabel";
            sodienthoaiLabel.Size = new System.Drawing.Size(126, 25);
            sodienthoaiLabel.TabIndex = 15;
            sodienthoaiLabel.Text = "Số điện thoại";
            sodienthoaiLabel.Click += new System.EventHandler(this.sodienthoaiLabel_Click);
            // 
            // phanquyenLabel
            // 
            phanquyenLabel.AutoSize = true;
            phanquyenLabel.Location = new System.Drawing.Point(732, 380);
            phanquyenLabel.Name = "phanquyenLabel";
            phanquyenLabel.Size = new System.Drawing.Size(117, 25);
            phanquyenLabel.TabIndex = 17;
            phanquyenLabel.Text = "Phân quyền";
            // 
            // tendangnhapLabel
            // 
            tendangnhapLabel.AutoSize = true;
            tendangnhapLabel.Location = new System.Drawing.Point(732, 437);
            tendangnhapLabel.Name = "tendangnhapLabel";
            tendangnhapLabel.Size = new System.Drawing.Size(145, 25);
            tendangnhapLabel.TabIndex = 19;
            tendangnhapLabel.Text = "Tên đăng nhập";
            tendangnhapLabel.Click += new System.EventHandler(this.tendangnhapLabel_Click);
            // 
            // matkhauLabel
            // 
            matkhauLabel.AutoSize = true;
            matkhauLabel.Location = new System.Drawing.Point(732, 494);
            matkhauLabel.Name = "matkhauLabel";
            matkhauLabel.Size = new System.Drawing.Size(93, 25);
            matkhauLabel.TabIndex = 21;
            matkhauLabel.Text = "Mật khẩu";
            matkhauLabel.Click += new System.EventHandler(this.matkhauLabel_Click);
            // 
            // hinhanhLabel
            // 
            hinhanhLabel.AutoSize = true;
            hinhanhLabel.Location = new System.Drawing.Point(54, 557);
            hinhanhLabel.Name = "hinhanhLabel";
            hinhanhLabel.Size = new System.Drawing.Size(90, 25);
            hinhanhLabel.TabIndex = 25;
            hinhanhLabel.Text = "Hình ảnh";
            hinhanhLabel.Click += new System.EventHandler(this.hinhanhLabel_Click);
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
            // manhanvienTextBox
            // 
            this.manhanvienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "manhanvien", true));
            this.manhanvienTextBox.Location = new System.Drawing.Point(206, 206);
            this.manhanvienTextBox.Name = "manhanvienTextBox";
            this.manhanvienTextBox.Size = new System.Drawing.Size(273, 30);
            this.manhanvienTextBox.TabIndex = 2;
            // 
            // hotenTextBox
            // 
            this.hotenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "hoten", true));
            this.hotenTextBox.Location = new System.Drawing.Point(206, 272);
            this.hotenTextBox.Name = "hotenTextBox";
            this.hotenTextBox.Size = new System.Drawing.Size(273, 30);
            this.hotenTextBox.TabIndex = 4;
            // 
            // chucvuTextBox
            // 
            this.chucvuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "chucvu", true));
            this.chucvuTextBox.Location = new System.Drawing.Point(206, 335);
            this.chucvuTextBox.Name = "chucvuTextBox";
            this.chucvuTextBox.Size = new System.Drawing.Size(273, 30);
            this.chucvuTextBox.TabIndex = 6;
            // 
            // tuoiTextBox
            // 
            this.tuoiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "tuoi", true));
            this.tuoiTextBox.Location = new System.Drawing.Point(206, 466);
            this.tuoiTextBox.Name = "tuoiTextBox";
            this.tuoiTextBox.Size = new System.Drawing.Size(273, 30);
            this.tuoiTextBox.TabIndex = 10;
            // 
            // diachiTextBox
            // 
            this.diachiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "diachi", true));
            this.diachiTextBox.Location = new System.Drawing.Point(884, 201);
            this.diachiTextBox.Name = "diachiTextBox";
            this.diachiTextBox.Size = new System.Drawing.Size(287, 30);
            this.diachiTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(884, 258);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(287, 30);
            this.emailTextBox.TabIndex = 14;
            // 
            // sodienthoaiTextBox
            // 
            this.sodienthoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "sodienthoai", true));
            this.sodienthoaiTextBox.Location = new System.Drawing.Point(884, 315);
            this.sodienthoaiTextBox.Name = "sodienthoaiTextBox";
            this.sodienthoaiTextBox.Size = new System.Drawing.Size(287, 30);
            this.sodienthoaiTextBox.TabIndex = 16;
            // 
            // tendangnhapTextBox
            // 
            this.tendangnhapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "tendangnhap", true));
            this.tendangnhapTextBox.Location = new System.Drawing.Point(884, 429);
            this.tendangnhapTextBox.Name = "tendangnhapTextBox";
            this.tendangnhapTextBox.Size = new System.Drawing.Size(287, 30);
            this.tendangnhapTextBox.TabIndex = 20;
            // 
            // matkhauTextBox
            // 
            this.matkhauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "matkhau", true));
            this.matkhauTextBox.Location = new System.Drawing.Point(884, 486);
            this.matkhauTextBox.Name = "matkhauTextBox";
            this.matkhauTextBox.Size = new System.Drawing.Size(287, 30);
            this.matkhauTextBox.TabIndex = 22;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(206, 676);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(145, 37);
            this.btn_them.TabIndex = 23;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_linkanh
            // 
            this.txt_linkanh.Location = new System.Drawing.Point(752, 552);
            this.txt_linkanh.Name = "txt_linkanh";
            this.txt_linkanh.Size = new System.Drawing.Size(389, 30);
            this.txt_linkanh.TabIndex = 24;
            // 
            // hinhanhPictureBox
            // 
            this.hinhanhPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.nhanvienBindingSource, "hinhanh", true));
            this.hinhanhPictureBox.Location = new System.Drawing.Point(206, 514);
            this.hinhanhPictureBox.Name = "hinhanhPictureBox";
            this.hinhanhPictureBox.Size = new System.Drawing.Size(144, 124);
            this.hinhanhPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanhPictureBox.TabIndex = 26;
            this.hinhanhPictureBox.TabStop = false;
            this.hinhanhPictureBox.Click += new System.EventHandler(this.hinhanhPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Link ảnh";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(884, 676);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(133, 37);
            this.btn_thoat.TabIndex = 28;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 46);
            this.label2.TabIndex = 29;
            this.label2.Text = "THÊM NHÂN VIÊN";
            // 
            // lbl_thongbao
            // 
            this.lbl_thongbao.AutoSize = true;
            this.lbl_thongbao.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_thongbao.Location = new System.Drawing.Point(475, 620);
            this.lbl_thongbao.Name = "lbl_thongbao";
            this.lbl_thongbao.Size = new System.Drawing.Size(0, 25);
            this.lbl_thongbao.TabIndex = 30;
            // 
            // nhaplai
            // 
            this.nhaplai.Location = new System.Drawing.Point(547, 676);
            this.nhaplai.Name = "nhaplai";
            this.nhaplai.Size = new System.Drawing.Size(148, 37);
            this.nhaplai.TabIndex = 31;
            this.nhaplai.Text = "Nhập lại";
            this.nhaplai.UseVisualStyleBackColor = true;
            this.nhaplai.Click += new System.EventHandler(this.nhaplai_Click);
            // 
            // gioitinhTextBox
            // 
            this.gioitinhTextBox.FormattingEnabled = true;
            this.gioitinhTextBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.gioitinhTextBox.Location = new System.Drawing.Point(206, 403);
            this.gioitinhTextBox.Name = "gioitinhTextBox";
            this.gioitinhTextBox.Size = new System.Drawing.Size(133, 33);
            this.gioitinhTextBox.TabIndex = 32;
            // 
            // phanquyenTextBox
            // 
            this.phanquyenTextBox.FormattingEnabled = true;
            this.phanquyenTextBox.Items.AddRange(new object[] {
            "Admin",
            "Quản lí",
            "Nhân viên"});
            this.phanquyenTextBox.Location = new System.Drawing.Point(884, 372);
            this.phanquyenTextBox.Name = "phanquyenTextBox";
            this.phanquyenTextBox.Size = new System.Drawing.Size(287, 33);
            this.phanquyenTextBox.TabIndex = 33;
            // 
            // themnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 754);
            this.Controls.Add(this.phanquyenTextBox);
            this.Controls.Add(this.gioitinhTextBox);
            this.Controls.Add(this.nhaplai);
            this.Controls.Add(this.lbl_thongbao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(hinhanhLabel);
            this.Controls.Add(this.hinhanhPictureBox);
            this.Controls.Add(this.txt_linkanh);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(matkhauLabel);
            this.Controls.Add(this.matkhauTextBox);
            this.Controls.Add(tendangnhapLabel);
            this.Controls.Add(this.tendangnhapTextBox);
            this.Controls.Add(phanquyenLabel);
            this.Controls.Add(sodienthoaiLabel);
            this.Controls.Add(this.sodienthoaiTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(diachiLabel);
            this.Controls.Add(this.diachiTextBox);
            this.Controls.Add(tuoiLabel);
            this.Controls.Add(this.tuoiTextBox);
            this.Controls.Add(gioitinhLabel);
            this.Controls.Add(chucvuLabel);
            this.Controls.Add(this.chucvuTextBox);
            this.Controls.Add(hotenLabel);
            this.Controls.Add(this.hotenTextBox);
            this.Controls.Add(manhanvienLabel);
            this.Controls.Add(this.manhanvienTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "themnhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên";
            this.Load += new System.EventHandler(this.themnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanli_hieuthuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private quanli_hieuthuocDataSet quanli_hieuthuocDataSet;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private quanli_hieuthuocDataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
        private quanli_hieuthuocDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox manhanvienTextBox;
        private System.Windows.Forms.TextBox hotenTextBox;
        private System.Windows.Forms.TextBox chucvuTextBox;
        private System.Windows.Forms.TextBox tuoiTextBox;
        private System.Windows.Forms.TextBox diachiTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox sodienthoaiTextBox;
        private System.Windows.Forms.TextBox tendangnhapTextBox;
        private System.Windows.Forms.TextBox matkhauTextBox;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_linkanh;
        private System.Windows.Forms.PictureBox hinhanhPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_thongbao;
        private System.Windows.Forms.Button nhaplai;
        private System.Windows.Forms.ComboBox gioitinhTextBox;
        private System.Windows.Forms.ComboBox phanquyenTextBox;
    }
}