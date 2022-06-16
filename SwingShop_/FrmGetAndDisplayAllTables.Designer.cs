
namespace SwingShop_
{
    partial class FrmGetAndDisplayAllTables
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
            this.btnGetTables = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGetTables
            // 
            this.btnGetTables.Location = new System.Drawing.Point(70, 130);
            this.btnGetTables.Name = "btnGetTables";
            this.btnGetTables.Size = new System.Drawing.Size(75, 23);
            this.btnGetTables.TabIndex = 0;
            this.btnGetTables.Text = "get Tables ";
            this.btnGetTables.UseVisualStyleBackColor = true;
            this.btnGetTables.Click += new System.EventHandler(this.btnGetTables_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(230, 93);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(508, 301);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // FrmGetAndDisplayAllTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnGetTables);
            this.Name = "FrmGetAndDisplayAllTables";
            this.Text = "FrmGetAndDisplayAllTables";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetTables;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}