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
    public partial class FrmNewProduct : Form
    {
        public Dictionary<String, Object> listKeyValue = new Dictionary<string, Object>();
        public FrmNewProduct()
        {
            InitializeComponent();
        }
        int isTopUp = 0;
        int hasTopping = 0;

        private void FrmNewProduct_Load(object sender, EventArgs e)
        {
            txtProductName.Text = "MATCHA_";
            txtProductCode.Text = "123412345";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            // listKeyValue.Clear();
            // listKeyValue.Add("productName", txtProductName.Text);
            // listKeyValue.Add("productCode", txtProductCode.Text);
            // listKeyValue.Add("isMultiPrice", 0);
            // listKeyValue.Add("price",100);
            // listKeyValue.Add("price2", 200);
            // listKeyValue.Add("price3", 250);
            // listKeyValue.Add("categoryId",1);
            // listKeyValue.Add("shopId", 3);
            // listKeyValue.Add("hasTopUp", hasTopping);
            // listKeyValue.Add("isTopUp", isTopUp);
            // // listKeyValue.Add("files", "" );
            ////  String data=  Utils.HttpPostRequest_FormData("http://150.95.109.25:8888/shop-admin/new-product", listKeyValue, DataFromServer.token);
            // String data = Utils.SendData_Post_2 (txtProductName.Text, txtProductCode.Text);
            // richTextBox1.Text = data;
            // //
            // name, price , isMultiPrice =0;  shopId ,hasTopUp,  isTopUp . 
            Product_Post_Server pProduct = new Product_Post_Server(txtProductName.Text, txtProductCode.Text,200,1,0,3,0,0) ;
            String action = "shop-admin/new-product";
            String data = Utils.postDataToServer3(action, DataFromServer.token, pProduct);
            richTextBox1.Text = data;

        }

        private void chkTopping_CheckedChanged(object sender, EventArgs e)
        {
          if ( chkTopping.Checked) {
                chkTopping.Text = "Là topping";
                isTopUp = 1;
                hasTopping = 0;
                chkHasTopping.Checked = false;
                chkHasTopping.Enabled = false;
            } else
            {
                chkTopping.Text = "ko Là topping";
                isTopUp = 0;
                chkHasTopping.Enabled = true;
            } 
        }

        private void chkHasTopping_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHasTopping.Checked) { chkHasTopping.Text = "Có sản phẩm con";
                hasTopping = 1;
                isTopUp = 0;
                chkTopping.Checked = false;
                chkTopping.Enabled = false;
            } else
            {
                chkTopping.Enabled = true;
                chkHasTopping.Text = " ko Có sản phẩm con";
            }
        }
    }
    class Product_Post
    {
        //productName , productCode,isMultiPrice,price, price2,price3,categoryId
        //shopId,hasTopUp, isTopUp ,files
        public String productName;
        public String productCode;

        public int isMultiPrice =0, price, price2, price3, categoryId;
        public int shopId=3, hasTopUp=0, isTopUp=0;
        public String files ="";


    }

}
