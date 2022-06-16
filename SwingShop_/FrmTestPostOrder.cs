using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwingShop_.Modelss;

namespace SwingShop_
{
    public partial class FrmTestPostOrder : Form
    {
        public FrmTestPostOrder()
        {
            InitializeComponent();
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            String actionPostOrder = " op.Items.Add(new Item_Post(2,1400,1));";
            Order_Post op = new Order_Post();
            op.shopId = 3;
            op.tableId = 1;
            op.items.Add(new Item_Post(2,1400,1));
            op.items.Add(new Item_Post(4, 1400, 1));
        //  String data =   Utils.PostOrder(op, actionPostOrder);
            String data = Utils.PostOrder(op);
            richTextBox1.Text = data;
        }
    }
}
