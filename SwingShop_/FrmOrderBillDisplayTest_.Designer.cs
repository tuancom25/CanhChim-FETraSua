
namespace SwingShop_
{
    partial class FrmOrderBillDisplayTest_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderBillDisplayTest_));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node10", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnThemShopPing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnInHoadon2 = new System.Windows.Forms.Button();
            this.btnDisplayTableInrictextBox = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnDisplayTextFormatOfRich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(33, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 35);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(321, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(454, 181);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            // 
            // btnThemShopPing
            // 
            this.btnThemShopPing.Location = new System.Drawing.Point(45, 355);
            this.btnThemShopPing.Name = "btnThemShopPing";
            this.btnThemShopPing.Size = new System.Drawing.Size(105, 23);
            this.btnThemShopPing.TabIndex = 4;
            this.btnThemShopPing.Text = "Thêm topping";
            this.btnThemShopPing.UseVisualStyleBackColor = true;
            this.btnThemShopPing.Click += new System.EventHandler(this.btnThemShopPing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(479, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chi tiết Đơn hàng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Trân châu đen";
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Location = new System.Drawing.Point(45, 326);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(115, 23);
            this.btnThemSanPham.TabIndex = 7;
            this.btnThemSanPham.Text = "thêm sản phẩm";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(50, 403);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(100, 23);
            this.btnInHoaDon.TabIndex = 8;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Checked = true;
            treeNode5.Name = "Node0";
            treeNode5.Text = "Node0";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Node8";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Node9";
            treeNode10.Checked = true;
            treeNode10.Name = "Node5";
            treeNode10.Text = "Node5";
            treeNode11.Name = "Node11";
            treeNode11.Text = "Node11";
            treeNode12.Name = "Node12";
            treeNode12.Text = "Node12";
            treeNode13.Name = "Node13";
            treeNode13.Text = "Node13";
            treeNode14.Name = "Node14";
            treeNode14.Text = "Node14";
            treeNode15.Name = "Node10";
            treeNode15.Text = "Node10";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(263, 227);
            this.treeView1.TabIndex = 9;
            // 
            // btnInHoadon2
            // 
            this.btnInHoadon2.Location = new System.Drawing.Point(182, 326);
            this.btnInHoadon2.Name = "btnInHoadon2";
            this.btnInHoadon2.Size = new System.Drawing.Size(75, 23);
            this.btnInHoadon2.TabIndex = 10;
            this.btnInHoadon2.Text = "In hóa đơn";
            this.btnInHoadon2.UseVisualStyleBackColor = true;
            this.btnInHoadon2.Click += new System.EventHandler(this.btnInHoadon2_Click);
            // 
            // btnDisplayTableInrictextBox
            // 
            this.btnDisplayTableInrictextBox.Location = new System.Drawing.Point(172, 366);
            this.btnDisplayTableInrictextBox.Name = "btnDisplayTableInrictextBox";
            this.btnDisplayTableInrictextBox.Size = new System.Drawing.Size(133, 23);
            this.btnDisplayTableInrictextBox.TabIndex = 11;
            this.btnDisplayTableInrictextBox.Text = "Display Table in rich";
            this.btnDisplayTableInrictextBox.UseVisualStyleBackColor = true;
            this.btnDisplayTableInrictextBox.Click += new System.EventHandler(this.btnDisplayTableInrictextBox_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(359, 286);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(375, 140);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // btnDisplayTextFormatOfRich
            // 
            this.btnDisplayTextFormatOfRich.Location = new System.Drawing.Point(172, 403);
            this.btnDisplayTextFormatOfRich.Name = "btnDisplayTextFormatOfRich";
            this.btnDisplayTextFormatOfRich.Size = new System.Drawing.Size(133, 23);
            this.btnDisplayTextFormatOfRich.TabIndex = 13;
            this.btnDisplayTextFormatOfRich.Text = "Display Text Format";
            this.btnDisplayTextFormatOfRich.UseVisualStyleBackColor = true;
            this.btnDisplayTextFormatOfRich.Click += new System.EventHandler(this.btnDisplayTextFormatOfRich_Click);
            // 
            // FrmOrderBillDisplayTest_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayTextFormatOfRich);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnDisplayTableInrictextBox);
            this.Controls.Add(this.btnInHoadon2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemShopPing);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmOrderBillDisplayTest_";
            this.Text = "FrmOrderBillDisplayTest_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnThemShopPing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnInHoadon2;
        private System.Windows.Forms.Button btnDisplayTableInrictextBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnDisplayTextFormatOfRich;
    }
}