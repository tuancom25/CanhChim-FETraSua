
using Newtonsoft.Json;
using SwingShop_.Modelss;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace SwingShop_
{
    class Utils
    {
        public static String urlDomain = "http://150.95.109.25:8888/";
        private const string DATAExample = @"{""object"":{""name"":""Name""}}";
        static HttpWebRequest request = null;

        public static HttpWebRequest getHttpWebRequest(String urlDomain, String action, String token, String method)
        {
            if (request == null)
            {
                request = (HttpWebRequest)WebRequest.Create(urlDomain + action);
                request.Method = method;
                request.ContentType = "application/json";
                request.Headers.Add("Authorization", token);
                //request = request_;
            }
            return request;
        }
        public static HttpWebRequest getHttpWebRequest(String action, String token, String method)
        {
           // if (request == null)
           // {
                HttpWebRequest request_ = (HttpWebRequest)WebRequest.Create(urlDomain + action);
                request_.Method = method;
                request_.ContentType = "application/json";
                request_.Headers.Add("Authorization", token);
                request_.Accept = "*/*";
                request = request_;
          //  }
            return request;
        }
        // Gọi server và lấy data . 
        public static String getJsondataFromRestAPI(String action, String token, String method)
        {
            //action = urlDomain + action;
            HttpWebRequest request = Utils.getHttpWebRequest(action,"Bearer " + token.Replace("Bearer",""), method);
            try
            {
                WebResponse webResponse = request.GetResponse();
                Stream webStream = webResponse.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream);
                string response = responseReader.ReadToEnd();
                responseReader.Close();

                String data = response.Replace("null", "0");
                return data;

            }catch (Exception x) { }
            return "null";
        } 

        public static  List<T> getListObjectDataFromServer<T>(String action, String token, String method)
        {
           List<T> ListObjectJsonData = new List<T>();
           String data = getJsondataFromRestAPI(action, token, method);
           DataObjectResponse<T> abc = JsonConvert.DeserializeObject<DataObjectResponse<T>>(data);
           ListObjectJsonData = abc.Data.Content;          
           return ListObjectJsonData;
        }


        private static string doRequestWithBytesPostData(string requestUri, string method, byte[] postData,
                                        CookieContainer cookieContainer,
                                        string userAgent, string acceptHeaderString,
                                        string referer,
                                        string contentType, out string responseUri)
        {
            var result = "";
            if (!string.IsNullOrEmpty(requestUri))
            {
                var request = WebRequest.Create(requestUri) as HttpWebRequest;
                if (request != null)
                {
                    request.KeepAlive = true;
                    var cachePolicy = new RequestCachePolicy(RequestCacheLevel.BypassCache);
                    request.CachePolicy = cachePolicy;
                    request.Expect = null;
                    if (!string.IsNullOrEmpty(method))
                        request.Method = method;
                    if (!string.IsNullOrEmpty(acceptHeaderString))
                        request.Accept = acceptHeaderString;
                    if (!string.IsNullOrEmpty(referer))
                        request.Referer = referer;
                    if (!string.IsNullOrEmpty(contentType))
                        request.ContentType = contentType;
                    if (!string.IsNullOrEmpty(userAgent))
                        request.UserAgent = userAgent;
                    if (cookieContainer != null)
                        request.CookieContainer = cookieContainer;

                    request.Timeout = 100000;// Constants.RequestTimeOut;

                    if (request.Method == "POST")
                    {
                        if (postData != null)
                        {
                            request.ContentLength = postData.Length;
                            using (var dataStream = request.GetRequestStream())
                            {
                                dataStream.Write(postData, 0, postData.Length);
                            }
                        }
                    }

                    using (var httpWebResponse = request.GetResponse() as HttpWebResponse)
                    {
                        if (httpWebResponse != null)
                        {
                            responseUri = httpWebResponse.ResponseUri.AbsoluteUri;
                            cookieContainer.Add(httpWebResponse.Cookies);
                            using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                            {
                                result = streamReader.ReadToEnd();
                            }
                            return result;
                        }
                    }
                }
            }
            responseUri = null;
            return null;
        }

        static public String  loginServer(string number, string text)
        {
            string strNewValue;
            string strResponse;
            String urlSerrver = "http://150.95.109.25:8888/shop-auth/login";
          //  HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http:////www.buymessage.com/ostazSms/send.php");
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(urlSerrver);
            req.Method = "POST";
          //  req.ContentType = "application/x-www-form-urlencoded";
            strNewValue = "usr=****&pwd=*****&to={0}&msg={1}";
            strNewValue = "username=admin&password=123456";
            strNewValue = "{\"username\":\"admin\"; \"password\":\"123456\"}";
            // byte[] byteArray = Encoding.UTF8.GetBytes(string.Format(strNewValue, number, text));
            byte[] byteArray = Encoding.UTF8.GetBytes(strNewValue);
            req.ContentLength = byteArray.Length;
            req.ContentType = "application/json;charset=utf-8";
           // req.Headers.Add("Accept", "application/json"); 
            Stream dataStream1 = req.GetRequestStream();
            // dataStream1.Write(byteArray, 0, byteArray.Length);
           // dataStream1.Write(strNewValue);
            dataStream1.Close();

            try
            {
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader SR = new StreamReader(dataStream, Encoding.Unicode);
                strResponse = SR.ReadToEnd();
                response.Close();
                dataStream.Close();
                SR.Close();
                req.Abort();
                return strResponse;
            }
            catch (Exception x) { req.Abort(); }
            return ""+ null;
        }

 
        public static String LoginSerrver()
        {
            String urlSerrver = "http://150.95.109.25:8888/shop-auth/login";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlSerrver);
            httpWebRequest.ContentType = "application/json";
           // httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Accept", "*/*");
            String strNewValue = "{\"username\":\"admin\", \"password\":\"123456\"}";
            int leng = Encoding.UTF8.GetBytes(strNewValue).Length;
            httpWebRequest.ContentLength = leng;
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {        
                streamWriter.Write(strNewValue);
            }
            var result = "";
            String mHost = httpWebRequest.Host;
         //   System.Windows.Forms.MessageBox.Show(" Host:  " + mHost+" , leng = "+ leng);
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream()); 
                     result = streamReader.ReadToEnd();
                    return result;               
            }catch ( Exception x)
            {
                //System.Windows.Forms.MessageBox.Show("")
                result = x.Message;
            }
            return "hello:  " +  result;
        }
        public static String LoginSerrver(String userName, String pass)
        {
            String urlSerrver = "http://150.95.109.25:8888/shop-auth/login";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlSerrver);
            httpWebRequest.ContentType = "application/json";
            // httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Accept", "*/*");
            String temp = "{\"username\":\"admin\", \"password\":\"123456\"}";
            String  strValue = temp.Replace("admin", userName).Replace("123456",pass);
            int leng = Encoding.UTF8.GetBytes(strValue).Length;
            httpWebRequest.ContentLength = leng;
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(strValue);
            }
            var result = "";
            //   System.Windows.Forms.MessageBox.Show(" Host:  " + mHost+" , leng = "+ leng);
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                String []  headerKeys = httpResponse.Headers.AllKeys;
                var streamReader = new StreamReader(httpResponse.GetResponseStream());
                result = streamReader.ReadToEnd();
                return result;
            }
            catch (Exception x)
            {
                //System.Windows.Forms.MessageBox.Show("");
                result = x.Message;
            }
            return "hello:  " + result;
        }

        public static UserLoginRessonse convertUserLoginRessonse(String data)
        {  
            try{
                UserLoginRessonse abc = Newtonsoft.Json.JsonConvert.DeserializeObject<Modelss.UserLoginRessonse>(data);
                return abc;
            }catch ( Exception x) { }
            return null;
        }

        public static String getJsonFromObject(Object oo)
        {
            string output = JsonConvert.SerializeObject(oo);
            return output;
        }

        //============================================================================
        // =======================   Gui du lieu len server ==========================
        //============================================================================

        static public String postDataToServer2(String action, String token, Object data)
        {
                                 //  http://localhost:8888/shop-auth/register
            String urlSerrver = "http://150.95.109.25:8888/shop-auth/register";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlSerrver);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            //httpWebRequest.Method = "Get";
            httpWebRequest.Headers.Add("Accept", "*/*");
            httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            String strNewValue = getJsonFromObject(data) ; // Object => json
            int leng = Encoding.UTF8.GetBytes(strNewValue).Length;

            httpWebRequest.ContentLength = leng;
            // httpWebRequest.Host = "150.95.109.25:8888";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(strNewValue);
            }
            var result = "";
            String mHost = httpWebRequest.Host;
            //   System.Windows.Forms.MessageBox.Show(" Host:  " + mHost+" , leng = "+ leng);
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());
                result = streamReader.ReadToEnd();
                return result;
            }
            catch (Exception x)
            {
                //System.Windows.Forms.MessageBox.Show("")
                result = x.Message;
            }

            return "hello:  " + result;
        }


        static public String postDataToServer3(String action, String token, Object data)
        {   // Test 2 link sau đây  là 0k 
            //link 1: http://localhost:8888/shop-auth/register   new user .
            //link 2: http://150.95.109.25:8888/shop-admin/new-product  -> post product(new product )
            String urlSerrver = "http://150.95.109.25:8888/"+ action;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlSerrver);
            httpWebRequest.ContentType = "application/json";
            // httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.Method = "POST";
            //httpWebRequest.Method = "Get";
            httpWebRequest.Headers.Add("Accept", "*/*");
            String token_curent = "Bearer " + token;
            httpWebRequest.Headers.Add("Authorization", token_curent);
            String strNewValue = getJsonFromObject(data);
            int leng = Encoding.UTF8.GetBytes(strNewValue).Length;
            httpWebRequest.ContentLength = leng;
            // httpWebRequest.Host = "150.95.109.25:8888";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(strNewValue);
            }
            var result = "";
            String mHost = httpWebRequest.Host;
            //   System.Windows.Forms.MessageBox.Show(" Host:  " + mHost+" , leng = "+ leng);

            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());

                result = streamReader.ReadToEnd();
                return result;


            }
            catch (Exception x)
            {
                //System.Windows.Forms.MessageBox.Show("")
                result = x.Message;
            }

            return "hello:  " + result;
        }

        //Bearer   eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJhZG1pbiIsImV4cCI6MTY0ODgwMjUwNCwiaWF0IjoxNjQ4NzE2MTA0fQ.CXf6UMcGM29V8KpBP3fRPpUHGsZeyOTP51icyx7DuxuAy1jl3OR2T8uljpJe9_yCPhZULrRDY0DgdOs6V9aCdw
       static String token_M = "Bearer  eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJhZG1pbiIsImV4cCI6MTY0ODgwMjUwNCwiaWF0IjoxNjQ4NzE2MTA0fQ.CXf6UMcGM29V8KpBP3fRPpUHGsZeyOTP51icyx7DuxuAy1jl3OR2T8uljpJe9_yCPhZULrRDY0DgdOs6V9aCdw";

        public static string HttpPostRequest_FormData(string url, Dictionary<string, Object> postParameters, String token)
        {
            string postData = "";

            foreach (string key in postParameters.Keys)
            {
                postData += HttpUtility.UrlEncode(key) + "="
                      + HttpUtility.UrlEncode(""+postParameters[key]) + "&";
            }
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.Accept = "*/*";
            //myHttpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            byte[] data = Encoding.ASCII.GetBytes(postData);
            myHttpWebRequest.Headers.Add("Authorization", token_M);
           // myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentType = "multipart/form-data";
            myHttpWebRequest.ContentLength = data.Length;

            Stream requestStream = myHttpWebRequest.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            Stream responseStream = myHttpWebResponse.GetResponseStream();

            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);

            string pageContent = myStreamReader.ReadToEnd();

            myStreamReader.Close();
            responseStream.Close();

            myHttpWebResponse.Close();

            return pageContent;
        }

        //==========================================================
        // ======  Sử dụng đối tượng HttpClient để kết nối =========
        //==========================================================
        // Test 1 
        private static async void DoIt()
        {
            using (var stringContent = new StringContent("{ \"firstName\": \"John\" }", System.Text.Encoding.UTF8, "application/json"))
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.PostAsync("http://localhost:52042/api/values", stringContent);
                    var result = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }

 
        // Hàm này test gửi thành công,  với phiên bản gửi FormData multipart
       // Test 2.
        public static String SendData_Post_2(String pName, String pCode)
        {
            var client = new HttpClient();
           // AuthenticationHeaderValue auth = new AuthenticationHeaderValue("Authorization", "Bearer "+ token_M);
           // client.DefaultRequestHeaders.Authorization = auth;
            client.DefaultRequestHeaders.Add("Authorization",   token_M );
            var baseUrl = "http://150.95.109.25:8888/shop-admin/new-product";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "multipart/form-data");
            var formContent = new MultipartFormDataContent
                {
                 {new StringContent(pName),"productName"},
                 {new StringContent(pCode),"productCode" },
                 {new StringContent("0"),"isMultiPrice"},
                 {new StringContent("100"),"price"},
                 {new StringContent("200"),"price2"},
                 {new StringContent("300"),"price3"},
                 {new StringContent("1"),"categoryId"},
                 {new StringContent("3"),"shopId"},
                 {new StringContent("0"),"hasTopUp"},
                 {new StringContent("0"),"isTopUp"}
                };
            var response = client.PostAsync(baseUrl, formContent).Result;
            response.EnsureSuccessStatusCode();
            var result = string.Empty;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }         
            return " kết quả :  " + result ;
        }
        // -> ok . 
        public static String PostOrder(Order_Post order_post) { 
            String domain = "http://150.95.109.25:8888/shop/new-order";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + DataFromServer.token);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            String data = JsonConvert.SerializeObject(order_post);
            var content = new StringContent(data, Encoding.UTF8, "application/json");          
            var response = client.PostAsync(domain, content).Result;
            response.EnsureSuccessStatusCode();
            var result = string.Empty;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }
            return " kết quả :  " + result;
        }
        // 
        public static String PostData( String action ,  Object _post)
        {
            var result = string.Empty;
            try
            {
                String domain = urlDomain + action;
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + DataFromServer.token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                String data = JsonConvert.SerializeObject(_post);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                var response = client.PostAsync(domain, content).Result;
                response.EnsureSuccessStatusCode();
              
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
                return " kết quả :  " + result;
            }catch (Exception e) { }
            return " kết quả :  " + result;
        }

        public static  void getCategorys()
        {
            string actionDanhMuc = "shop/category-all?shopId=";
            String shopId = "" + DataFromServer.shopIdStr;
           // String data = Utils.getJsondataFromRestAPI(actionDanhMuc + shopId, DataFromServer.token, "get");
            DataFromServer.LsCategory = Utils.getListObjectDataFromServer<Category>(actionDanhMuc + shopId, DataFromServer.token, "get");
           // richTextBox1.Text = data;
        }
        public static void getProducts()
        {
            String action = "shop/product-all?shopId=";
            String shopId = "" + DataFromServer.shopIdStr;
            DataFromServer.lsProduct = Utils.getListObjectDataFromServer<Product>(action + shopId, DataFromServer.token, "get");
        }
        public static void getZoneTables()
        {
            String action = "shop/display-all-tables?shopId=";
            String shopId = "" + DataFromServer.shopIdStr;
            DataFromServer.lsZone = Utils.getListObjectDataFromServer<Zone>(action + shopId, DataFromServer.token, "get");
              getListAllTables();
        }
        public static void LoadAllData()
        {
            getCategorys();
            getProducts();
            getZoneTables();
        }
       
       public static List<TableZone> getListAllTables()
        {
            List<Modelss.TableZone> lsTable = new List<TableZone>();
            foreach (var z in DataFromServer.lsZone)
            {
                foreach (TableZone t in z.shpTables)
                {
                    t.ZoneId = z.id;
                    t.ZoneName = z.zoneName;
                    lsTable.Add(t);
                }
            }
            DataFromServer.lsTableZoneAll = lsTable;
            return lsTable;
        }
    }

}
