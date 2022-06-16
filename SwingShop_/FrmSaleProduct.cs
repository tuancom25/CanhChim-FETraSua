using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwingShop_.Modelss;

namespace SwingShop_
{
    public partial class FrmSaleProduct : Form
    {
        Graphics g = null;
        public FrmSaleProduct()
        {
            InitializeComponent();
            frmsale = this;
            g = CreateGraphics();
        }
        public static FrmSaleProduct frmsale = null;
        public static int MaBan_ = 0;   // Mã bàn ăn , bàn uống nước .
        public static int MaKhuVu_ = 0; // Mã khu vực ăn , khu vực uống nước .
        public static String maBan = "0";
        public static String maKhuVuc = "0";
       // public static List<Product> listProduct = null;
       // public static List<Product> listProductTopping = null;
       // public static List<Category> listCategory = null;
        public static List<Product> listFullProduct = null;
        public static List<Product> lsProductHot = null;      //  Sử dụng 
        public static List<Product> lsProductDefault = null;  //  Sử dụng 

        public static String UserNameLogin = "";
        public static int UserNameLoginId = 0;
        public static int ShipId = 0;
        public static String shopName = "";
        public static int shopType = 0;
        public void setProduct() { }
        String numberOfSelected = "1";
        int numberOfSelectedInt = 1;
        int LoaiDonHangTaiCHo_MangVe = 0;
        int CurentLineSelectInRichTextBox = 0;
        int CurentLineProductSelectInRichTextBox = 0;
        //--------------- 
        /*-
         * --Thuoc tinh ParentProduct của Product là 1 thuộc tính tạm thời, 
         * --nó đưuọc sinh ra khi khi  render Order  vào richTextBox, lưu trữ môi quan hệ 
         * --topping  
         */
        List<Category> listCategorDum = null;
        int categorysize = 70;
        //============== for print =================
      //  public List<Product> listProductSelected = new List<Product>();
       // public List<Product> listProductToppingSelected = new List<Product>();
        Font fontProduct = new Font("Segoe UI", 11, FontStyle.Bold);
        Font fontTopping = new Font("Segoe UI", 10, FontStyle.Regular);
        Product productCurent = null;   //  sản phẩm đang đưuọc chọn
        Product productCurentTopping = null;
        List<Product> lsProductInOrder = null;
        int X_ProductNameLocation = 10;
        int X_ProductNameToppingLocation = 38;
        int X_ProductPrice = 150;
        public static int curentProductId = 0;
        public static int curentProductParentId = 0;
        public static Product curentProductParent = null;
        //============= end for print==================
        public  Order_DonHang order_donHang_Curent = null;
        public  List<Order_DonHang> listOrder_DonHang = new List<Order_DonHang>();
         void mmmmm() { order_donHang_Curent.trangThaiHoanThanh =    Order_DonHang.TrangThaiHoanThanh.DangMua ;
            
        }
        //============= Căn chỉnh hiển thị hóa đơn ====
        int cot2 = 245;
        int cot3 = 290;
        int cot4 = 365;
        //====================
        public static Product productTypeIfShipCode = null;
       // public static Order_DonHang order_Current = null; 

        private void FrmSaleProduct_Load(object sender, EventArgs e)
        {
            LoadAndDrawData();
            genHotProduct();
            genDefaultProduct();
         //   dgrProductSelected.Font = new Font("Tahoma", 9f, FontStyle.Regular);
         
        }

