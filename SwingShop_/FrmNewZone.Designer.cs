
namespace SwingShop_
{
    partial class FrmNewZone
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
            this.btnThemMoiZone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSuaZone = new System.Windows.Forms.RadioButton();
            this.rdoThemMoiZone = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoSuaTable = new System.Windows.Forms.RadioButton();
            this.rdoThemMoiTable = new System.Windows.Forms.RadioButton();
            this.txtTenKhuVuc = new System.Windows.Forms.TextBox();
            this.dgrZone = new System.Windows.Forms.DataGridView();
            this.dgrTable = new System.Windows.Forms.DataGridView();
            this.cbxKhuVuc = new System.Windows.Forms.ComboBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkAllTables = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfSeat = new System.Windows.Forms.NumericUpDown();
            this.btnThemMoiTable = new System.Windows.Forms.Button();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmZoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemMoiZone
            // 
            this.btnThemMoiZone.Location = new System.Drawing.Point(79, 84);
            this.btnThemMoiZone.Name = "btnThemMoiZone";
            this.btnThemMoiZone.Size = new System.Drawing.Size(181, 23);
            this.btnThemMoiZone.TabIndex = 0;
            this.btnThemMoiZone.Text = "Thêm mới khu vực";
            this.btnThemMoiZone.UseVisualStyleBackColor = true;
            this.btnThemMoiZone.Click += new System.EventHandler(this.btnThemMoiZone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khu vực:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSuaZone);
            this.groupBox1.Controls.Add(this.rdoThemMoiZone);
            this.groupBox1.Location = new System.Drawing.Point(468, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chế độ thêm mới hoặc sửa  khu vực";
            // 
            // rdoSuaZone
            // 
            this.rdoSuaZone.AutoSize = true;
            this.rdoSuaZone.Location = new System.Drawing.Point(174, 33);
            this.rdoSuaZone.Name = "rdoSuaZone";
            this.rdoSuaZone.Size = new System.Drawing.Size(89, 19);
            this.rdoSuaZone.TabIndex = 0;
            this.rdoSuaZone.Text = "Sưả khu vực";
            this.rdoSuaZone.UseVisualStyleBackColor = true;
            this.rdoSuaZone.CheckedChanged += new System.EventHandler(this.rdoSuaZone_CheckedChanged);
            // 
            // rdoThemMoiZone
            // 
            this.rdoThemMoiZone.AutoSize = true;
            this.rdoThemMoiZone.Checked = true;
            this.rdoThemMoiZone.Location = new System.Drawing.Point(6, 33);
            this.rdoThemMoiZone.Name = "rdoThemMoiZone";
            this.rdoThemMoiZone.Size = new System.Drawing.Size(124, 19);
            this.rdoThemMoiZone.TabIndex = 0;
            this.rdoThemMoiZone.TabStop = true;
            this.rdoThemMoiZone.Text = "Thêm mới khu vực";
            this.rdoThemMoiZone.UseVisualStyleBackColor = true;
            this.rdoThemMoiZone.CheckedChanged += new System.EventHandler(this.rdoThemMoiZone_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoSuaTable);
            this.groupBox2.Controls.Add(this.rdoThemMoiTable);
            this.groupBox2.Location = new System.Drawing.Point(466, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chế độ thêm mới hoặc sửa  bàn.";
            // 
            // rdoSuaTable
            // 
            this.rdoSuaTable.AutoSize = true;
            this.rdoSuaTable.Location = new System.Drawing.Point(159, 33);
            this.rdoSuaTable.Name = "rdoSuaTable";
            this.rdoSuaTable.Size = new System.Drawing.Size(67, 19);
            this.rdoSuaTable.TabIndex = 0;
            this.rdoSuaTable.Text = "Sửa bàn";
            this.rdoSuaTable.UseVisualStyleBackColor = true;
            this.rdoSuaTable.CheckedChanged += new System.EventHandler(this.rdoSuaTable_CheckedChanged);
            // 
            // rdoThemMoiTable
            // 
            this.rdoThemMoiTable.AutoSize = true;
            this.rdoThemMoiTable.Checked = true;
            this.rdoThemMoiTable.Location = new System.Drawing.Point(6, 33);
            this.rdoThemMoiTable.Name = "rdoThemMoiTable";
            this.rdoThemMoiTable.Size = new System.Drawing.Size(102, 19);
            this.rdoThemMoiTable.TabIndex = 0;
            this.rdoThemMoiTable.TabStop = true;
            this.rdoThemMoiTable.Text = "Thêm mới bàn";
            this.rdoThemMoiTable.UseVisualStyleBackColor = true;
            this.rdoThemMoiTable.CheckedChanged += new System.EventHandler(this.rdoThemMoiTable_CheckedChanged);
            // 
            // txtTenKhuVuc
            // 
            this.txtTenKhuVuc.Location = new System.Drawing.Point(79, 37);
            this.txtTenKhuVuc.Name = "txtTenKhuVuc";
            this.txtTenKhuVuc.Size = new System.Drawing.Size(332, 23);
            this.txtTenKhuVuc.TabIndex = 4;
            // 
            // dgrZone
            // 
            this.dgrZone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrZone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmZoneName});
            this.dgrZone.Location = new System.Drawing.Point(468, 113);
            this.dgrZone.Name = "dgrZone";
            this.dgrZone.RowTemplate.Height = 25;
            this.dgrZone.Size = new System.Drawing.Size(371, 175);
            this.dgrZone.TabIndex = 5;
            this.dgrZone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrZone_CellClick);
            // 
            // dgrTable
            // 
            this.dgrTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTable.Location = new System.Drawing.Point(466, 94);
            this.dgrTable.Name = "dgrTable";
            this.dgrTable.RowTemplate.Height = 25;
            this.dgrTable.Size = new System.Drawing.Size(438, 177);
            this.dgrTable.TabIndex = 6;
            this.dgrTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // cbxKhuVuc
            // 
            this.cbxKhuVuc.FormattingEnabled = true;
            this.cbxKhuVuc.Location = new System.Drawing.Point(97, 21);
            this.cbxKhuVuc.Name = "cbxKhuVuc";
            this.cbxKhuVuc.Size = new System.Drawing.Size(161, 23);
            this.cbxKhuVuc.TabIndex = 7;
            this.cbxKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cbxKhuVuc_SelectedIndexChanged);
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(97, 65);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(332, 23);
            this.txtTenBan.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn khu vực:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên bàn:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThemMoiZone);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTenKhuVuc);
            this.groupBox3.Controls.Add(this.dgrZone);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(929, 304);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm khu vực";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkAllTables);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtNumberOfSeat);
            this.groupBox4.Controls.Add(this.btnThemMoiTable);
            this.groupBox4.Controls.Add(this.txtTenBan);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dgrTable);
            this.groupBox4.Controls.Add(this.cbxKhuVuc);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(14, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(927, 280);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thêm bàn";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // chkAllTables
            // 
            this.chkAllTables.AutoSize = true;
            this.chkAllTables.Checked = true;
            this.chkAllTables.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllTables.Location = new System.Drawing.Point(337, 252);
            this.chkAllTables.Name = "chkAllTables";
            this.chkAllTables.Size = new System.Drawing.Size(123, 19);
            this.chkAllTables.TabIndex = 10;
            this.chkAllTables.Text = "Hiển thị tất cả bàn";
            this.chkAllTables.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số ghế ngồi:";
            // 
            // txtNumberOfSeat
            // 
            this.txtNumberOfSeat.Location = new System.Drawing.Point(101, 115);
            this.txtNumberOfSeat.Name = "txtNumberOfSeat";
            this.txtNumberOfSeat.Size = new System.Drawing.Size(165, 23);
            this.txtNumberOfSeat.TabIndex = 8;
            this.txtNumberOfSeat.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnThemMoiTable
            // 
            this.btnThemMoiTable.Location = new System.Drawing.Point(97, 164);
            this.btnThemMoiTable.Name = "btnThemMoiTable";
            this.btnThemMoiTable.Size = new System.Drawing.Size(181, 23);
            this.btnThemMoiTable.TabIndex = 0;
            this.btnThemMoiTable.Text = "Thêm mới bàn";
            this.btnThemMoiTable.UseVisualStyleBackColor = true;
            this.btnThemMoiTable.Click += new System.EventHandler(this.btnThemMoiTable_Click);
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "id";
            this.clmId.HeaderText = "Mã Khu vực";
            this.clmId.Name = "clmId";
            // 
            // clmZoneName
            // 
            this.clmZoneName.DataPropertyName = "zoneName";
            this.clmZoneName.HeaderText = "Tên khu vực";
            this.clmZoneName.Name = "clmZoneName";
            // 
            // FrmNewZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 628);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmNewZone";
            this.Text = "FrmNewZone";
            this.Load += new System.EventHandler(this.FrmNewZone_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfSeat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemMoiZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSuaZone;
        private System.Windows.Forms.RadioButton rdoThemMoiZone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoSuaTable;
        private System.Windows.Forms.RadioButton rdoThemMoiTable;
        private System.Windows.Forms.TextBox txtTenKhuVuc;
        private System.Windows.Forms.DataGridView dgrZone;
        private System.Windows.Forms.DataGridView dgrTable;
        private System.Windows.Forms.ComboBox cbxKhuVuc;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnThemMoiTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtNumberOfSeat;
        private System.Windows.Forms.CheckBox chkAllTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmZoneName;
    }
}