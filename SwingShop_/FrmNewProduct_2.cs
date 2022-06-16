using SwingShop_.Modelss;
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
    public partial class FrmNewProduct_2 : Form
    {
        String action = "shop-admin/new-product";
        String action_get = "";
        string actionDanhMuc = "shop/category-all?shopId=";
        public FrmNewProduct_2()
        {
            InitializeComponent();
        }
        void getCategorys()
        {
            string actionDanhMuc = "shop/category-all?shopId=";
            String shopId = "" + DataFromServer.shopIdStr;
            DataFromServer.LsCategory = Utils.getListObjectDataFromServer<Category>(actionDanhMuc + shopId, DataFromServer.token, "get");          
        }
        private void rdoThemMoi_CheckedChanged(object sender, EventArgs e)
        {
            btnThemMoi_SuaDoi.Text = "Thêm mới sản phẩm";
            reSetThemMoi();
         //   rdoProductTopping.Enabled = true;
          //  rdoProductNoman.Enabled = true;
            txtTenSanPham.Focus();
        }

        private void rdoSuaDoi_CheckedChanged(object sender, EventArgs e)
        {
            btnThemMoi_SuaDoi.Text = "Sửa sản phẩm";
         //   rdoProductNoman.Enabled = false;
         //   rdoProductTopping.Enabled = false;
        }

        private void btnThemMoi_SuaDoi_Click(object sender, EventArgs e)
        {
            if (rdoThemMoi.Checked)
            {
                themMoiSanPham();
            }else { 
                suaSanPham();
            }
        }
        void themMoiSanPham()
        {
            int giatien = (int)txtGiaTien.Value;
            Object o = cbxDanhMuc.SelectedValue;
            int DanhMucId = Int32.Parse("" + o);
            int shopId_ = Int32.Parse(DataFromServer.shopIdStr);

            int ShopId = shopId_ != 0 ? shopId_ : 3 ;  // ;  DataFromServer.shopIdInt;
            int isToppping = 0;
            if (rdoProductTopping.Checked)
            {
                isToppping = 1;
            }
            Product_Post_Server pProduct = new Product_Post_Server(txtTenSanPham.Text, txtMaSanPham.Text, giatien, DanhMucId,0, ShopId, 0, isToppping);            
                String data = Utils.postDataToServer3(action, DataFromServer.token, pProduct);
              richTextBox1.Text = data;
            int i = 0;
            i++;
            i++;
            getProducts();
            reSetThemMoi();
           
        }
        void reSetThemMoi()
        {
            txtTenSanPham.Text = "";
            txtGiaTien.Value = 0;
            setMaSanPhamRandom();
            dgrProductListView.Refresh();
        }
        void suaSanPham()
        {
            int idSanPham = 0;
            idSanPham = IdSP_;
            int giatien = (int)txtGiaTien.Value;
            Object o = cbxDanhMuc.SelectedValue;
            int DanhMucId = Int32.Parse("" + o);
            int ShopId = Int32.Parse( DataFromServer.shopIdStr);
            int isToppping = 0;
            if (rdoProductTopping.Checked)
            {
                isToppping = 1;
            }
            Product_Post_Server pProduct = new Product_Post_Server(idSanPham,txtTenSanPham.Text, txtMaSanPham.Text, giatien, DanhMucId, 0, ShopId, 0, isToppping);
            String data = Utils.postDataToServer3(action, DataFromServer.token, pProduct);

            richTextBox1.Text = data;
            int i=0;
            i++;
            i++;
            getProducts();
        }
        void xoaSanPham()
        {

        }

        private void FrmNewProduct_2_Load(object sender, EventArgs e)
        {
            getProducts();          
            cbxDanhMuc.DataSource = DataFromServer.LsCategory;
            cbxDanhMuc.DisplayMember = "CategoryName";
            cbxDanhMuc.ValueMember = "Id";
            setMaSanPhamRandom();
            txtTenSanPham.Focus();

        }
        void getProducts()
        {
            String action = "shop/product-all?shopId=";
            String shopId = "" + DataFromServer.shopIdStr;
            DataFromServer.lsProduct = Utils.getListObjectDataFromServer<Product>(action + shopId, DataFromServer.token, "get");
            dgrProductListView.DataSource = DataFromServer.lsProduct;
        }
        void setMaSanPhamRandom()
        {
            DateTime dt = DateTime.Now;
            int nn = dt.Second;
            txtMaSanPham.Text = "" + DataFromServer.shopIdStr + "" + nn;
        }

        private void cbxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text ="-ID :"+cbxDanhMuc.SelectedValue + ", cateName "+ cbxDanhMuc.Text;
        }
        int IdSP_ = 0;
        int giaTienSP_ = 0;
        String tenSP_ = "";
        String maSP_ = "";
        private void dgrProductListView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoSuaDoi.Checked)
            {
                int i = e.RowIndex;
                DataGridViewRow r = dgrProductListView.Rows[i];
                Object id = r.Cells[0].Value;
                Object name = r.Cells[1].Value;
                Object code = r.Cells[2].Value;
                Object price = r.Cells[3].Value;
                int giaTien = Int32.Parse(price.ToString());

                txtGiaTien.Value = giaTien;

                txtTenSanPham.Text = name.ToString();
                txtMaSanPham.Text = code.ToString();
                IdSP_ = Int32.Parse(i.ToString());
                giaTienSP_ = giaTien;
                tenSP_ = name.ToString();
                maSP_ = code.ToString();
            }
        }
    }
}
