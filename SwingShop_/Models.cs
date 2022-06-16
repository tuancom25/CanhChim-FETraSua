using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwingShop_.Modelss
{
    class Models
    {
    }
    public delegate void TinhToan() ; 
    public class Product : System.Windows.Forms.Button
    {
       public event TinhToan tinhtoan;
        int productId;
        private String productName_;
        private String productCode_;
        private long productPrice;
        //private long productPrice2;
        //private long productPrice3;
        //private long productPrice4;

        private int productQuantity;
        private long supplierId;
        private long inputDate;
        private long lastUpdate;
        private long inputUser;
        private long lastUpdateUser;
        private int productStatus;
        private long parentProduct;
        private long categoryId;
        private int saleValue;

       // private int hasMultiSize;
        private int hasTopUp;
        private int isTopUp;
        private int isSale = 0;
        private int lineIndex = -1;
        private int typeOfShip_ = 0;  // 0:  taij cho, 1 mang ve, 2 ship di . 
        public Product() { }

        public Product(int productId, string productName__, long productPrice, long productPrice2, long productPrice3, long productPrice4, int productQuantity, long categoryId, int hasMultiSize, int hasTopUp, int isTopUp)
        {
            this.productId = productId;
            this.productName_ = productName__;
            this.productQuantity = productQuantity;
            this.productPrice = productPrice;
            this.categoryId = categoryId;
            this.hasTopUp = hasTopUp;
            this.isTopUp = isTopUp;
        }
        public int id { get => productId; set => productId = value; }
        public int LineIndex { get => lineIndex; set => lineIndex = value; }
        public string productName { get => productName_; set => productName_ = value; }
        public string productCode { get => productCode_; set => productCode_ = value; }

        public long ProductPrice { get => productPrice; set => productPrice = value; }
        public int ProductQuantity { get => productQuantity; set => productQuantity = value; }
        public long SupplierId { get => supplierId; set => supplierId = value; }
        public long InputDate { get => inputDate; set => inputDate = value; }

        public long LastUpdate { get => lastUpdate; set => lastUpdate = value; }
        public long InputUser { get => inputUser; set => inputUser = value; }
        public long LastUpdateUser { get => lastUpdateUser; set => lastUpdateUser = value; }
        public int ProductStatus { get => productStatus; set => productStatus = value; }
        public long ParentProduct { get => parentProduct; set => parentProduct = value; }
        public long CategoryId { get => categoryId; set => categoryId = value; }
     
        public int HasTopUp { get => hasTopUp; set => hasTopUp = value; }
        public int IsTopUp { get => isTopUp; set => isTopUp = value; }
        public int TypeOfShip_ { get => typeOfShip_; set => typeOfShip_ = value; }
    }

    public class Product_Post_Server
    {
        int _id;
        String _name;
        String _code;
        //name, price , isMultiPrice =0;  shopId ,hasTopUp,  isTopUp.
        int _price, _isMultiPrice = 0, _categoryId, _shopId = 3, _hasTopUp = 0, _isTopUp = 0;
        public Product_Post_Server() { }
        public Product_Post_Server(string name, String code, int price, int categoryId, int isMultiPrice, int shopId, int hasTopUp, int isTopUp)
        {
            _name = name;
            _code = code;
            _price = price;
            _isMultiPrice = isMultiPrice;
            _shopId = shopId;
            _hasTopUp = hasTopUp;
            _isTopUp = isTopUp;
            _categoryId = categoryId;
        }
        public Product_Post_Server(int id__, string name, String code, int price, int categoryId, int isMultiPrice, int shopId, int hasTopUp, int isTopUp)
        {
            _id = id__;
            _name = name;
            _code = code;
            _price = price;
            _isMultiPrice = isMultiPrice;
            _shopId = shopId;
            _hasTopUp = hasTopUp;
            _isTopUp = isTopUp;
            _categoryId = categoryId;
        }
        public int id { get => _id; set => _id = value; }
        public string name { get => _name; set => _name = value; }
        public string code { get => _code; set => _code = value; }
        public int price { get => _price; set => _price = value; }
        public int categoryId { get => _categoryId; set => _categoryId = value; }
        public int isMultiPrice { get => _isMultiPrice; set => _isMultiPrice = value; }
        public int shopId { get => _shopId; set => _shopId = value; }
        public int hasTopUp { get => _hasTopUp; set => _hasTopUp = value; }
        public int isTopUp { get => _isTopUp; set => _isTopUp = value; }
        //name, price , isMultiPrice =0;  shopId ,hasTopUp,  isTopUp.
    }
    public class ProductSelected
    {
        int productId;
        private String productName;
        private long productPrice;
        private int productQuantity;
        // private long parentProduct;
        // private long categoryId;
        //   private int saleValue;
        // private int hasMultiSize;


    }

    public class ModelItemTraSuaSelect
    {
        public int SoTT { get; set; }
        public String Ten { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }
        public int ThanhTien { get; set; }
        public int IsTopping { get; set; }
        public ModelItemTraSuaSelect()
        {
            //  int i = Customer.lsTraSua.Count;
            // SoTT = i + 1;
        }
    }


    public class ProductButton_ : System.Windows.Forms.Button
    {

    }
    public class ProductResponse
    {
        // responseCode":200,"message":"OK","data":{"content":[
        private int responseCode;
        private String message;
        private ProductData data;
        // private Object data;
        public int ResponseCode { get => responseCode; set => responseCode = value; }
        public string Message { get => message; set => message = value; }
        public ProductData Data { get => data; set => data = value; }
        // public Object Data { get => data; set => data = value; }
    }
    public class ProductData
    {
        List<Product> content; // = new List<Product>();
        public List<Product> Content { get => content; set => content = value; }
    }

    /*   */

 

    public class Zone {
        private int zoneId;
        private String _zoneName;
        //  private String zoneCode;
        public List<TableZone> _shpTables;
        public Zone() { }
        public Zone(int zoneId, String _zoneName)
        {
            this.zoneId = zoneId;
            this._zoneName = _zoneName;

        }
        public Zone(int zoneId, String _zoneName, String zoneCode)
        {
            this.zoneId = zoneId;
            this._zoneName = _zoneName;

        }

        public int id { get => zoneId; set => zoneId = value; }
        public String zoneName { get => _zoneName; set => _zoneName = value; }
        // public string ZoneCode { get => zoneCode; set => zoneCode = value; }
        public List<TableZone> shpTables { get => _shpTables; set => _shpTables = value; }
    }
    public class TableZone
    {
        private int tableId;
        private String _tableName;
        private int zoneId;
        String zoneName;
        int _numberOfSeat;

        public TableZone() { }
        public TableZone(int tableId, String _tableName, int zoneId, String zoneName, int _numberOfSeat)
        {
            this.tableId = tableId;
            this._tableName = _tableName;
            this.zoneId = zoneId;
            this.zoneName = zoneName;
            this._numberOfSeat = _numberOfSeat;
        }
        public TableZone(int tableId, String _tableName, int zoneId, String zoneName)
        {
            this.tableId = tableId;
            this._tableName = _tableName;
            this.zoneId = zoneId;
            this.zoneName = zoneName;
            // this._numberOfSeat = _numberOfSeat;
        }

        public int id { get => tableId; set => tableId = value; }
        public String tableName { get => _tableName; set => _tableName = value; }
        public int ZoneId { get => zoneId; set => zoneId = value; }
        public string ZoneName { get => zoneName; set => zoneName = value; }
        public int numberOfSeat { get => _numberOfSeat; set => _numberOfSeat = value; }
    }
    public class TableZoneButton : System.Windows.Forms.Button
    {
        private int tableId;
        private String tableName;
        private int zoneId;
        String zoneName;
        public   Order_DonHang order_DonHang = null;
        public FrmSelectZoneAndTable frmSelectZoneandTable;
        public int TableId { get => tableId; set => tableId = value; }
        public String TableName { get => tableName; set => tableName = value; }
        public int ZoneId { get => zoneId; set => zoneId = value; }
        public string ZoneName { get => zoneName; set => zoneName = value; }

        public TableZoneButton() { }

        public TableZoneButton(FrmSelectZoneAndTable frmSelectZoneandTable) {
            this.frmSelectZoneandTable = frmSelectZoneandTable;
            order_DonHang = new Order_DonHang();
            order_DonHang.tableZoneButton = this;
        }
    }
    public enum PhanQuyen { AD, AF, AM, AK, AS, AX, BA, AP, AC };
    public class UserLogin
    {
        List<PhanQuyen> listPhanQuyen = null;
        int ShopId;
        String ShopCode;
        List<String> listPhanQuyen2 = null;
        public class DonHangOrder { }
    }
    public class UserEmployee
    {

    }
    public class UserLoginRessonse
    {
        private int responseCode;
        private String message;
        private UserLoginRessonseDeltails data;

        public int ResponseCode { get => responseCode; set => responseCode = value; }
        public string Message { get => message; set => message = value; }
        public UserLoginRessonseDeltails Data { get => data; set => data = value; }
    }

    public class UserLoginRessonseDeltails
    {
        List<String> shops;
        List<String> allowedActions;
        String token;

        public List<string> Shops { get => shops; set => shops = value; }
        public List<string> AllowedActions { get => allowedActions; set => allowedActions = value; }
        public string Token { get => token; set => token = value; }
    }

    public class Order_Post {
        int _tableId;
        int _shopId;
        List<Item_Post> _items = new List<Item_Post>();

        public int tableId { get => _tableId; set => _tableId = value; }
        public int shopId { get => _shopId; set => _shopId = value; }
        public List<Item_Post> items { get => _items; set => _items = value; }
        public Boolean removeItem(int id)
        {
            Item_Post item = _items.Where(m => m.id == id).First();
            _items.Remove(item);
            return true;
        }
        public Boolean addItem(Item_Post p)
        {
            Item_Post item = _items.Where(m => m.id == p.id).First();
            //_items.Remove(item);
            if (item != null)
            {
                int increment = p.quantity;
                item.quantity += increment;
            } else
            {
                _items.Add(p);
            }
            return true;
        }
        public int GetTotalMoneyOfOrder() {
            int count = 0;
            foreach (Item_Post p in _items)
            {
                count += p.price * p.quantity;
            }
            return count;
        }

    }
    public class Item_Post
    {
        int _id;
        int _price;
        int _quantity;

        public Item_Post(int id, int price, int quantity)
        {
            _id = id;
            _price = price;
            _quantity = quantity;
        }

        public int id { get => _id; set => _id = value; }
        public int price { get => _price; set => _price = value; }
        public int quantity { get => _quantity; set => _quantity = value; }
    }

    public class OrderItemPrint
    {
        int _id;
        Color _fontColor;
        String _fontName = "";
        int _fontSize = 12;
        string _fontStyle = "";

        String _dataToPrint = "";
        String _fontInStringFomat = "";

        int _left = 30;
        int _top = 30;

        int _locationtype = 0;  // Type =0 là trên đầu, Type= 1 là ở giữa, Type=2 là phần chân. 
        int _statusEdit = 0; //  Trang thai sửa, 0 là chưa sửa, 1 là đã sửa,sẽ update,3 là đã update.
        int _typeOfTem = 0; // loại tem , 0 là Hóa đơn,  1 là tem nhãn .  
        public OrderItemPrint() { }

        public OrderItemPrint(Color fontColor, string fontName, int fontSize, string dataToPrint, string fontInStringFomat, int left, int top)
        {
            _fontColor = fontColor;
            _fontName = fontName;
            _fontSize = fontSize;
            _dataToPrint = dataToPrint;
            this._fontInStringFomat = fontInStringFomat;
            _left = left;
            _top = top;
        }
        public OrderItemPrint(string fontName, int fontSize, string dataToPrint, string fontInStringFomat, int left, int top)
        {

            _fontName = fontName;
            _fontSize = fontSize;
            _dataToPrint = dataToPrint;
            this._fontInStringFomat = fontInStringFomat;
            _left = left;
            _top = top;
        }
        public OrderItemPrint(string dataToPrint, string fontInStringFomat, int left, int top)
        {
            _dataToPrint = dataToPrint;
            this._fontInStringFomat = fontInStringFomat;
            _left = left;
            _top = top;
        }

        public int id { get => _id; set => _id = value; }
        public Color fontColor { get => _fontColor; set => _fontColor = value; }
        public string fontName { get => _fontName; set => _fontName = value; }
        public int fontSize { get => _fontSize; set => _fontSize = value; }
        public string fontStyle { get => _fontStyle; set => _fontStyle = value; }
        public int left { get => _left; set => _left = value; }
        public int top { get => _top; set => _top = value; }
        public int locationtype { get => _locationtype; set => _locationtype = value; }
        public int statusEdit { get => _statusEdit; set => _statusEdit = value; }
        public int typeOfTem { get => _typeOfTem; set => _typeOfTem = value; }
        public string fontInStringFomat { get => _fontInStringFomat; set => _fontInStringFomat = value; }
        public string dataToPrint { get => _dataToPrint; set => _dataToPrint = value; }


    }

    public class ShopOrderPrintObject   //  Thông tin đơn hàng để in hóa đơn.
    {
        //OderItemPrint shopName;   // 
        //OderItemPrint shopAddress;
        //OderItemPrint shopOrderNameType; //  Ví dụ : "Phiếu thanh toán" .
        //OderItemPrint orderTime;
        //OderItemPrint orderDate;
        //OderItemPrint orderCode;
        //OderItemPrint counterLabel;
        //OderItemPrint counterName;
        //public static List<ShopOrderPrintObject> buildListObjectItemOfOrder = null;
        // Bổ sung sản phẩm phụ ( topping)- Chỉ cần thêm 1 list sản phẩm phụ, và mỗi lần
        // Xử lý sản phẩm chính thì , lại lại List sản phẩm phụ, nếu nó có . 
        public static List<ShopOrderPrintObject> buildListObjectItemOfOrderToPrint()
        {

            return null;
        }
        public static List<ShopOrderPrintObject> getHeadersOfOrder() { return null; }
        public static List<ShopOrderPrintObject> getFootOfOrder() { return null; }
        public static List<ShopOrderPrintObject> getItemsOfOrder() { return null; }
    }

    public class ZonePost
    {
        int _id =0;
        int _shopId;
        String _zoneName;

        public ZonePost(int id, int shopId, string zoneName)
        {
            _id = id;
            _shopId = shopId;
            _zoneName = zoneName;
        }
        public ZonePost( int shopId, string zoneName)
        {
            _id = id;
            _shopId = shopId;
            _zoneName = zoneName;
        }

        public int id { get => _id; set => _id = value; }
        public int shopId { get => _shopId; set => _shopId = value; }
        public string zoneName { get => _zoneName; set => _zoneName = value; }
    }
    public class ZonePost_2
    {
       
        int _shopId;
        String _zoneName;

       
        public ZonePost_2(int shopId, string zoneName)
        {
           // _id = id;
            _shopId = shopId;
            _zoneName = zoneName;
        }

       // public int id { get => _id; set => _id = value; }
        public int shopId { get => _shopId; set => _shopId = value; }
        public string zoneName { get => _zoneName; set => _zoneName = value; }
    }

    public class TableZonePost {
        int _id = 0;
        int _zoneId;
        int _shopId;
        String _tableName;
        int _numberOfSeat;

        public TableZonePost(int id, int zoneId, int shopId, string tableName, int numberOfSeat)
        {
            _id = id;
            _zoneId = zoneId;
            _shopId = shopId;
            this._tableName = tableName;
            this.numberOfSeat = numberOfSeat;
        }
        public TableZonePost( int zoneId, int shopId, string tableName, int numberOfSeat)
        {
            _id = id;
            _zoneId = zoneId;
            _shopId = shopId;
            this._tableName = tableName;
            this.numberOfSeat = numberOfSeat;
        }

        public int id { get => _id; set => _id = value; }
        public int zoneId { get => _zoneId; set => _zoneId = value; }
        public int shopId { get => _shopId; set => _shopId = value; }
        public string tableName { get => _tableName; set => _tableName = value; }
        public int numberOfSeat { get => _numberOfSeat; set => _numberOfSeat = value; }
    }

    public class Table_Post
    {
        int _id;
        int _shopId;
        int _zoneId;
        int _numberOfSeat;
        String _tableName;

        public Table_Post(int id_, int zoneId_,int shopId_,  int numberOfSeat_, string tableName_)
        {
            _id = id_;
            _zoneId = zoneId_;
            _shopId = shopId_;
            _numberOfSeat = numberOfSeat_;
            _tableName = tableName_;
        }
        public Table_Post( int zoneId, int shopId_, int numberOfSeat, string tableName)
        {
          //  _id = id;
            _zoneId = zoneId;
            _shopId = shopId_;
            _numberOfSeat = numberOfSeat;
            _tableName = tableName;
        }

        public int id { get => _id; set => _id = value; }
        public int shopId { get => _shopId; set => _shopId = value; }
        public int zoneId { get => _zoneId; set => _zoneId = value; }
        public int numberOfSeat { get => _numberOfSeat; set => _numberOfSeat = value; }
        public string tableName { get => _tableName; set => _tableName = value; }
    }
    public class Table_Post_2
    {
       // int _id;
        int _zoneId;
        int _numberOfSeat;
        int _shopId;
        String _tableName;

        public Table_Post_2( int zoneId, int shopId_, int numberOfSeat, string tableName)
        {
       
            _zoneId = zoneId;
            _shopId = shopId_;
            _numberOfSeat = numberOfSeat;
            _tableName = tableName;
        }

       // public int Id { get => _id; set => _id = value; }
        public int zoneId { get => _zoneId; set => _zoneId = value; }
        public int shopId { get => _shopId; set => _shopId = value; }
        public int numberOfSeat { get => _numberOfSeat; set => _numberOfSeat = value; }
        public string tableName { get => _tableName; set => _tableName = value; }
    }

    // Trong hệ thống tại 1 thời điểm có thể có nhiều đơn hàng đang cùng hoạt động.
    // Mỗi đơn hàng  sẽ liên kết với 1  bàn ăn, bàn uống nước . 
    // Đơn hàng có thể đưuọc thanh toán luôn hoawcjj đang trong trạng thái continue
    public class Order_DonHang
    {
        public enum TrangThaiOrderDonHang { DangMua , DaDatXong_ChotDon, DaThanhToan, DangChoGiao, DaGiaoXong, DaHuy  };
        public enum TrangThaiHoanThanh  { DangMua =1 , DaDatXong, DaThanhToan, DangChoGiao, DaGiaoXong,  DaHuy=3 };
        public static List<Order_DonHang> lsOrderDonHang = new List<Order_DonHang>();
       
        public int SoLuongSanPham_;
        public int MaDonHang_C_;
        public int TongSoTien_;
        public int MaBan;  // Đơn hàng gắn với mã bàn- của cái bàn nào . 
        public int Status =0 ; // trạng thái . 0 là mới new - continue,  1 là đã  đã trả tiền . 
 //       public int LoaiDonHang = 0; // Tại chỗ, mang về, Shipping .
 //       public int LoaiThanhToan = 0; // Tiền mặt, thẻ ngân  hàng, quét mã QR. Ví ABC .
        public int TypeOfShipping = 0; // Tại chỗ, mang về, Shipping .
        public int TypeOfPayment = 0; // Tiền mặt,   thẻ ngân  hàng, quét mã QR . Ví ABC .
        public List<Product> listProductToppingSelected = new List<Product>();
        public List<Product> listProductSelected = new List<Product>();
        public TableZoneButton tableZoneButton = null;
        private TrangThaiHoanThanh trangThaiHoanThanh_ = TrangThaiHoanThanh.DangMua;
        public TrangThaiHoanThanh trangThaiHoanThanh { 
            get { return trangThaiHoanThanh_; }
            set {
                trangThaiHoanThanh_ = value;
                if (trangThaiHoanThanh_ == TrangThaiHoanThanh.DangMua)
                {
                    tableZoneButton.BackColor = Color.Red;
                }
                if (trangThaiHoanThanh_ == TrangThaiHoanThanh.DaDatXong)
                {
                    tableZoneButton.BackColor = Color.Yellow;

                }
                if (trangThaiHoanThanh_ == TrangThaiHoanThanh.DaThanhToan)
                {
                    tableZoneButton.BackColor = Color.Red;

                }
                if (trangThaiHoanThanh_ == TrangThaiHoanThanh.DangChoGiao )
                {
                    tableZoneButton.BackColor = Color.Yellow;
                }
                if (trangThaiHoanThanh_ == TrangThaiHoanThanh.DaGiaoXong)
                {
                    tableZoneButton.BackColor = Color.Yellow;
                }
                if (trangThaiHoanThanh_ == TrangThaiHoanThanh.DaHuy )
                {
                    tableZoneButton.BackColor = Color.Pink ;
                }

            }
        }
    }

    /*
     * Đang dùng class này để mapping data - từ server trả về . 
     */
    public class DataObjectResponse<T>
    {
        private int responseCode;
        private String message;
        private ObjectData<T> data;

        public int ResponseCode { get => responseCode; set => responseCode = value; }
        public string Message { get => message; set => message = value; }
        public ObjectData<T> Data { get => data; set => data = value; }
    }

    public class ObjectData<T>
    {
        List<T> content;
        public List<T> Content { get => content; set => content = value; }
    }

    /*
    {
  "items" : [
      { "id": 2,
         "price": 1400,
          "quantity" :1 
      },      
      {  "id": 6,
         "price": 1400,
          "quantity" :1
      }    
  ],
  "tableId": 1,
   "shopId": 3
}*/

}
