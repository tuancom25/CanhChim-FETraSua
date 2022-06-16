using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SwingShop_.Modelss;
using System.Windows.Forms;

namespace SwingShop_
{
    public partial class FrmLogin : Form
    {
        static String data_LoginRessponse;
        public FrmLogin()
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();

            Application.Exit();
        }

        void LoginSever()
        {
            if (txtUser.Text != null && txtPass.Text != null)
            {
                // http://localhost:8888/shop-auth/login 
                // gọi hàm Utils.LoginSerrver() trong file Utils;
                String data = Utils.LoginSerrver(txtUser.Text, txtPass.Text);
               // data_LoginRessponse = data;
                richTextBox1.Text = data;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ( txtUser.Text !=null && txtPass.Text != null )
            {
                // http://localhost:8888/shop-auth/login
                // http://150.95.109.25:8888/shop-auth/login?username=admin&password=123456            
                String data = Utils.LoginSerrver(txtUser.Text, txtPass.Text);
                data_LoginRessponse = data; 
                richTextBox1.Text = data;
                //----------------------------
                UserLoginRessonse ursp = Utils.convertUserLoginRessonse(data);
                UserLoginRessonseDeltails udetail = ursp.Data;
                String shops = "";
                String allowed = "";
                txtShops.Text = udetail.Shops[0];
                foreach (String s in udetail.AllowedActions) { allowed += "," + s; }
                txtAllowed.Text = allowed;
                txtToken.Text = udetail.Token;
                DataFromServer.udetail = udetail;
                DataFromServer.token = udetail.Token;       
                DataFromServer.shopIdStr = udetail.Shops[0];
                DataFromServer.roles = udetail.AllowedActions;
               // String  roles = 
                int i = 0;
                i++;
                i++;
                i++;
                i++;
                LoadDataFromServer();
                i++;

            }
        }





        //Danh muc, product, Table, Zone, User, Shops, OrderPrint, TemPrint
        // void getCategorys() { }
        // void getProducts() { }
        // void getZoneTable() { }             
        // void getShopsByUsserId() { }
        // void getUsersEmployeeByShopId() { }
        // void getOrderPrintTemplete() { }
        // void getTemPrintTemplete() { }
        // void getShopInfo(){ }  // lay thông tin shop, address, Name, 
        String notify = "Kết quả :";
        void getCategorys() {
            string actionDanhMuc = "shop/category-all?shopId=";
            String shopId = "" + DataFromServer.shopIdStr;
            String data = Utils.getJsondataFromRestAPI(actionDanhMuc + shopId, DataFromServer.token, "get");
            DataFromServer.LsCategory = Utils.getListObjectDataFromServer<Category>(actionDanhMuc + shopId, DataFromServer.token, "get");
          //  richTextBox1.Text = data;      
        }    
        void getProducts() { 
        String action = "shop/product-all?shopId=";
            String shopId = ""+ DataFromServer.shopIdStr;
            DataFromServer.lsProduct = Utils.getListObjectDataFromServer<Product>(action + shopId, DataFromServer.token, "get");
        }
        void getZoneTables() {
            String action = "shop/display-all-tables?shopId=";
            String shopId = "" + DataFromServer.shopIdStr;
            DataFromServer.lsZone = Utils.getListObjectDataFromServer<Zone>(action + shopId, DataFromServer.token, "get");
        }

        void LoadDataFromServer()
        {
            //getCategorys();
            //getProducts();
            //getZoneTables();
            Utils.LoadAllData();
            int i = 0;
        }
        
        private void btnPasserDataRessponse_Click(object sender, EventArgs e)
        {
            String data = richTextBox1.Text;
            UserLoginRessonse ursp = Utils.convertUserLoginRessonse(data);
            UserLoginRessonseDeltails udetail = ursp.Data;
            String shops = "";
            String allowed="";
            txtShops.Text = udetail.Shops[0];
            foreach ( String s in udetail.AllowedActions) { allowed += "," + s; }
            txtAllowed.Text = allowed;
            txtToken.Text = udetail.Token;
            DataFromServer.token = udetail.Token;
        }

        private void btnThemMoiUsser_Click(object sender, EventArgs e)
        {
            FrmRegisterNewUser fnewU = new FrmRegisterNewUser();
            fnewU.Show();
        }

        private void btnDanhMucNew_Click(object sender, EventArgs e)
        {
            FrmNewCategory fDM = new FrmNewCategory();
            fDM.Show();
        }

        private void btnDisplayProduct_Click(object sender, EventArgs e)
        {
            btnGetListProductObject f = new btnGetListProductObject();
            f.Show();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            FrmNewProduct fp = new FrmNewProduct();
            fp.Show();
        }

        private void btnDispalyTableZone_Click(object sender, EventArgs e)
        {
            // FrmGetAndDisplayAllTables frmGetAndDisplayAllTables = new FrmGetAndDisplayAllTables();
            //  frmGetAndDisplayAllTables.Show();frmzone 
            FrmNewTableZone frmZ = new FrmNewTableZone();
            frmZ.Show();
        }

        private void btnHienThiDanhMuc_Click(object sender, EventArgs e)
        {
            FrmDispalyCategorys fdg = new FrmDispalyCategorys();
            fdg.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnTesstPostOrder_Click(object sender, EventArgs e)
        {
            FrmTestPostOrder f = new FrmTestPostOrder();
            f.Show();
        }

        private void btnThemMoiSanPham____Click(object sender, EventArgs e)
        {
            FrmNewProduct_2 f = new FrmNewProduct_2();
            f.Show();
        }

        private void btnThemNewZone_Click(object sender, EventArgs e)
        {
            FrmNewZone f = new FrmNewZone();
            f.Show();
        }
    }
}
