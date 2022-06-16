using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwingShop_.Modelss;

namespace SwingShop_
{
   public class DataFromServer
    {
      
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

        public static List<UserEmployee> lsUserEmployee = null;
        public static List<Category>  LsCategory = null;
        public static List<Product> lsProduct = null;
        public static List<ProductButton_> lsProductButton = null;
        public static List<ProductButton_> lsProductButtonTopping;
        public static List<Zone> lsZone = null;
        public static List<TableZone> lsTableZoneAll = null;
        public static List<TableZoneButton> lsTableZoneButton;
        public static List<OrderItemPrint> lsOrderItemPrints = new List<OrderItemPrint>();
        public static List<OrderItemPrint> lsOrderItemsPrintHeader = new List<OrderItemPrint>();
        public static List<OrderItemPrint> lsOrderItemsBody = new List<OrderItemPrint>();
        public static List<OrderItemPrint> lsOrderItemsFooter = new List<OrderItemPrint>();
        public static String token = ""; 
        public static UserLoginRessonseDeltails udetail = null;
        public static String shopIdStr;
        public static int shopIdInt;
        public static List<String> roles = null;
        // public static List<TableZoneButton> 
        
    }
}
