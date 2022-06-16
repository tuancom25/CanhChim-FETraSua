using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwingShop_.Modelss;

namespace SwingShop_
{
  public  class MyProductPicture : System.Windows.Forms.PictureBox
    {
        public int giaTien;
        public String tenItem;
        public String maItem;
        public Product product;
    }
    public class MyProuctLabel : System.Windows.Forms.Label
    {
        public int giaTien;
        public String tenItem;
        public String maItem;
        public Product product;
    }
    public class MyProuctButton : System.Windows.Forms.Button
    {
        public int giaTien;
        public String tenItem;
        public String maItem;
        public Product product;
    }
    public class MyTableButton : System.Windows.Forms.Button
    {
        public int Index;
        public String tenTable;
        public String maTable;
        //public Product product;
    }

}

