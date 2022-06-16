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
    public partial class FrmDispalyCategorys : Form
    {
        public FrmDispalyCategorys()
        {
            InitializeComponent();
        }
        public string actionDanhMuc = "shop/category-all?shopId=";
        int shopId = 3;

        private void btnGetDanhMuc_Click(object sender, EventArgs e)
        {
              string actionDanhMuc = "shop/category-all?shopId=";
        int shopId = 3;
        String data = Utils.getJsondataFromRestAPI(actionDanhMuc + shopId, DataFromServer.token, "get");
            richTextBox1.Text = data;
        }

        private void btnGetListObjectCategory_Click(object sender, EventArgs e)
        {
            getListCategory();

        }
        public void getListCategory()
        {
            string actionDanhMuc = "shop/category-all?shopId=";
            int shopId = 3;
            DataFromServer.LsCategory = Utils.getListObjectDataFromServer<Modelss.Category>(actionDanhMuc + shopId, DataFromServer.token, "get");
            dataGridView1.DataSource = DataFromServer.LsCategory;
        }
    }
}