        void LoadAndDrawData()
        {
            listFullProduct = SwingShop_.DataDumy.DataGetFromDumy.getListtProductDumy();
            listCategorDum = SwingShop_.DataDumy.DataGetFromDumy.getListCategoryDummy();
            int i = 0;
            for (int l = listCategorDum.Count - 1; l >= 0; l--)
            {
                if (listCategorDum[l].CategoryName.ToLower().Contains("topping"))
                {
                    Category c = listCategorDum[listCategorDum.Count - 1];
                    listCategorDum[listCategorDum.Count - 1] = listCategorDum[l];
                    listCategorDum[l] = c;
                    listCategorDum[listCategorDum.Count - 1].ForeColor = Color.Red;

                    break;
                }
            }
            foreach (Category c in listCategorDum)
            {
                c.Text = c.CategoryName;
                c.Left = 20 + (categorysize + 25) * i;
                c.Top = 25;
                i++;
                c.Height = 45; c.Width = 80;
                c.Font = new Font("Tahoma", 9, FontStyle.Bold);

                groupBox1.Controls.Add(c);
                c.Show();
                c.Click += C_Click;
            }
            FrmSaleProduct.frmsale.setStyleColumnDataGriView();

        }
        void genDefaultProduct()
        {
            lsProductDefault = new List<Product>();
            foreach (Product p in listFullProduct)
            {
                if (p.CategoryId == listCategorDum[0].Id)
                {
                    Product pp = new Product();
                    pp.Text = p.productName;
                    pp.productCode = p.productCode;
                    pp.ProductPrice = p.ProductPrice;
                    pp.ForeColor = Color.Blue;
                    pp.id = p.id;
                    pp.productName = p.productName;
                    pp.Click += P_Click;
                    p.Text = p.productName;
                    lsProductDefault.Add(pp);
                }
            }
            grpDanhSachSanPham.Controls.Clear();
            genProductButtonInGroup(grpDanhSachSanPham, lsProductDefault, 4, 30, 20, 56, 125, 5, 3);
        }
        void genHotProduct()
        {
            int SoSanPhamHot = 12;
            String nameP = "";
            grbGenHotProduct.Controls.Clear();

            lsProductHot = new List<Product>();

            Random r = new Random();
            int total = 0;

            int kk = 0;
            for (int ii = 0; ii < SoSanPhamHot;)
            {
                int m = r.Next(0, 60);
                Product pp = listFullProduct[m];
                if (pp != null)
                {
                    String mm = pp.productName;
                    //if ()
                    var ll = lsProductHot.Where(t => t.productName.Equals(mm));
                    if (ll == null || ll.Count() == 0)
                    {
                        lsProductHot.Add(pp);
                        nameP += ", -" + ii + pp.productName;
                        //  ii++;
                        kk++;
                        ii++;
                        Text = "Đếm  " + kk;
                    }

                }

            }
            int i = 0;
            int top = 20;
            int left = 13;
            int j = 0;

            foreach (Product p in lsProductHot)
            {
                p.Text = p.productName;
                p.Width = 125;
                p.Height = 50;
                FontStyle f = FontStyle.Bold;
                p.Font = new Font("Tahoma", 10, FontStyle.Bold);
                p.TextAlign = ContentAlignment.MiddleCenter;
                p.ForeColor = Color.Blue;
                //  p.tinhtoan += caculatorOrder;
                p.Show();
                p.Click += P_Click;
                //p.tinhtoan += caculatorOrder;

            }

            genProductButtonInGroup(grbGenHotProduct, lsProductHot, 2, 30, 13, 55, 125, 7, 3);
            //  genProductButtonInGroup(grbHot, lsProductHot, 2, 20, 13, 50, 125, 10, 5);
            // genProductButtonInPanel(pnlHot, lsProductHot, 2, 20, 13, 50, 125, 10, 5);
            foreach (Product p in lsProductHot)
            {

                if (i >= 2) { i = 0; j++; }
                else
                {
                    //top = 20 + (50 + 10) * j;
                    //left = 10 + (135) * i;
                    //p.Top = top;
                    //p.Left = left;
                    //p.Text = p.productName;
                    //p.Width = 125;
                    //p.Height = 50;
                    //FontStyle f = FontStyle.Bold;
                    //p.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    //p.TextAlign = ContentAlignment.MiddleCenter;
                    //p.ForeColor = Color.Blue;
                    i++;
                }


            }
            richTextBox1.Text = nameP;

        }

        void genHotProduct<T>(GroupBox g, List<Product> lsT, int NumbeOfColumn, int top, int left, int ObjectH, int ObjectW, int ObjectLeftMargin, int ObjectTopMargin)
        { }


