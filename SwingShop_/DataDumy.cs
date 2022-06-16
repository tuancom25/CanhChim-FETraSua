using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwingShop_.Modelss;


namespace SwingShop_.DataDumy
{
  public   class DataGetFromDumy
    {
        public static  List<Zone> getListZoneDumy()
        {
            List<Zone> ls = new List<Zone>();
            var z1 = new Zone(1, "Khu 1", "ABC");
            var z2 = new Zone(2, "Khu Tâng2", "ABD");
            var z3 = new Zone(3, "Khu hiên hè ", "ABF");
            var z4 = new Zone(4, "Khu Phòng lạnh", "ABE");
            z1.shpTables = new List<TableZone>();
            z1.shpTables.Add(new TableZone(1, " Bàn 11", 2, z1.zoneName));
            z1.shpTables.Add(new TableZone(1, " Bàn 12", 2, z1.zoneName));
            z1.shpTables.Add(new TableZone(1, " Bàn 13", 2, z1.zoneName));
            z1.shpTables.Add(new TableZone(1, " Bàn 14", 2, z1.zoneName));
            z1.shpTables.Add(new TableZone(1, " Bàn 15", 2, z1.zoneName));
            ls.Add(z1);
            z2.shpTables = new List<TableZone>();
            z2.shpTables.Add(new TableZone(1, " Bàn 21", 2, z2.zoneName));
            z2.shpTables.Add(new TableZone(1, " Bàn 22", 2, z2.zoneName));
            z2.shpTables.Add(new TableZone(1, " Bàn 23", 2, z2.zoneName));
            z2.shpTables.Add(new TableZone(1, " Bàn 24", 2, z2.zoneName));
            z2.shpTables.Add(new TableZone(1, " Bàn 25", 2, z2.zoneName));
            ls.Add(z2);
            z3.shpTables = new List<TableZone>();
            z3.shpTables.Add(new TableZone(1, " Bàn 31", 2, z3.zoneName));
            z3.shpTables.Add(new TableZone(1, " Bàn 32", 2, z3.zoneName));
            z3.shpTables.Add(new TableZone(1, " Bàn 33", 2, z3.zoneName));
            z3.shpTables.Add(new TableZone(1, " Bàn 34", 2, z3.zoneName));
            z3.shpTables.Add(new TableZone(1, " Bàn 35", 2, z3.zoneName));
            ls.Add(z3);
            z4.shpTables = new List<TableZone>();
            z4.shpTables.Add(new TableZone(1, " Bàn 41", 2, z4.zoneName));
            z4.shpTables.Add(new TableZone(1, " Bàn 42", 2, z4.zoneName));
            z4.shpTables.Add(new TableZone(1, " Bàn 43", 2, z4.zoneName));
            z4.shpTables.Add(new TableZone(1, " Bàn 44", 2, z4.zoneName));
            z4.shpTables.Add(new TableZone(1, " Bàn 45", 2, z4.zoneName));
            ls.Add(z4);
            return ls;
        }
        public static List<TableZone> getLisstTableZOneDumy()
        {
            List<TableZone> ls = new List<TableZone>();
           

            return ls;
        }
        public static List<TableZoneButton> getListTablZoneButton()
        {
            List<TableZoneButton> ls = new List<TableZoneButton>();
            return ls;
        }
      //  public Product(int productId, string productName, long productPrice, long productPrice2, long productPrice3, long productPrice4, int productQuantity, long categoryId, int hasMultiSize, int hasTopUp, int isTopUp)
        public static List<Product> getListtProductDumy() {
            List<Product> ls = new List<Product>();

           //------------------- Đồ uống lạnh - category 1 
            ls.Add(new Product(1, "Gạo sen đậu xanh", 15, 20, 25, 25, 1, 1, 1, 1, 0));
            ls.Add(new Product(2, "Xoài nha đam", 15, 20, 25, 25, 1, 1, 1, 1, 0));
            ls.Add(new Product(3, "Dưa hấu nha đam", 15, 20, 25, 25, 1, 1, 1, 1, 0));
            ls.Add(new Product(4, "Sữa chua nha đam", 15, 20, 25, 25, 1, 1, 1, 1, 0));
            ls.Add(new Product(5, "Sữa dừa thạch có thơm", 15, 20, 25, 25, 1, 1, 1, 1, 0));
            ls.Add(new Product(6, "Trà chanh quất mật ong", 15, 20, 25, 25, 1, 1, 1, 1, 0));

            ls.Add(new Product(10, "Nước chanh", 15, 20, 25, 25, 1, 1, 1, 1, 0));
            ls.Add(new Product(11, "Nước quất", 15, 20, 25, 25, 1, 1, 1, 1, 0));
            ls.Add(new Product(12, "Nước chanh leo", 15, 20, 25, 25, 1, 1, 1, 1, 0));
            ls.Add(new Product(13, "Nước cam", 15, 20, 25, 25, 1, 1, 1, 1, 0));
            ls.Add(new Product(14, "Chanh leo sữa", 15, 20, 25, 25, 1, 1, 1, 1, 0));
            ls.Add(new Product(15, "Me đá", 15, 20, 25, 25, 1, 1, 1, 1, 0));
            //-------------------Đồ uống nóng  category 2 
           // Product pp = new Product()
            ls.Add(new Product(16, "Trà chanh", 15, 20, 25, 25, 2, 2, 1, 1, 0));
            ls.Add(new Product(17, " Trà Quất", 15, 20, 25, 25, 2, 2, 1, 1, 0));
            ls.Add(new Product(18, " Trà Quế", 15, 20, 25, 25, 2, 2, 1, 1, 0));
            ls.Add(new Product(19, " Trà gừng", 15, 20, 25, 25, 2, 2, 1, 1, 0));
            ls.Add(new Product(20, " Trà Gừng mật ong", 15, 20, 25, 25, 2, 2, 1, 1, 0));
            ls.Add(new Product(21, " Trà gừng ô mai", 15, 20, 25, 25, 2, 2, 1, 1, 0));
            ls.Add(new Product(22, " Trà Chanh gừng", 15, 20, 25, 25, 2, 2, 1, 1, 0));
            ls.Add(new Product(23, " Trà Quất quế mật ong", 15, 20, 25, 25, 2, 2, 1, 1, 0));
            ls.Add(new Product(24, " Gạo rang đậu xanh", 15, 20, 25, 25, 2, 2, 1, 1, 0));
            ls.Add(new Product(25, " Trà bưởi đỏ Yuzu", 15, 20, 25, 25, 2, 2, 1, 1, 0));
            ls.Add(new Product(26, " Trà Long nhãn", 15, 20, 25, 25, 2, 2, 1, 1, 0));
            //-------------- Trà hoa quả :  category 3 
            ls.Add(new Product(27, " Trà Chanh", 15, 20, 25, 25,1, 3, 1, 1, 0));
            ls.Add(new Product(28, " Trà Quất nha đam", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            ls.Add(new Product(29, " Trà chanh đào nhiệt đới", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            ls.Add(new Product(30, "Ngọt ngào trà(trái vải)", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            ls.Add(new Product(31, "Thanh bình trà(Trà đào)", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            ls.Add(new Product(32, " Trà thanh xuân(trái táo)", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            ls.Add(new Product(33, "Trà mơ màng(trái mơ)", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            ls.Add(new Product(34, "Ô long hawai", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            ls.Add(new Product(36, "Ô long dứa ômai", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            ls.Add(new Product(36, "Ô long xoài chanh leo", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            ls.Add(new Product(37, "Ô long chanh leo hồng", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            ls.Add(new Product(38, "Ô long dưa hấu bạc hà", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            ls.Add(new Product(39, "Trà đào cam sả bất bại", 15, 20, 25, 25, 3, 3, 1, 1, 0));
            //---------------- Caffe :   category 4
            ls.Add(new Product(40, "Cafe đen ", 15, 20, 25, 25, 4, 4, 1, 1, 0));
            ls.Add(new Product(41, "Cà phê nâu", 15, 20, 25, 25, 4, 4, 1, 1, 0));
            ls.Add(new Product(42, "Cafe Bạc sỉu ", 15, 20, 25, 25, 4, 4, 1, 1, 0));
            ls.Add(new Product(43, " Cafe cố dừa", 15, 20, 25, 25, 4, 4, 1, 1, 0));
            //-------------------- Nước ép sinh tố  :  category 5 
            ls.Add(new Product(44, "Nước ép cam cà rốt", 15, 20, 25, 25, 5, 5, 1, 1, 0));
            ls.Add(new Product(45, "Nước ép táo cóc", 15, 20, 25, 25, 5, 5, 1, 1, 0));
            ls.Add(new Product(46, "Nước ép dưa hấu", 15, 20, 25, 25, 5, 5, 1, 1, 0));
            ls.Add(new Product(47, "Sinh tố bơ", 15, 20, 25, 25, 5, 5, 1, 1, 0));
            ls.Add(new Product(48, "Sinh tố xoài", 15, 20, 25, 25, 5, 5, 1, 1, 0));
            ls.Add(new Product(49, "Sinh tố mẵng cầu", 15, 20, 25, 25, 5, 5, 1, 1, 0));

            // ----- Cacao   category 6 
            ls.Add(new Product(50, "Cacao Lắc", 15, 20, 25, 25, 6, 6, 1, 1, 0));
            ls.Add(new Product(51, "Cacao Mashmalow", 15, 20, 25, 25, 6, 6, 1, 1, 0));
            // Trà sữa  : category 7
            ls.Add(new Product(52, "Hồng Trà sữa", 15, 20, 25, 25, 7, 7, 1, 1, 0));
            ls.Add(new Product(53, " Trà sữa trân châu", 15, 20, 25, 25, 7, 7, 1, 1, 0));
            ls.Add(new Product(54, "Trà nhài sữa", 15, 20, 25, 25, 7, 7, 1, 1, 0));
            //---------Topping - :  category 8 - is topping
        ls.Add(new Product(55, "Đào miếng(2 miếng) ", 15, 20, 25, 25, 8, 8, 1, 1, 1));
            ls.Add(new Product(56, "Trân châu trắng", 15, 20, 25, 25, 8, 8, 1, 1, 1));
                    ls.Add(new Product(57, "Nha đam", 15, 20, 25, 25, 8, 8, 1, 1, 1));
                  ls.Add(new Product(58, "Thạch đào", 15, 20, 25, 25, 8, 8, 1, 1, 1));
             ls.Add(new Product(59, "Thạch tiên đào", 15, 20, 25, 25, 8, 8, 1, 1, 1));
            //--------- Sữa chua :  category 9  
            ls.Add(new Product(60, "Sữa chua Hạ long", 15, 20, 25, 25, 9, 9, 1, 1, 0));
                ls.Add(new Product(61, "Sữa chua Đào", 15, 20, 25, 25, 9, 9, 1, 1, 0));
               ls.Add(new Product(62, "Sữa chua Xoài", 15, 20, 25, 25, 9, 9, 1, 1, 0));
          ls.Add(new Product(63, "Sữa chua Chanh leo", 15, 20, 25, 25, 9, 9, 1, 1, 0));
            ls.Add(new Product(64, "Sữa chua Nha đam", 15, 20, 25, 25, 9, 9, 1, 1, 0));
            ls.Add(new Product(65, "Sữa chua đánh đá", 15, 20, 25, 25, 9, 9, 1, 1, 0));
           // ls.Add(new Product(1, "Sữa chua Hạ l", 15, 20, 25, 25, 3, 1, 1, 1, 0));


            return ls;
        }
        public static List<String> getListPhanQuyen()
        {
            List<String> ls = new List<string>();
            return ls;
        } 
        public static List<Category> getListCategory()
        {
            List<Category> ls = new List<Category>();
            return ls;
        }
        public List<UserEmployee> listUserEmployee()
        {
            List<UserEmployee> ls = new List<UserEmployee>();
            return ls;
        }
       static public List<Category> getListCategoryDummy()
        {
            List<Category> ls = new List<Category>();
           
            ls.Add(new Category(1, "Đồ Lạnh", 1, ""));
            ls.Add(new Category(2, "Đồ Uống Nóng", 1, ""));
            ls.Add(new Category(3, "Đồ Trà Hoa Quả", 1, ""));
            ls.Add(new Category(4, " Caffe ", 1, ""));
            ls.Add(new Category(5, "Nước Ép Sính Tố", 1, ""));
            ls.Add(new Category(6, " Cacao", 1, ""));
            ls.Add(new Category(7, " Trà Sữa", 1, ""));
            ls.Add(new Category(8, "Topping ", 1, ""));
            ls.Add(new Category(9, "Sữa chua ", 1, ""));

            return ls;
        }


    }
    public class DataGetFromServer
    {

    }
    public class OrderDonHang
    {
        public String Name;
        public String title;
        public String NgayThang;

    }
    public class  ObjectForPrint
    {
        String data;
        int X, Y;
        Font font;
        Color c = Color.Black;
        Brush choiVe = new SolidBrush(Color.Black);

    }
    public class OrderDonHangForPrint
    {
      public static  List<ObjectForPrint> listObjectForPrint = new List<ObjectForPrint>();
    }
}
