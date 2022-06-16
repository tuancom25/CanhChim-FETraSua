
namespace SwingShop_
{
    partial class FrmNewCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdoDanhMucCon = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDMThuong = new System.Windows.Forms.RadioButton();
            this.btnThemDanhMuc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoThemMoi = new System.Windows.Forms.RadioButton();
            this.rdoSua = new System.Windows.Forms.RadioButton();
            this.txtMoTaDM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Danh mục sản phẩm";
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(144, 140);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(217, 23);
            this.txtTenDM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập tên Danh mục:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(384, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(457, 346);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // rdoDanhMucCon
            // 
            this.rdoDanhMucCon.AutoSize = true;
            this.rdoDanhMucCon.Location = new System.Drawing.Point(196, 22);
            this.rdoDanhMucCon.Name = "rdoDanhMucCon";
            this.rdoDanhMucCon.Size = new System.Drawing.Size(103, 19);
            this.rdoDanhMucCon.TabIndex = 5;
            this.rdoDanhMucCon.Text = "Danh mục con";
            this.rdoDanhMucCon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDMThuong);
            this.groupBox1.Controls.Add(this.rdoDanhMucCon);
            this.groupBox1.Location = new System.Drawing.Point(60, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 44);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn loại danh mục";
            // 
            // rdoDMThuong
            // 
            this.rdoDMThuong.AutoSize = true;
            this.rdoDMThuong.Checked = true;
            this.rdoDMThuong.Location = new System.Drawing.Point(28, 22);
            this.rdoDMThuong.Name = "rdoDMThuong";
            this.rdoDMThuong.Size = new System.Drawing.Size(122, 19);
            this.rdoDMThuong.TabIndex = 5;
            this.rdoDMThuong.TabStop = true;
            this.rdoDMThuong.Text = "Danh mục thường";
            this.rdoDMThuong.UseVisualStyleBackColor = true;
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.Location = new System.Drawing.Point(144, 237);
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Size = new System.Drawing.Size(116, 23);
            this.btnThemDanhMuc.TabIndex = 7;
            this.btnThemDanhMuc.Text = "Thêm Danh mục";
            this.btnThemDanhMuc.UseVisualStyleBackColor = true;
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoThemMoi);
            this.groupBox2.Controls.Add(this.rdoSua);
            this.groupBox2.Location = new System.Drawing.Point(455, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 52);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chế độ thêm mới hoặc sửa đổi";
            // 
            // rdoThemMoi
            // 
            this.rdoThemMoi.AutoSize = true;
            this.rdoThemMoi.Checked = true;
            this.rdoThemMoi.Location = new System.Drawing.Point(28, 22);
            this.rdoThemMoi.Name = "rdoThemMoi";
            this.rdoThemMoi.Size = new System.Drawing.Size(79, 19);
            this.rdoThemMoi.TabIndex = 5;
            this.rdoThemMoi.TabStop = true;
            this.rdoThemMoi.Text = "Thêm mới";
            this.rdoThemMoi.UseVisualStyleBackColor = true;
            this.rdoThemMoi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoSua
            // 
            this.rdoSua.AutoSize = true;
            this.rdoSua.Location = new System.Drawing.Point(196, 22);
            this.rdoSua.Name = "rdoSua";
            this.rdoSua.Size = new System.Drawing.Size(43, 19);
            this.rdoSua.TabIndex = 5;
            this.rdoSua.Text = "sửa";
            this.rdoSua.UseVisualStyleBackColor = true;
            this.rdoSua.CheckedChanged += new System.EventHandler(this.rdoSua_CheckedChanged);
            // 
            // txtMoTaDM
            // 
            this.txtMoTaDM.Location = new System.Drawing.Point(144, 187);
            this.txtMoTaDM.Name = "txtMoTaDM";
            this.txtMoTaDM.Size = new System.Drawing.Size(217, 23);
            this.txtMoTaDM.TabIndex = 9;
            this.txtMoTaDM.Text = "ko ";
            this.txtMoTaDM.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mô tả";
            this.label3.Visible = false;
            // 
            // FrmNewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMoTaDM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemDanhMuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenDM);
            this.Controls.Add(this.label1);
            this.Name = "FrmNewCategory";
            this.Text = "FrmNewCategory";
            this.Load += new System.EventHandler(this.FrmNewCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdoDanhMucCon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDMThuong;
        private System.Windows.Forms.Button btnThemDanhMuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoThemMoi;
        private System.Windows.Forms.RadioButton rdoSua;
        private System.Windows.Forms.TextBox txtMoTaDM;
        private System.Windows.Forms.Label label3;
    }
}