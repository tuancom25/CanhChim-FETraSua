using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using System.Text.Json;
using SwingShop_.Modelss;
using Newtonsoft;

namespace SwingShop_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String data = "";

        private void btnGetListProduct_Click(object sender, EventArgs e)
        {
           /*
            HttpWebRequest request = Utils.getHttpWebRequest("product", "abc", "get");
            // WebResponse respon =    request.GetResponse();
            try
            {
                WebResponse webResponse = request.GetResponse();
                Stream webStream = webResponse.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream);
                string response = responseReader.ReadToEnd();
                //   Console.Out.WriteLine(response);
                data = response;
                ricPasserJson.Text = response;
                responseReader.Close();
            }
            catch (Exception x)
            {
                Console.Out.WriteLine("-----------------");
                Console.Out.WriteLine(x.Message);
            }
         */

        }

         private List<Product> getListProduct()
        {
            List<Product> list = Utils.getListObjectDataFromServer<Product>("product", "abc", "get");
            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(data!=null )
            {
              //  try
             //   {
                    String dt = data.Replace("null", "0");
                    if (dt.Contains("\"")) { MessageBox.Show("Có chuoi \" "); }
                   if(data.Contains("null")) { MessageBox.Show(" Có gia trị null "); }
                    // JavaScriptSerializer 
                    //   JavaScriptSerializer json = new JavaScriptSerializer();
                    // JavaScriptSerializer json_serializer = new JavaScriptSerializer();
                    // Test routes_list =
                    //     (Test)json_serializer.DeserializeObject("{ \"test\":\"some data\" }");
                    ProductResponse abc = JsonSerializer.Deserialize<Modelss.ProductResponse>(dt);
                    ProductResponse productResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductResponse>(dt);
                    Text += " - Jsonconvert: " + productResponse.Message;
                    //   List<Product> listProduct = abc.Message;
                    String mm = abc.Message;
                    Text = " message:  " + mm;
                    foreach (Product p in productResponse.Data.Content)
                    {
                        listBox1.Items.Add(" data: " + p.ProductName + " , gia tien: " + p.ProductPrice);
                    }
              //  }catch (Exception x) { }

              
            }

        }

        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            // List<Category> listCategosys = Categorys.getListCategorys(3);
            List<Category> listCategosys = Categorys.getListCategorysByShopId(3);
          //  List
            foreach ( Category c in listCategosys)
            {
                ricPasserJson.Text += "\n shopID:" + c.ShopId + ", name: " + c.CategoryName;
            }
        }

        private void btnGetListProduct2_Click(object sender, EventArgs e)
        {
            List<Product> listProduct = Products.getListProduct_(3);
            foreach ( Product p in listProduct)
            {
               // ricPasserJson.Text += " id: " + p.;
            }
        }
    }
}
