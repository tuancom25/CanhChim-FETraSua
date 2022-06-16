
namespace SwingShop_
{
    partial class FrmDispalyCategorys
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
            this.btnGetDanhMuc = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGetListObjectCategory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetDanhMuc
            // 
            this.btnGetDanhMuc.Location = new System.Drawing.Point(53, 70);
            this.btnGetDanhMuc.Name = "btnGetDanhMuc";
            this.btnGetDanhMuc.Size = new System.Drawing.Size(128, 23);
            this.btnGetDanhMuc.TabIndex = 0;
            this.btnGetDanhMuc.Text = "btnGetDanhMuc";
            this.btnGetDanhMuc.UseVisualStyleBackColor = true;
            this.btnGetDanhMuc.Click += new System.EventHandler(this.btnGetDanhMuc_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(314, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(431, 74);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnGetListObjectCategory
            // 
            this.btnGetListObjectCategory.Location = new System.Drawing.Point(62, 134);
            this.btnGetListObjectCategory.Name = "btnGetListObjectCategory";
            this.btnGetListObjectCategory.Size = new System.Drawing.Size(155, 23);
            this.btnGetListObjectCategory.TabIndex = 2;
            this.btnGetListObjectCategory.Text = "Get listPbject Categofy";
            this.btnGetListObjectCategory.UseVisualStyleBackColor = true;
            this.btnGetListObjectCategory.Click += new System.EventHandler(this.btnGetListObjectCategory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(474, 254);
            this.dataGridView1.TabIndex = 3;
            // 
            // FrmDispalyCategorys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetListObjectCategory);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnGetDanhMuc);
            this.Name = "FrmDispalyCategorys";
            this.Text = "FrmDispalyCategorys";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetDanhMuc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnGetListObjectCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}