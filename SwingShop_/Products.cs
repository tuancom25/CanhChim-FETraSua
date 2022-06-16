using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SwingShop_.Modelss;
using System.Data.SqlClient;
namespace SwingShop_
{
    class Products
    {
        //http://150.95.109.25:8888/product/shop?shopId=3 
        // shop/product-all?shopId={sId}
        public static List<Product> products = null;
        static String method = "get";
        static String action = "product";
        static String token = "";
        public static List<Modelss.Product> getListProduct()
        {         
            products = Utils.getListObjectDataFromServer<Product>(action, token, method);
            return products;
        }

         // url lay het product cua shop theo :  
        public static List<Modelss.Product> getListProduct_(int shopId)
        {
            action = "product/shop?shopId=" + shopId;
            products = Utils.getListObjectDataFromServer<Product>(action, token, method);
            return products;
        }

        public static List<Product> getListChildProduct ( long parentProductId) {
         
            var listCh = from p in products where p.ParentProduct == parentProductId select p;
            return listCh.ToList();
        }
        public static List<Product> getListProductByCategory(long categoryId)
        {
          //  List<Product> listchild = new List<Product>();
            var listCh = from p in products where p.CategoryId == categoryId select p;
            return listCh.ToList();
        }
        public static  List<Product> getListProductTopUp()
        {
            var listProductTopUp = from p in products where p.HasTopUp == 1 select p;
            //           List<Product> mm = products.Where<Product>(p => p.HasTopUp == 1).ToList();
            List<Product> mm = products.Where(m => m.HasTopUp == 1).ToList();
            return listProductTopUp.ToList();
        }  
        public static List<Product> listProductOfShopNotToping()
        {
            List<Product> mm = products.Where(m => m.HasTopUp != 1).ToList();
            return mm.ToList();
        }

        public static bool inputNewProduct() {
            return true;
        }
        public static bool updateProduct()
        {
            return true;
        }

        public static List<Product> getListProduct_Test()
        {
            List<Product> ls = new List<Product>();
            ls.Add(new Product());

            return ls;
        }
    } 
}