        void genHotProduct(GroupBox g, List<Product> lsT, int NumbeOfColumn, int top, int left, int objectHeight, int objectWidth, int objectLeftMargin, int objectTopMargin)
        {
            int rows, i = 0, j = 0, count = 0;
            rows = lsT.Count / NumbeOfColumn + 1;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < NumbeOfColumn; j++)
                {
                    try
                    {
                        Control p = lsT[count];
                        if (p != null)
                        {
                            p.Height = objectHeight;
                            p.Width = objectWidth;
                            p.Top = top + i * (objectHeight + objectTopMargin);
                            p.Left = left + j * (objectWidth + objectLeftMargin);
                            g.Controls.Add(p);
                            p.Show();
                        }

                        count++;
                    }
                    catch (Exception x) { }
                }
            }

        }

        int genProductButtonInGroup(GroupBox g, List<Product> lsT, int NumbeOfColumn, int top, int left, int objectHeight, int objectWidth, int objectLeftMargin, int objectTopMargin)
        {
            int rows, i = 0, j = 0, count = 0;
            rows = lsT.Count / NumbeOfColumn + 1;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < NumbeOfColumn; j++)
                {
                    try
                    {
                        Control p = lsT[count];
                        if (p != null)
                        {
                            p.Height = objectHeight;
                            p.Width = objectWidth;
                            p.Top = top + i * (objectHeight + objectTopMargin);
                            p.Left = left + j * (objectWidth + objectLeftMargin);
                            g.Controls.Add(p);
                            p.Show();
                        }

                        count++;
                    }
                    catch (Exception x) { }
                }
            }
            return rows * (objectHeight + objectTopMargin) + top;

        }
        int genProductButtonInPanel(Panel g, List<Product> lsT, int NumbeOfColumn, int top, int left,
            int objectHeight, int objectWidth, int objectLeftMargin, int objectTopMargin)
        {
            int rows, i = 0, j = 0, count = 0;
            rows = lsT.Count / NumbeOfColumn + 1;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < NumbeOfColumn; j++)
                {
                    try
                    {
                        Control p = lsT[count];
                        if (p != null)
                        {
                            p.Height = objectHeight;
                            p.Width = objectWidth;
                            p.Top = top + i * (objectHeight + objectTopMargin);
                            p.Left = left + j * (objectWidth + objectLeftMargin);
                            g.Controls.Add(p);
                            p.Show();
                        }

                        count++;
                    }
                    catch (Exception x) { }
                }
            }
            return rows * (objectHeight + objectTopMargin) + top;

        }


        private void C_Click(object sender, EventArgs e)
        {

            int i = 0;
            int top = 20;
            int left = 20;
            int j = 0;
            //  throw new NotImplementedException();
            grpDanhSachSanPham.Controls.Clear();
            Category c = (Category)sender;
            Text = " " + c.Text + ", id :" + c.Id;
            List<Product> ls = SwingShop_.DataDumy.DataGetFromDumy.getListtProductDumy();
            List<Product> listP = ls.Where(m => m.CategoryId == c.Id).ToList();
            ShowListProduct(listP);
            //       foreach ( Product p in listP)
            //    {

            //            top = 20 + (50 + 10) * j;
            //            left = 10 + (135) * i;
            //            p.Top = top;
            //            p.Left = left;
            //            p.Text = p.productName;
            //            p.Width = 125;
            //            p.Height = 50;
            //            FontStyle f = FontStyle.Bold;
            //            p.Font = new Font("Tahoma", 10, FontStyle.Bold);
            //            p.TextAlign = ContentAlignment.MiddleCenter;
            //            p.ForeColor = Color.Blue;
            //            p.Click += P_Click;
            //           // p.tinhtoan += caculatorOrder;
            //            i++;
            //    }
            //    grpDanhSachSanPham.Controls.Clear();
            //    genProductButtonInGroup(grpDanhSachSanPham, listP, 4,30, 20,56, 125,5,3);
        }
        void ShowListProduct(List<Product> listP)
        {

            foreach (Product p in listP)
            {

                p.Text = p.productName;
                p.Width = 125;
                p.Height = 50;
                FontStyle f = FontStyle.Bold;
                p.Font = new Font("Tahoma", 10, FontStyle.Bold);
                p.TextAlign = ContentAlignment.MiddleCenter;
                p.ForeColor = Color.Blue;
                p.Click += P_Click;
            }
            grpDanhSachSanPham.Controls.Clear();
            genProductButtonInGroup(grpDanhSachSanPham, listP, 4, 30, 20, 56, 125, 5, 3);

        }
        int ZoneIdSelected = 1;
        int TableSelected = 1;
        public void setKhuBan(String tenKhuBan, int ZoneID, int tableID)
        {
            lblKhuBanZoneTable.Text = tenKhuBan;
            ZoneIdSelected = ZoneID;
            TableSelected = tableID;
        }

        private void P_Click(object sender, EventArgs e)
        {
            Product p = (Product)sender;
            FrmSaleProduct.addSanPham(p);
           // dgrProductSelected.DataSource = FrmSaleProduct.listItemSelected_;
            FrmSaleProduct.frmsale.caculatorOrder();
            showOnRichTechBox();
        }
        // Chọn khu vực chọn bàn .  0397268507
        FrmSelectZoneAndTable fselectTable = null;
        private void btnSelectZone_Table_Click(object sender, EventArgs e)
        {
            if (fselectTable == null)
               fselectTable = new FrmSelectZoneAndTable();
            fselectTable.ShowDialog();
        }
        static int TongSoSanPham = 0;
 
        public int getNumberOfProduct()
        {
            int number = (int)txtNumberOfSelected.Value;
            txtNumberOfSelected.Value = 0;
            numberOfSelected = "0";
            return number == 0 ? 1 : number;
        }
        //====================================================================
        public static void setFont(RichTextBox r, String data, Font font)
        {
            // String t = "  + " + textBox1.Text;
            int position = r.Text.Length;
            r.AppendText("\n" + data);
            r.Select(position + 1, data.Length - 1);
            r.SelectionFont = font;
            r.SelectionColor = Color.Black;

        }
        static Random random = new Random();
        public static bool addSanPham(Product p)
        {

            //  FrmSaleProduct.frmsale.setStyleColumnDataGriView();
            int numberOfProduct = FrmSaleProduct.frmsale.getNumberOfProduct();

            if (p.CategoryId == 8 || p.IsTopUp != 0)
            {
                Product pTop = new Product();
                pTop.IsTopUp = 1;
                pTop.productName = p.productName;
                pTop.ProductPrice = p.ProductPrice;
                //pTop.ProductQuantity = FrmSaleProduct.frmsale.numberOfSelectedInt;
              //  Product parent = DataLiveCurent.order_DonHang_Curent.listProductSelected.Where(p => p.ParentProduct == pTop.ParentProduct).FirstOrDefault();
                pTop.CategoryId = p.CategoryId;
                // pTop.pR
                pTop.ParentProduct = FrmSaleProduct.curentProductParentId;
                pTop.ProductQuantity = curentProductParent.ProductQuantity;
                //pTop.ProductQuantity = 
                //  FrmSaleProduct.frmsale. order_donHang_Curent.listProductToppingSelected.Add(pTop);
                DataLiveCurent.order_DonHang_Curent.listProductToppingSelected.Add(pTop);
                FrmSaleProduct.frmsale.Text = "+ Topping: " + pTop.productName + ", curentId:" + FrmSaleProduct.frmsale.productCurent.id + ", ";
            }
            else
            {
                Product p10 = new Product();
                p10.IsTopUp = 0;
                p10.productName = p.productName;
                p10.ProductPrice = p.ProductPrice;
                p10.ProductQuantity = FrmSaleProduct.frmsale.numberOfSelectedInt;
                p10.id = p.id;
                p10.CategoryId = p.CategoryId;
                FrmSaleProduct.frmsale.productCurent = p;
                FrmSaleProduct.curentProductId = p.id;
                //  FrmSaleProduct.frmsale.listProductSelected.Add(p10);
                DataLiveCurent.order_DonHang_Curent.listProductSelected.Add(p10);
                p10.ParentProduct = random.Next(1000,1300) ;////FrmSaleProduct.frmsale.listProductSelected.Count();
                FrmSaleProduct.curentProductParentId = (int)p10.ParentProduct;
                FrmSaleProduct.curentProductParent = p10;  //
                FrmSaleProduct.productTypeIfShipCode = p10;
                FrmSaleProduct.frmsale.Text = "+ Product: " + p10.productName + ", curentId:" + ", " + p10.id;
            }
            FrmSaleProduct.frmsale.numberOfSelectedInt = 1;
            if (p.IsTopUp == 0)
            {
                TongSoSanPham += numberOfProduct;
             //   mm.SoTT = listItemSelected_.Count;
            }
            FrmSaleProduct.frmsale.lblTongSoSanPham.Text = "" + TongSoSanPham;
            //FrmSaleProduct.frmsale.set_column();
            return true;
        }

        public void SetStatusRichTextBox()
        {
          //  richTextBox2.Enabled = false;
        }


        public void caculatorOrder()
        {
            int tongtien = 0;
            // foreach ( Product p in listProductSelected)
            foreach (Product p in DataLiveCurent.order_DonHang_Curent.listProductSelected)
            {
                int tt = p.ProductQuantity * (int)p.ProductPrice;
                tongtien += tt;

            }
            // foreach (Product p in listProductToppingSelected)
            foreach (Product p in DataLiveCurent.order_DonHang_Curent.listProductToppingSelected)
            {
                int tt = p.ProductQuantity * (int)p.ProductPrice;
                tongtien += tt;

            }

            lblThanhTien.Text = "" + tongtien;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSoTienNhan_TextChanged(object sender, EventArgs e)
        {
            //String mm = txtSoTienNhan.Text;
            //  String m = String.Format("", mm);try 
            try
            {
                double temp = Convert.ToDouble(txtSoTienNhan.Text);
                txtSoTienNhan.Text = temp.ToString("#,###");
                txtSoTienNhan.Focus();
            }
            catch (Exception x) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            genHotProduct();
        }
        private void btnNumber00_Click(object sender, EventArgs e)
        {
            numberOfSelected += "0"; getNumberOfSelectedItem();

        }

        private void btnNumber01_Click(object sender, EventArgs e)
        {
            numberOfSelected += "1"; getNumberOfSelectedItem();
        }

        private void btnNumber02_Click(object sender, EventArgs e)
        {
            numberOfSelected += "2"; getNumberOfSelectedItem();
        }

        private void btnNumber03_Click(object sender, EventArgs e)
        {
            numberOfSelected += "3"; getNumberOfSelectedItem();
        }

        private void btnNumber04_Click(object sender, EventArgs e)
        {
            numberOfSelected += "4"; getNumberOfSelectedItem();
        }

        private void btnNumber05_Click(object sender, EventArgs e)
        {
            numberOfSelected += "5"; getNumberOfSelectedItem();
        }

        private void btnNumber06_Click(object sender, EventArgs e)
        {
            numberOfSelected += "6"; getNumberOfSelectedItem();
        }

        private void btnNumber07_Click(object sender, EventArgs e)
        {
            numberOfSelected += "7"; getNumberOfSelectedItem();
        }

        private void btnNumber08_Click(object sender, EventArgs e)
        {
            numberOfSelected += "8"; getNumberOfSelectedItem();
        }

        private void btnNumber09_Click(object sender, EventArgs e)
        {
            numberOfSelected += "9"; getNumberOfSelectedItem();
        }

        private void btnNumberClearX_Click(object sender, EventArgs e)
        {
            numberOfSelected = "0";
            numberOfSelectedInt = 0;
            txtNumberOfSelected.Value = 0;
            getNumberOfSelectedItem();
        }
        void getNumberOfSelectedItem()
        {
            try
            {
                numberOfSelectedInt = Int32.Parse(numberOfSelected);
                txtNumberOfSelected.Value = numberOfSelectedInt;
            }
            catch (Exception x) { }
        }

        private void btnTaiCho_Click(object sender, EventArgs e)
        {
            LoaiDonHangTaiCHo_MangVe = 0;
            // foreach (Product p in listProductSelected) {
            foreach (Product p in DataLiveCurent.order_DonHang_Curent.listProductSelected)
            {
                if (p.LineIndex== CurentLineSelectInRichTextBox )
                {
                    String mm1 = p.productName.Replace("(T)", "");
                    String mm2 = mm1.Replace("(E)", "");
                    String mm3 = mm2.Replace("(S)", "");
                    String TaiCho = mm3 + "(E)";
                    p.productName =TaiCho;
                }
            }
            showOnRichTechBox();
            lblLoaiDonHangTaiCHoMangVe.Text = "Tại chỗ";
        }

        private void btnMangVe_Click(object sender, EventArgs e)
        {
            LoaiDonHangTaiCHo_MangVe = 1;
          //  foreach (Product p in listProductSelected)
              foreach (Product p in DataLiveCurent.order_DonHang_Curent.listProductSelected)
                {
                if (p.LineIndex == CurentLineSelectInRichTextBox)
                {
                    String mm1 = p.productName.Replace("(S)", "");
                    String mm2 = mm1.Replace("(E)", "");
                    String mm3 = mm2.Replace("(S)", "");
                    // String TaiCho = mm2 + "(S)";
                    String TaiCho = mm3 + "(T)";
                    p.productName = TaiCho;
                }
            }
            showOnRichTechBox();
            lblLoaiDonHangTaiCHoMangVe.Text = "Mang về";
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            LoaiDonHangTaiCHo_MangVe = 2;
            //  foreach (Product p in listProductSelected)
            foreach (Product p in DataLiveCurent.order_DonHang_Curent.listProductSelected)
            {
                if (p.LineIndex == CurentLineSelectInRichTextBox)
                {
                    String mm1 = p.productName.Replace("(T)","") ;
                    String mm2 = mm1.Replace("(E)", "");
                    String mm3 = mm2.Replace("(S)", "");
                    String TaiCho = mm3 + "(S)";
                    p.productName = TaiCho;
                }
            }
            showOnRichTechBox();
            lblLoaiDonHangTaiCHoMangVe.Text = "Ship đi";
        }

        public void setStyleColumnDataGriView()
        {
           // dgrProductSelected.AutoGenerateColumns = false;
            //  DataGridViewColumn stt = new DataGridViewColumn(new DataGridViewTextBoxColumn());
            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn();
            stt.HeaderText = "SốTT";
            stt.Width = 42;
            stt.DataPropertyName = "SoTT"; // Ten, SoLuong, Gia,ThanhTien , IsToppping
            DataGridViewTextBoxColumn Ten = new DataGridViewTextBoxColumn();
            Ten.HeaderText = "Tên";
            Ten.Width = 160;
            Ten.DataPropertyName = "Ten"; // Ten, SoLuong, Gia,ThanhTien , IsToppping

            DataGridViewTextBoxColumn SoLuong = new DataGridViewTextBoxColumn();
            SoLuong.HeaderText = "Sốlượng";
            SoLuong.Width = 55;
            SoLuong.DataPropertyName = "SoLuong"; // Ten, SoLuong, Gia,ThanhTien , IsToppping

            DataGridViewTextBoxColumn gia = new DataGridViewTextBoxColumn();
            gia.HeaderText = "Giá";
            gia.Width = 65;
            gia.DataPropertyName = "Gia"; // Ten, SoLuong, Gia,ThanhTien , IsToppping

            DataGridViewTextBoxColumn thanhtien = new DataGridViewTextBoxColumn();
            thanhtien.HeaderText = "ThànhTiền";
            thanhtien.Width = 110;
            thanhtien.DataPropertyName = "ThanhTien"; // Ten, SoLuong, Gia,ThanhTien , IsToppping
            //dgrProductSelected.Columns.Add(stt);
            //dgrProductSelected.Columns.Add(Ten);
            //dgrProductSelected.Columns.Add(SoLuong);
            //dgrProductSelected.Columns.Add(gia);
            //dgrProductSelected.Columns.Add(thanhtien);
        }

      

        private void btnInHoaDon1_Click(object sender, EventArgs e)
        {
            inHoaDon1();
        }

        void inHoaDon1()
        {
            PrintDocument pd = new PrintDocument();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            pd.PrintPage += Pd_PrintPage;
            ppd.ShowDialog();
        }

        int x_left = 20;
        int y_top = 20;
        String S_p_name = "   + #name        ";
        String S_topping = "";
        // String s0="", s1="", s2="", s3="";
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // throw new NotImplementedException();

            y_top = 10;
            x_left = 20;
            //  foreach (Product p in listProductSelected)
            foreach (Product p in DataLiveCurent.order_DonHang_Curent.listProductSelected)
            {
                String s0 = " + " + p.productName + "     ";
                // s1 = s0.PadLeft(33)+ p.ProductQuantity + "x" + p.ProductPrice;
                String s1 = s0.PadRight(38) + p.ProductQuantity + "x" + p.ProductPrice;
                int kk = (int)p.ProductPrice * p.ProductQuantity;
                String s2 = s1.PadRight(48) + "     " + kk;
                richTextBox1.AppendText("\n" + s2);
                e.Graphics.DrawString(s2, fontProduct, new SolidBrush(Color.Black), 0, y_top += 30);
                // Khi  đối tượng có topUp thì hasTopup là ID cua productTopup . 

                 //foreach (Product p0 in listProductToppingSelected)
                 foreach (Product p0 in DataLiveCurent.order_DonHang_Curent.listProductToppingSelected)
                    {
                    // String ss = "          - " + p.productName + "      " + p.ProductQuantity + "x" + p.ProductPrice + "       " + p.ProductQuantity * p.ProductPrice;
                    String s20 = "";
                    if ((int)p0.ParentProduct == p.id)
                    {
                        s0 = "      - " + p0.productName + "       ";
                        s1 = s0.PadRight(36) + p0.ProductQuantity + "x" + p0.ProductPrice; ;
                        // s2 = s1.PadLeft(38) +"      "+ (p0.ProductPrice * p0.ProductQuantity);
                        s20 += s1 + "      " + (p0.ProductPrice * p0.ProductQuantity);
                        richTextBox1.AppendText("\n" + s20);
                        e.Graphics.DrawString(s20, fontTopping, new SolidBrush(Color.Black), 20, y_top += 20);
                    }
                }

            }

            
        }
      public  void showOnRichTechBox()
        {
            String temp = "Data ";
            richTextBox2.Text = "";
            int countIndexProduct = 0;
            //   foreach (Product p in listProductSelected) 
            foreach (Product p in DataLiveCurent.order_DonHang_Curent.listProductSelected)
            {
                countIndexProduct++;
                String s1="";
                String s0 = "  + " + p.productName + "  ";             
                String s_cot2 = addMoreSpace(s0, fontProduct,cot2);
                String s_cot3 = addMoreSpace(s_cot2 + p.ProductQuantity + "x" + p.ProductPrice, fontProduct, cot4) ;
                int kk = p.ProductQuantity * (int)p.ProductPrice;
                String s2 = s_cot3 + kk;
                int vt1 = richTextBox2.Text.Length;
                if (countIndexProduct < 2) {
                    richTextBox2.AppendText("\n" + s2 + "    "); 
                } 
                else { 
                    richTextBox2.AppendText("\n\n" + s2 + "    ");
                }               
                richTextBox2.Select(vt1 + 1, s2.Length +3);
                richTextBox2.SelectionFont = fontProduct;
                p.LineIndex = richTextBox2.GetLineFromCharIndex(vt1 + s2.Length-2);
                temp = "# LineIndex: " + p.LineIndex + ", Name: " + p.productName; 
                // Khi  đối tượng có topUp thì parentProduct là  parentProduct cua topUp . 
                s0 = "";
                //foreach (Product p0 in listProductToppingSelected)
                foreach (Product p0 in DataLiveCurent.order_DonHang_Curent.listProductToppingSelected)
                {
                    String s20 = "";
                    if ((int)p0.ParentProduct == p.ParentProduct)
                    {
                        s0 = "\n       - " + p0.productName + "  ";
                        s1 = addMoreSpace(s0, fontTopping, cot2);
                        s2 = addMoreSpace (s1+ p0.ProductQuantity + "x" + p0.ProductPrice ,fontTopping,cot4);
                        s20 = s2 + (p0.ProductQuantity * p0.ProductPrice);
                        int vt = richTextBox2.Text.Length;
                        richTextBox2.AppendText( s20+"");
                        richTextBox2.Select(vt + 1, s20.Length - 1);
                        richTextBox2.SelectionFont = fontTopping;
                        p0.LineIndex = richTextBox2.GetLineFromCharIndex(vt + s20.Length-2);
                        temp = "# LineIndex: " + p0.LineIndex + ", Name: " + p0.productName;
                    }
                }
            }
            Text = temp;
        }
         
        // pass wifi Aptech .  cc50fd77f8
        private void btnInHoaDon2_Click(object sender, EventArgs e)
        {
            showOnRichTechBox();
        }

        private void btnEnableRichTechBox_Click(object sender, EventArgs e)
        {
           // richTextBox2.Enabled = true;
        }
        public string GetCurrentLineInRichTextBoxWhenClick(RichTextBox richTextbox)
        {
            int charIndex = richTextbox.SelectionStart;
            int currentLineNumber = richTextbox.GetLineFromCharIndex(charIndex);
            if (currentLineNumber < richTextbox.Lines.Length)
            {
                String data = "Line: " + currentLineNumber + ", value : " + richTextbox.Lines[currentLineNumber];
                // return richTextbox.Lines[currentLineNumber];
                HighlightLine(richTextbox, currentLineNumber, Color.AliceBlue);
                Text = "Data:# LineIndex: " + currentLineNumber + "value: " + richTextbox.Lines[currentLineNumber];
                CurentLineSelectInRichTextBox = currentLineNumber;
                return data;
            }
            
            return "null"; //  string.Empty;
        }

        public void HighlightLine(RichTextBox richTextBox, int index, Color color)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = richTextBox.BackColor;
            var lines = richTextBox.Lines;
            if (index < 0 || index >= lines.Length)
                return;
            var start = richTextBox.GetFirstCharIndexFromLine(index);  // Get the 1st char index of the appended text
            var length = lines[index].Length;
            richTextBox.Select(start, length);                 // Select from there to the end
            richTextBox.SelectionBackColor = color;
        }

        private void richTextBox2_Click(object sender, EventArgs e)
        {  
            GetCurrentLineInRichTextBoxWhenClick(richTextBox2);
            Product pp = null;
            try
            {
                // var ppS = listProductSelected.Where(p => p.LineIndex == CurentLineSelectInRichTextBox);
                var ppS = DataLiveCurent.order_DonHang_Curent.listProductSelected.Where(p => p.LineIndex == CurentLineSelectInRichTextBox);
                pp = ppS.First();
            }catch ( Exception x) { }

            if(pp != null) {             
                FrmSaleProduct.curentProductParentId = (int)pp.ParentProduct;
                FrmSaleProduct.curentProductParent = pp;
            }
            else
            {               
               // FrmSaleProduct.curentProductParentId = 0;
            }
            richTextBox2.SelectionProtected = true;
        }

        String addMoreSpace(String data, Font f, int pixelsOnLeft, Graphics g)
        {

            int mm = 0;
            int m = (int)g.MeasureString(data, f).Width;
            String text = data;
            while (mm < pixelsOnLeft)
            {
                text += " ";
                mm = (int)g.MeasureString(data, f).Width;
            }
            return text;
        }
        String addMoreSpace(String data, Font f, int pixelsOnLeft)
        {
            int i = 0, kk = 0; ;
            int mm = 0;
         //   int m = (int)g.MeasureString(data, f).Width;
            String text = data;
            while (mm < pixelsOnLeft)
            {
                i++;               
                kk = (int)g.MeasureString(data, fontTopping).Width;            
                text += ".";
                mm = (int)g.MeasureString(text, f).Width;
                i++;
               // String temp = text.Replace(".", " ");
              //  text = temp;
            }
            return text;
        }

        private void btnProductCong1_Click(object sender, EventArgs e)
        {
           // int indexLine_ = CurentLineSelectInRichTextBox;          
            Product pp = null;
            pp = getCurrentSelectedProductWhenClickRichTechBox();
            if (pp != null)
            {
                if (pp.IsTopUp == 0)
                {
                    int quantity = pp.ProductQuantity;
                    pp.ProductQuantity += 1;
                    foreach (Product pp_ in DataLiveCurent.order_DonHang_Curent.listProductToppingSelected)
                    {
                        if (pp.ParentProduct == pp_.ParentProduct)
                        {
                            pp_.ProductQuantity += pp_.ProductQuantity/quantity;
                        }
                    }
                }
                else
                {
                    foreach( Product pp_  in DataLiveCurent.order_DonHang_Curent.listProductSelected)
                    {
                        if( pp.ParentProduct == pp_.ParentProduct)
                        {
                            pp.ProductQuantity  += pp_.ProductQuantity;
                        }
                    }
                }
            }
          
            showOnRichTechBox();
            caculatorOrder();
        }

        private void btnProductTru1_Click(object sender, EventArgs e)
        {
            Product pp = null;
            pp = getCurrentSelectedProductWhenClickRichTechBox();
            if (pp != null)
            {


                // pp.ProductQuantity -= 1;
                if (pp.IsTopUp == 0)
                {
                    if (pp.ProductQuantity > 1)
                    {
                        int quantity = pp.ProductQuantity;
                        pp.ProductQuantity -= 1;
                        foreach (Product pp_ in DataLiveCurent.order_DonHang_Curent.listProductToppingSelected)
                        {
                            if ( pp_.ParentProduct == pp.ParentProduct)
                            {
                                if (pp_.ProductQuantity > pp.ProductQuantity)
                                {
                                    pp_.ProductQuantity -= pp_.ProductQuantity / quantity;
                                    if (pp_.ProductQuantity < 0) { pp_.ProductQuantity = 0; }
                                }
                            }
                        }
                    }
                }
                else
                {
                  foreach (Product pp_ in DataLiveCurent.order_DonHang_Curent.listProductSelected)
                    {
                        if (pp.ParentProduct == pp_.ParentProduct)
                        {  if (pp.ProductQuantity > pp_.ProductQuantity)
                            {
                                pp.ProductQuantity -= pp_.ProductQuantity;
                                if(pp.ProductQuantity<0) { pp.ProductQuantity = 0; }
                            }
                        }
                    }
                }

                
            }
            //CurentLineSelectInRichTextBox = -1;
            showOnRichTechBox();
            caculatorOrder();
        }

        private void btnProductXoa_Click(object sender, EventArgs e)
        {
            Product pp = null;
            pp = getCurrentSelectedProductWhenClickRichTechBox();
            if(pp.IsTopUp > 0) {
             DataLiveCurent.order_DonHang_Curent.listProductToppingSelected.Remove(pp);
            }
            else { 
               // listProductSelected.Remove(pp);
               DataLiveCurent.order_DonHang_Curent. listProductSelected.Remove(pp);
            }          
            //CurentLineSelectInRichTextBox = -1;
            showOnRichTechBox();
            caculatorOrder();
        }
        private  Product getCurrentSelectedProductWhenClickRichTechBox()
        {
            Product pp = null;
           // foreach (Product p1 in listProductSelected)
           foreach (Product p1 in DataLiveCurent.order_DonHang_Curent. listProductSelected)
                {
                if (p1.LineIndex == CurentLineSelectInRichTextBox)
                {
                    pp = p1;
                    break;
                }
            }
            if (pp == null)
            {
                // foreach (Product p2 in listProductToppingSelected)
                foreach (Product p2 in DataLiveCurent.order_DonHang_Curent. listProductToppingSelected)
                {
                    if (p2.LineIndex == CurentLineSelectInRichTextBox)
                    {
                        pp = p2;
                        break;
                    }
                }
            }
            return pp;
        }

        private void btnOrderETaiCho_Click(object sender, EventArgs e)
        {
            if(order_donHang_Curent !=null)
            {
                order_donHang_Curent.TypeOfShipping = 0; //  E-Tai cho
            }
        }

        private void btnO_T_MangVe_Click(object sender, EventArgs e)
        {
            if (order_donHang_Curent != null)
            {
                order_donHang_Curent.TypeOfShipping = 1; //  T-mang ve
            }
        }

        private void btnO_S_Ship_Click(object sender, EventArgs e)
        {

            if (order_donHang_Curent != null)
            {
                order_donHang_Curent.TypeOfShipping = 2; //  S-Ship đi
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           DataLiveCurent.order_DonHang_Curent. listProductSelected.Clear();
            DataLiveCurent.order_DonHang_Curent.listProductToppingSelected.Clear();
            showOnRichTechBox();
            caculatorOrder();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataLiveCurent.order_DonHang_Curent.trangThaiHoanThanh = Order_DonHang.TrangThaiHoanThanh.DaDatXong;
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            DataLiveCurent.order_DonHang_Curent.trangThaiHoanThanh = Order_DonHang.TrangThaiHoanThanh.DaThanhToan;
        }

        private void btnXacNhanGiaoDon_Click(object sender, EventArgs e)
        {
            DataLiveCurent.order_DonHang_Curent.trangThaiHoanThanh = Order_DonHang.TrangThaiHoanThanh.DaGiaoXong;
        }
    }
}
