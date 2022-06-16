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
    public partial class FrmNewCategory : Form
    {
        int shopId = 3;
        // String action = "shop/category-all?shopId=";
        String action = "shop-admin/new-category";
        //
        //http://localhost:8888/shop-admin/new-category
        // http://localhost:8888/shop-admin/new-category (Post) Thêm danh muc cho shop
        // String Actions = "shop-admin/new-category";
        // http://localhost:8888/shop/category-all?shopId=3 (get) lấy danh muc của shop.
        public FrmNewCategory()
        {
            InitializeComponent();
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            // getDanhMucSanPham();
            if (txtTenDM.Text != null)
            {
             

                int shopID = Int32.Parse(DataFromServer.shopIdStr);
                if (rdoThemMoi.Checked) {
                    CategoryPost    p = new CategoryPost(shopID, txtTenDM.Text, txtMoTaDM.Text != null ? txtMoTaDM.Text : " ko");
                    String data = Utils.postDataToServer3(action, DataFromServer.token, p);
                }
               else
               {
                    CategoryPostID_  p = new CategoryPostID_(shopID, txtTenDM.Text, txtMoTaDM.Text != null ? txtMoTaDM.Text : " ko", id);
                    String data = Utils.postDataToServer3(action, DataFromServer.token, p);
                }
            
                Utils.getCategorys();
                dataGridView1.Refresh();
            }
    
        }

        void getDanhMucSanPham()
        {
            action = action + shopId;
            String data = Utils.getJsondataFromRestAPI(action, "Bearer "+ DataFromServer.token, "get");
           // richTextBox1.Text = data;
        }

        private void FrmNewCategory_Load(object sender, EventArgs e)
        {
            // getDanhMucSanPham();
            dataGridView1.DataSource = DataFromServer.LsCategory;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnThemDanhMuc.Text = "Thêm mới danh mục";
        }

        private void rdoSua_CheckedChanged(object sender, EventArgs e)
        {
            btnThemDanhMuc.Text = "Sửa danh mục";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoSua.Checked)
            {
                int index = e.RowIndex;
                DataGridViewRow r = dataGridView1.Rows[index];
                Object o1 = r.Cells[0].Value;
                Object o2 = r.Cells[1].Value;
                Object o3 = r.Cells[2].Value;
                txtTenDM.Text = o2.ToString();
               // txtMoTaDM.Text = o3.ToString();
                id = Int32.Parse(o1.ToString());
                categoryName = o2.ToString();
              //  description = o3.ToString();
                txtTenDM.Focus();
            }
        }
        int id = 0;
       // int shopId = 0;
        String categoryName = "";
        String description = "";
    }
}
