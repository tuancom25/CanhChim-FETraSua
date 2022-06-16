using SwingShop_.Modelss;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SwingShop_
{
    public class Categorys
    {
        public static List<Modelss.Product> products = null;
        static String method = "get";
        static String action = "shop";
        static String token = "";

        // link lay het category cua shop theo shopId  http://150.95.109.25:8888/shop/3
        //                                             http://150.95.109.25:8888/shop/3
        public static List<Modelss.Category> getListCategorys(int shopId)
        {
            action += "/" + shopId;
            String data = Utils.getJsondataFromRestAPI(action, token, method);
            DataObjectResponse<Category> abc = JsonSerializer.Deserialize<Modelss.DataObjectResponse<Category>>(data);
            List<Category> listCategory = abc.Data.Content;
            return listCategory;
        }
        public static List<Modelss.Category> getListCategorysByShopId(int shopId)
        {
            action += "/" + shopId;
          //  List<Category> listCategory = new List<Category>();
            List<Category> listCategory = Utils.getListObjectDataFromServer<Category>(action, token, method);
          
             return listCategory;
            
        }
        public List<Category> getListCategory_Test()
        {
            List<Category> ls = new List<Category>();
            ls.Add(new Category(1, "Đồ Lạnh", 1, ""));
            ls.Add(new Category(2, "Đồ Uống Nóng", 1, ""));
            ls.Add(new Category(3, "Đồ Trà Hoa Quả", 1, ""));
            ls.Add(new Category(4, " Caffe ", 1, ""));
            ls.Add(new Category(5, "Nước Ép Sính Tố", 1, ""));
            ls.Add(new Category(6, " Cacao ", 1, ""));
            ls.Add(new Category(7, " Trà Sữa", 1, ""));
            ls.Add(new Category(8, " Topping ", 1, ""));
            ls.Add(new Category(9, " Sữa chua ", 1, ""));

            return ls;
        }



        /*
        // Vis du co' 1 String json  nhu lay ve nhu sau . 
       static String jsonCarArray =
  "[{ \"color\" : \"Black\", \"type\" : \"BMW\" }, { \"color\" : \"Red\", \"type\" : \"FIAT\" }]";
        //List<Car> listCar = objectMapper.readValue(jsonCarArray, new TypeReference<List<Car>>() { });

        // Tao ham generic
        public static List<T> GetObject<T>() {
            List<T> listObjectFromClient = null; // new List<T>();
            // su dung thu vien ObjectMapper  voi'  - java  ( hoac Spring  - java ) ; 
            listObjectFromClient = objectMapper.readValue(jsonCarArray, new TypeReference<List<T>>() { });
            return listObjectFromClient;
       }
        public static List<Car> getListCar()
        {
            List<Car> listCar = GetObject<Car>();
        }
        public static List<Student> getListStudent()
        {
            List<Student> listCar = GetObject<Student>();
        }
        public static List<Book> getListStudent()
        {
            List<Book> listCar = GetObject<Book>();
        }
        */

    }
}
