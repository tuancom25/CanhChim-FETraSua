
namespace SwingShop_
{
    partial class FrmSelectZoneAndTable
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
            this.rdoChonTheoViTriBan = new System.Windows.Forms.RadioButton();
            this.rdoChonTheoSoLuong = new System.Windows.Forms.RadioButton();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChonTheoViTriBan);
            this.groupBox1.Controls.Add(this.rdoChonTheoSoLuong);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(479, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu chọn bàn";
            // 
            // rdoChonTheoViTriBan
            // 
            this.rdoChonTheoViTriBan.AutoSize = true;
            this.rdoChonTheoViTriBan.Location = new System.Drawing.Point(33, 25);
            this.rdoChonTheoViTriBan.Margin = new System.Windows.Forms.Padding(4);
            this.rdoChonTheoViTriBan.Name = "rdoChonTheoViTriBan";
            this.rdoChonTheoViTriBan.Size = new System.Drawing.Size(200, 24);
            this.rdoChonTheoViTriBan.TabIndex = 1;
            this.rdoChonTheoViTriBan.TabStop = true;
            this.rdoChonTheoViTriBan.Text = "Chọn vị trí  bàn của Zone";
            this.rdoChonTheoViTriBan.UseVisualStyleBackColor = true;
            this.rdoChonTheoViTriBan.CheckedChanged += new System.EventHandler(this.rdoChonTheoViTriBan_CheckedChanged);
            // 
            // rdoChonTheoSoLuong
            // 
            this.rdoChonTheoSoLuong.AutoSize = true;
            this.rdoChonTheoSoLuong.Location = new System.Drawing.Point(241, 25);
            this.rdoChonTheoSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.rdoChonTheoSoLuong.Name = "rdoChonTheoSoLuong";
            this.rdoChonTheoSoLuong.Size = new System.Drawing.Size(230, 24);
            this.rdoChonTheoSoLuong.TabIndex = 0;
            this.rdoChonTheoSoLuong.TabStop = true;
            this.rdoChonTheoSoLuong.Text = "Chọn Số lượng bàn  của Zone";
            this.rdoChonTheoSoLuong.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(768, 42);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(248, 31);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận chọn bàn";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1029, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusLabel1.Text = "Trạng thái Order ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(141, 17);
            this.toolStripStatusLabel2.Text = "**** toolStripStatusLabel2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tai cho";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mang ve";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ship";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(499, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 62);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loai don";
            // 
            // FrmSelectZoneAndTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSelectZoneAndTable";
            this.Text = "FrmSelectZoneAndTable";
            this.Load += new System.EventHandler(this.FrmSelectZoneAndTable_Load);
            this.ResizeEnd += new System.EventHandler(this.FrmSelectZoneAndTable_ResizeEnd);
            this.Resize += new System.EventHandler(this.FrmSelectZoneAndTable_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoChonTheoSoLuong;
        private System.Windows.Forms.RadioButton rdoChonTheoViTriBan;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}