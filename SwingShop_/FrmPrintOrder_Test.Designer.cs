
namespace SwingShop_
{
    partial class FrmPrintOrder_Test
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpZone = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataTextContent = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoFoot = new System.Windows.Forms.RadioButton();
            this.rdoHead = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPixelX = new System.Windows.Forms.NumericUpDown();
            this.txtPixelY = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPixelX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPixelY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(69, 362);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(116, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Thực hiện test In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpZone
            // 
            this.grpZone.BackColor = System.Drawing.Color.White;
            this.grpZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpZone.Location = new System.Drawing.Point(569, 55);
            this.grpZone.Name = "grpZone";
            this.grpZone.Size = new System.Drawing.Size(384, 452);
            this.grpZone.TabIndex = 1;
            this.grpZone.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(206, 312);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 244);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nội dung Text";
            // 
            // txtDataTextContent
            // 
            this.txtDataTextContent.Location = new System.Drawing.Point(69, 139);
            this.txtDataTextContent.Name = "txtDataTextContent";
            this.txtDataTextContent.Size = new System.Drawing.Size(451, 23);
            this.txtDataTextContent.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Tahoma";
            this.textBox2.DoubleClick += new System.EventHandler(this.textBox2_DoubleClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(253, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 23);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn Font chữ ( double click)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kiểu chữ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoFoot);
            this.groupBox2.Controls.Add(this.rdoHead);
            this.groupBox2.Location = new System.Drawing.Point(69, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 57);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vùng in";
            // 
            // rdoFoot
            // 
            this.rdoFoot.AutoSize = true;
            this.rdoFoot.Location = new System.Drawing.Point(209, 22);
            this.rdoFoot.Name = "rdoFoot";
            this.rdoFoot.Size = new System.Drawing.Size(91, 19);
            this.rdoFoot.TabIndex = 0;
            this.rdoFoot.Text = "In dưới chân";
            this.rdoFoot.UseVisualStyleBackColor = true;
            // 
            // rdoHead
            // 
            this.rdoHead.AutoSize = true;
            this.rdoHead.Checked = true;
            this.rdoHead.Location = new System.Drawing.Point(27, 22);
            this.rdoHead.Name = "rdoHead";
            this.rdoHead.Size = new System.Drawing.Size(132, 19);
            this.rdoHead.TabIndex = 0;
            this.rdoHead.TabStop = true;
            this.rdoHead.Text = "In trên  đầu hóa đơn";
            this.rdoHead.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Noman (  chữ thường)",
            "Bold ( Chữ đậm )",
            "Italic ( Chữ nghiêng)",
            "UnderLine ( Chữ gạch dưới )",
            "Struck  ( Chữ gạch ngang)"});
            this.comboBox1.Location = new System.Drawing.Point(380, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm Nội dung in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tộ độ ngang X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tọa độ đứng Y:";
            // 
            // txtPixelX
            // 
            this.txtPixelX.Location = new System.Drawing.Point(153, 251);
            this.txtPixelX.Name = "txtPixelX";
            this.txtPixelX.Size = new System.Drawing.Size(120, 23);
            this.txtPixelX.TabIndex = 10;
            this.txtPixelX.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // txtPixelY
            // 
            this.txtPixelY.Location = new System.Drawing.Point(389, 253);
            this.txtPixelY.Name = "txtPixelY";
            this.txtPixelY.Size = new System.Drawing.Size(120, 23);
            this.txtPixelY.TabIndex = 10;
            this.txtPixelY.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // FrmPrintOrder_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 568);
            this.Controls.Add(this.txtPixelY);
            this.Controls.Add(this.txtPixelX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtDataTextContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.grpZone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrint);
            this.Name = "FrmPrintOrder_Test";
            this.Text = "FrmPrintOrder_Test";
            this.Load += new System.EventHandler(this.FrmPrintOrder_Test_Load);
            this.DoubleClick += new System.EventHandler(this.FrmPrintOrder_Test_DoubleClick);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPixelX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPixelY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpZone;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataTextContent;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoFoot;
        private System.Windows.Forms.RadioButton rdoHead;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtPixelX;
        private System.Windows.Forms.NumericUpDown txtPixelY;
    }
}