using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SwingShop_.Modelss
{
    public class Category : System.Windows.Forms.Button 
    {
        int id_;
        String categoryName;
        int shopId;
        String shopName;

        public Category(int id_, string categoryName, int shopId, string shopName)
        {
            this.id_ = id_;
            this.categoryName = categoryName;
            this.shopId = shopId;
            this.shopName = shopName;
        }

        public int Id { get => id_; set => id_ = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public int ShopId { get => shopId; set => shopId = value; }
        public string ShopName { get => shopName; set => shopName = value; }

    }
    
    
    public class CategoryResponse
    {
        private int responseCode;
        private String message;
        private CategoryData data;

        public int ResponseCode { get => responseCode; set => responseCode = value; }
        public string Message { get => message; set => message = value; }
        public CategoryData Data { get => data; set => data = value; }
    }

    public class CategoryData
    {
        List<Category> content; // = new List<Product>();
        public List<Category> Content { get => content; set => content = value; }
    }
    public class Category_Server
    {
        int id_;//: 1,
        int shopId_;//       "shopId": 3,
        String shopName_;//       "shopName": "Trà chanh TIMO",
        String categoryName_;//      "categoryName": "Milk Tea",
        String imageUrl_;//       "imageUrl": ""

        public int Id_ { get => id_; set => id_ = value; }
        public int ShopId_ { get => shopId_; set => shopId_ = value; }
        public string ShopName_ { get => shopName_; set => shopName_ = value; }
        public string CategoryName_ { get => categoryName_; set => categoryName_ = value; }
        public string ImageUrl_ { get => imageUrl_; set => imageUrl_ = value; }
    }

    // GroupID = 3; là danh mục . 
    public class CategoryPost
    {
        //  int id_;
        int _id;
        int _shopId_;
        int _groupId_ = 1 ;
        String _categoryName;
        String _description;

        public CategoryPost(int shopId_, int groupId_, string categoryName, string description)
        {
            _shopId_ = shopId_;
            _groupId_ = groupId_;
            _categoryName = categoryName;
            _description = description;
        }
        public CategoryPost(int shopId_, string categoryName, string description)
        {
            _shopId_ = shopId_;
            _categoryName = categoryName;
            _description = description;
        }
        public CategoryPost( int shopId_, string categoryName, string description, int id_)
        {
            _shopId_ = shopId_;
            _categoryName = categoryName;
            _description = description;
            _id = id_;
        }

        public string categoryName { get => _categoryName; set => _categoryName = value; }
        public int shopId { get => _shopId_; set => _shopId_ = value; }
        public int groupId { get => _groupId_; set => _groupId_ = value; }   
        public string description { get => _description; set => _description = value; }
      //  public int id { get => _id; set => _id = value; }
    }
    public class CategoryPostID_
    {
        //  int id_;
        int _id;
        int _shopId_;
        int _groupId_ = 1;
        String _categoryName;
        String _description;

        public CategoryPostID_(int shopId_, int groupId_, string categoryName, string description)
        {
            _shopId_ = shopId_;
            _groupId_ = groupId_;
            _categoryName = categoryName;
            _description = description;
        }
        public CategoryPostID_(int shopId_, string categoryName, string description)
        {
            _shopId_ = shopId_;
            _categoryName = categoryName;
            _description = description;
        }
        public CategoryPostID_(int shopId_, string categoryName, string description, int id_)
        {
            _shopId_ = shopId_;
            _categoryName = categoryName;
            _description = description;
            _id = id_;
        }

        public string categoryName { get => _categoryName; set => _categoryName = value; }
        public int shopId { get => _shopId_; set => _shopId_ = value; }
        public int groupId { get => _groupId_; set => _groupId_ = value; }
        public string description { get => _description; set => _description = value; }
        public int id { get => _id; set => _id = value; }
    }

    /*
    {"responseCode":200,"message":"OK","data":{"content":[{"id":2,"shopId":3,"shopName":"Trà chanh TIMO","categoryName":"Coffee"}],"pageable":{ "sort":{ "empty":true,"sorted":false,"unsorted":true},"offset":0,"pageNumber":0,"pageSize":12,"paged":true,"unpaged":false},"totalPages":1,"totalElements":1,"last":true,"size":12,"number":0,"sort":{ "empty":true,"sorted":false,"unsorted":true},"numberOfElements":1,"first":true,"empty":false}}
    */
}
