using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwingShop_
{
    public partial class FrmBaiTapHienThi : Form
    {
        public FrmBaiTapHienThi()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            object o = comboBox1.SelectedItem;
            int mm = Int32.Parse(o.ToString());
            foreach (Control c in Controls)
            {

                if (c is Button)
                {
                    // this.Controls.Remove(c);
                    groupBox1.Controls.Clear();
                }
            }
            groupBox1.Refresh();
            int ii = 0; ii++; ii++;ii++;
            Text = " value :" + o.ToString();
            for (int i = 0; i < mm; i++)
            {
                Button b = new Button();
                b.Left = 100 * i + 20;
                b.Text = "nut .." + i;
                b.Width = 70;
                b.Height = 50;
                b.Top = 20;
                groupBox1.Controls.Add(b);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
