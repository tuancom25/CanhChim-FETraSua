
namespace SwingShop_
{
    partial class FrmNewProduct_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoProductTopping = new System.Windows.Forms.RadioButton();
            this.rdoProductNoman = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrProductListView = new System.Windows.Forms.DataGridView();
            this.btnThemMoi_SuaDoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.NumericUpDown();
            this.cbxDanhMuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoSuaDoi = new System.Windows.Forms.RadioButton();
            this.rdoThemMoi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProductListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoProductTopping);
            this.groupBox1.Controls.Add(this.rdoProductNoman);
            this.groupBox1.Location = new System.Drawing.Point(399, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại sản phẩm";
            // 
            // rdoProductTopping
            // 
            this.rdoProductTopping.AutoSize = true;
            this.rdoProductTopping.Location = new System.Drawing.Point(245, 23);
            this.rdoProductTopping.Name = "rdoProductTopping";
            this.rdoProductTopping.Size = new System.Drawing.Size(157, 19);
            this.rdoProductTopping.TabIndex = 1;
            this.rdoProductTopping.Text = "sản phẩm phụ ( topping)";
            this.rdoProductTopping.UseVisualStyleBackColor = true;
            // 
            // rdoProductNoman
            // 
            this.rdoProductNoman.AutoSize = true;
            this.rdoProductNoman.Checked = true;
            this.rdoProductNoman.Location = new System.Drawing.Point(18, 23);
            this.rdoProductNoman.Name = "rdoProductNoman";
            this.rdoProductNoman.Size = new System.Drawing.Size(120, 19);
            this.rdoProductNoman.TabIndex = 0;
            this.rdoProductNoman.TabStop = true;
            this.rdoProductNoman.Text = "Sản phẩm thường";
            this.rdoProductNoman.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(387, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm sản phẩm";
            // 
            // dgrProductListView
            // 
            this.dgrProductListView.AllowUserToAddRows = false;
            this.dgrProductListView.AllowUserToDeleteRows = false;
            this.dgrProductListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProductListView.Location = new System.Drawing.Point(399, 265);
            this.dgrProductListView.Name = "dgrProductListView";
            this.dgrProductListView.ReadOnly = true;
            this.dgrProductListView.RowTemplate.Height = 25;
            this.dgrProductListView.Size = new System.Drawing.Size(497, 299);
            this.dgrProductListView.TabIndex = 2;
            this.dgrProductListView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrProductListView_CellClick);
            // 
            // btnThemMoi_SuaDoi
            // 
            this.btnThemMoi_SuaDoi.Location = new System.Drawing.Point(100, 239);
            this.btnThemMoi_SuaDoi.Name = "btnThemMoi_SuaDoi";
            this.btnThemMoi_SuaDoi.Size = new System.Drawing.Size(93, 23);
            this.btnThemMoi_SuaDoi.TabIndex = 3;
            this.btnThemMoi_SuaDoi.Text = "Thêm mới";
            this.btnThemMoi_SuaDoi.UseVisualStyleBackColor = true;
            this.btnThemMoi_SuaDoi.Click += new System.EventHandler(this.btnThemMoi_SuaDoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá tiền";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(100, 98);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(229, 23);
            this.txtTenSanPham.TabIndex = 7;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(100, 187);
            this.txtGiaTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(229, 23);
            this.txtGiaTien.TabIndex = 8;
            // 
            // cbxDanhMuc
            // 
            this.cbxDanhMuc.FormattingEnabled = true;
            this.cbxDanhMuc.Location = new System.Drawing.Point(471, 236);
            this.cbxDanhMuc.Name = "cbxDanhMuc";
            this.cbxDanhMuc.Size = new System.Drawing.Size(160, 23);
            this.cbxDanhMuc.TabIndex = 9;
            this.cbxDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbxDanhMuc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Danh mục:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoSuaDoi);
            this.groupBox2.Controls.Add(this.rdoThemMoi);
            this.groupBox2.Location = new System.Drawing.Point(400, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm mới - sửa đổi ";
            // 
            // rdoSuaDoi
            // 
            this.rdoSuaDoi.AutoSize = true;
            this.rdoSuaDoi.Location = new System.Drawing.Point(244, 23);
            this.rdoSuaDoi.Name = "rdoSuaDoi";
            this.rdoSuaDoi.Size = new System.Drawing.Size(99, 19);
            this.rdoSuaDoi.TabIndex = 1;
            this.rdoSuaDoi.Text = "Sửa sản phẩm";
            this.rdoSuaDoi.UseVisualStyleBackColor = true;
            this.rdoSuaDoi.CheckedChanged += new System.EventHandler(this.rdoSuaDoi_CheckedChanged);
            // 
            // rdoThemMoi
            // 
            this.rdoThemMoi.AutoSize = true;
            this.rdoThemMoi.Checked = true;
            this.rdoThemMoi.Location = new System.Drawing.Point(18, 23);
            this.rdoThemMoi.Name = "rdoThemMoi";
            this.rdoThemMoi.Size = new System.Drawing.Size(137, 19);
            this.rdoThemMoi.TabIndex = 0;
            this.rdoThemMoi.TabStop = true;
            this.rdoThemMoi.Text = "Thêm mới sản phẩm ";
            this.rdoThemMoi.UseVisualStyleBackColor = true;
            this.rdoThemMoi.CheckedChanged += new System.EventHandler(this.rdoThemMoi_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã sản phẩm:";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(100, 140);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(229, 23);
            this.txtMaSanPham.TabIndex = 12;
            this.txtMaSanPham.Text = "000_";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 287);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(317, 212);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // FrmNewProduct_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 587);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDanhMuc);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemMoi_SuaDoi);
            this.Controls.Add(this.dgrProductListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNewProduct_2";
            this.Text = "Thêm Sản phẩm";
            this.Load += new System.EventHandler(this.FrmNewProduct_2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProductListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoProductTopping;
        private System.Windows.Forms.RadioButton rdoProductNoman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrProductListView;
        private System.Windows.Forms.Button btnThemMoi_SuaDoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.NumericUpDown txtGiaTien;
        private System.Windows.Forms.ComboBox cbxDanhMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoSuaDoi;
        private System.Windows.Forms.RadioButton rdoThemMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}