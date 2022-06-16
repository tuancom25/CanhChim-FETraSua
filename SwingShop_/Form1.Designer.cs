
namespace SwingShop_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetListProduct = new System.Windows.Forms.Button();
            this.ricPasserJson = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGetCategory = new System.Windows.Forms.Button();
            this.btnGetUserOfShop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGetListProduct2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetListProduct
            // 
            this.btnGetListProduct.Location = new System.Drawing.Point(28, 133);
            this.btnGetListProduct.Name = "btnGetListProduct";
            this.btnGetListProduct.Size = new System.Drawing.Size(151, 23);
            this.btnGetListProduct.TabIndex = 0;
            this.btnGetListProduct.Text = "Get listProduct";
            this.btnGetListProduct.UseVisualStyleBackColor = true;
            this.btnGetListProduct.Click += new System.EventHandler(this.btnGetListProduct_Click);
            // 
            // ricPasserJson
            // 
            this.ricPasserJson.Location = new System.Drawing.Point(349, 109);
            this.ricPasserJson.Name = "ricPasserJson";
            this.ricPasserJson.Size = new System.Drawing.Size(595, 405);
            this.ricPasserJson.TabIndex = 1;
            this.ricPasserJson.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "parser Json to Object";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 342);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 184);
            this.listBox1.TabIndex = 3;
            // 
            // btnGetCategory
            // 
            this.btnGetCategory.Location = new System.Drawing.Point(28, 22);
            this.btnGetCategory.Name = "btnGetCategory";
            this.btnGetCategory.Size = new System.Drawing.Size(151, 23);
            this.btnGetCategory.TabIndex = 4;
            this.btnGetCategory.Text = "Get Category";
            this.btnGetCategory.UseVisualStyleBackColor = true;
            this.btnGetCategory.Click += new System.EventHandler(this.btnGetCategory_Click);
            // 
            // btnGetUserOfShop
            // 
            this.btnGetUserOfShop.Location = new System.Drawing.Point(28, 62);
            this.btnGetUserOfShop.Name = "btnGetUserOfShop";
            this.btnGetUserOfShop.Size = new System.Drawing.Size(151, 23);
            this.btnGetUserOfShop.TabIndex = 5;
            this.btnGetUserOfShop.Text = "Get UserOfShop";
            this.btnGetUserOfShop.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Get UserOfShop";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnGetListProduct2
            // 
            this.btnGetListProduct2.Location = new System.Drawing.Point(28, 216);
            this.btnGetListProduct2.Name = "btnGetListProduct2";
            this.btnGetListProduct2.Size = new System.Drawing.Size(151, 23);
            this.btnGetListProduct2.TabIndex = 7;
            this.btnGetListProduct2.Text = "Get list Product 2 <?>";
            this.btnGetListProduct2.UseVisualStyleBackColor = true;
            this.btnGetListProduct2.Click += new System.EventHandler(this.btnGetListProduct2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 549);
            this.Controls.Add(this.btnGetListProduct2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGetUserOfShop);
            this.Controls.Add(this.btnGetCategory);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ricPasserJson);
            this.Controls.Add(this.btnGetListProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetListProduct;
        private System.Windows.Forms.RichTextBox ricPasserJson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGetCategory;
        private System.Windows.Forms.Button btnGetUserOfShop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGetListProduct2;
    }
}

