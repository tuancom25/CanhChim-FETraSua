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
    public partial class btnGetListProductObject : Form
    { //  http://localhost:8888/shop/product-all?shopId=3
       // String domain = "";
        String action = "shop/product-all?shopId=";
        int shopId = 3;
        public List<Product> lsProduct = null; 
        
        public btnGetListProductObject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();

        }

        public void getData()
        {
            String action = "shop/product-all?shopId=";
            int shopId = 3;
            action += shopId;
            String data = Utils.getJsondataFromRestAPI(action, "Bearer " + DataFromServer.token, "get");
            richTextBox1.Text = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String url = Utils.urlDomain + action + shopId;
            DataFromServer.lsProduct = Utils.getListObjectDataFromServer<Product>(action+shopId,  DataFromServer.token, "get");
            
            int i = 0;

            dataGridView1.DataSource = DataFromServer.lsProduct;
           // dataGridView1.AutoGenerateColumns = false;
        }
    }
}
