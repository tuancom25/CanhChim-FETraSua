using SwingShop_.Modelss;
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

namespace SwingShop_
{
    public partial class FrmOrderBillDisplayTest_ : Form
    {
        Graphics g = null; 
        //Segoe UI
        // Font fontProdut = new Font("tahoma", 11, FontStyle.Bold);
        // Font fontTopping = new  Font("tahoma", 10, FontStyle.Regular);
        // Font fontProdut = new Font("Arial", 11, FontStyle.Bold);
        //  Font fontTopping = new Font("Arial", 10, FontStyle.Regular);
        Font fontProdut = new Font("Segoe UI", 11, FontStyle.Bold);
        Font fontTopping = new Font("Segoe UI", 10, FontStyle.Regular);
        Product productCurent = null;   //  sản phẩm đang đưuọc chọn
        Product productCurentTopping = null;
        List<Product> lsProductInOrder = null;
        int X_ProductNameLocation = 10;
        int X_ProductNameToppingLocation = 38;
        int X_ProductPrice = 150;

        public FrmOrderBillDisplayTest_()
        {
            InitializeComponent();
            showTrueAll();
            // treeView1.Callap
            g = CreateGraphics();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            String data =  GetCurrentLine(richTextBox1);
            Text = data;
        }
        public  string GetCurrentLine(RichTextBox richTextbox)
        {
            int charIndex = richTextbox.SelectionStart;
            int currentLineNumber = richTextbox.GetLineFromCharIndex(charIndex);
            if (currentLineNumber < richTextbox.Lines.Length)
            {
                String data = "Line: " + currentLineNumber + ", value : " + richTextbox.Lines[currentLineNumber];
                // return richTextbox.Lines[currentLineNumber];
                HighlightLine(richTextbox, currentLineNumber, Color.AliceBlue);
                return data;
            }
            return "null";//  string.Empty;
        }

        public  void HighlightLine( RichTextBox richTextBox, int index, Color color)
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

        void changeLine(RichTextBox RTB, int line, string text)
        {
            int s1 = RTB.GetFirstCharIndexFromLine(line);
            int s2 = line < RTB.Lines.Count() - 1 ?
                      RTB.GetFirstCharIndexFromLine(line + 1) - 1 :
                      RTB.Text.Length;
            RTB.Select(s1, s2 - s1);
            RTB.SelectedText = text;
        }


        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            String t = "  + "+ textBox1.Text;

            int position = richTextBox1.Text.Length; richTextBox1.AppendText("\n" + t);
          
            // richTextBox1.AppendText("\n" + t);
            //richTextBox1.AppendText("\n" + t);
            // Font f = new Font("tahoma", 9, FontStyle.Regular);
            richTextBox1.Select(position + 1, t.Length - 1);
            //richTextBox1.SelectionFont = f;
            richTextBox1.SelectionFont = fontProdut;
            richTextBox1.SelectionColor = Color.Black;
        }

        void setFont( RichTextBox r ,  String data, Font font )
        {
           // String t = "  + " + textBox1.Text;
            int position = richTextBox1.Text.Length;
            r.AppendText("\n" + data);
            richTextBox1.Select(position + 1, data.Length - 1);
            richTextBox1.SelectionFont = font;
            richTextBox1.SelectionColor = Color.Black;

        }

        private void btnThemShopPing_Click(object sender, EventArgs e)
        {
            String t = "       - " + textBox1.Text +"    ";
            int position = richTextBox1.Text.Length;
           // richTextBox1.AppendText("\n" + t);
            richTextBox1.AppendText("\n" + t);
           // Font f = new Font("tahoma", 9, FontStyle.Regular);
            richTextBox1.Select(position + 1, t.Length -1);
            //richTextBox1.SelectionFont = f;
            richTextBox1.SelectionFont = fontTopping;
            richTextBox1.SelectionColor = Color.Black;
        }

        void doc_PrintPage( RichTextBox r, Graphics g)
        {
            int x = 10;  // vị trí tọa độ ban đầu  in . 
            int y = 0;  // hàng thứ 0;
            int  charPosition = 0;   // vị trí của ký tự
            while (charPosition <r.Text.Length)
            {
                if(r.Text[charPosition] == '\n') //  sang dòng mới
                {
                    charPosition++;
                    y += 20;
                    x = 10;
                }else if(r.Text[charPosition] =='\r')
                {
                    charPosition++;
                } else {
                    r.Select(charPosition, 1);
                    String data = r.SelectedText;
                    Font f = r.SelectionFont;
                    Brush brush = new SolidBrush(r.SelectionColor);
                    g.DrawString(data, f,brush, x,y);
                }
            }
        }
        void doc_PrintPage2(RichTextBox r, Graphics g)
        {
            int x = 10;  // vị trí tọa độ ban đầu  in . 
            int y = 0;  // hàng thứ 0;
            int charPosition = 0;   // vị trí của ký tự
            float fontZise = 0;
            while (charPosition < r.Text.Length)
            {
                if (r.Text[charPosition] == '\n') //  sang dòng mới
                {
                    charPosition++;
                    y += 20;
                    x = 10;
                }
                else if (r.Text[charPosition] == '\r')
                {
                    charPosition++;
                }
                else
                {
                    r.Select(charPosition, 1);
                    String data = r.SelectedText;
                    Font f = r.SelectionFont;
                    fontZise = f.Size;
                    Brush brush = new SolidBrush(r.SelectionColor);
                    g.DrawString(data, f, brush, x, y);
                     x += (int)fontZise-1;
                   // x += 10;
                    charPosition++;
                }
            }
        }

        public void  genBillOrder( RichTextBox r, List<Product> lsProduct)
        {
            foreach(Product p in lsProduct)
            {
                String mm = "\n" + p.productName;
                r.AppendText("");
            }
        }
        void doc_PrintPage3(RichTextBox r, Graphics g)
        {
            int x = 10;  // vị trí tọa độ ban đầu  in . 
            int y = 0;  // hàng thứ 0;
            int charPosition = 0;   // vị trí của ký tự
            int positionGiaTien = 180;
            int positionThanhTien = 400;
            float fontZise = 0;
            while (charPosition < r.Text.Length)
            {
                if (r.Text[charPosition] == '\n') //  sang dòng mới
                {
                    charPosition++;
                    y += 20;
                    x = 10;
                }
                else if (r.Text[charPosition] == '\r')
                {
                    charPosition++;
                }
                else
                {
                    r.Select(charPosition, 1);
                    String data = r.SelectedText;
                    Font f = r.SelectionFont;
                    fontZise = f.Size;
                    Brush brush = new SolidBrush(r.SelectionColor);
                    g.DrawString(data, f, brush, x, y);
                    x += (int)fontZise - 1;
                    // x += 10;
                    charPosition++;
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();
            ppd.Document = pd;
            pd.PrintPage += Pd_PrintPage;
            ppd.ShowDialog();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // throw new NotImplementedException();
            doc_PrintPage2(richTextBox1, e.Graphics);
        }
        void showTrueAll()
        {
            TreeNodeCollection listNode = treeView1.Nodes;

            foreach ( TreeNode tn in listNode)
            {
                // if(tn.Collapse())
                //tn.Collapse(false);
                tn.Expand();
                
            }
         //   treeView1.No
            int kk = 0;

        }

        private void btnInHoadon2_Click(object sender, EventArgs e)
        {
            
        }
        // In dữ liệu trong list object hay trong list String. 
        void inHoaDon22( List<String> ll , Graphics g)
        {

        }

        private void btnDisplayTableInrictextBox_Click(object sender, EventArgs e)
        {
            //builderString();
            SetTableToRichtextbox();
        }
        void builderString()
        {
            StringBuilder tableRtf = new StringBuilder();

            tableRtf.Append(@"{\rtf1\fbidis\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}");

            for (int j = 0; j <5; j++)
            {

                tableRtf.Append(@"\trowd");
                tableRtf.Append(@"\cellx2500" + " dataa abccccc   ");
                tableRtf.Append(@"\intbl\cell");
                tableRtf.Append(@"\cellx10000\intbl\cel");
                tableRtf.Append("   " + " dataa 2 cbdđ " + @"\intbl\clmrg\cell\row");

            }

            tableRtf.Append(@"\pard");
            tableRtf.Append(@"}");
            richTextBox1.Rtf = tableRtf.ToString();
        }

        private void SetTableToRichtextbox()
        {
            //Since too much string appending go for string builder
            StringBuilder tableRtf = new StringBuilder();
            //beginning of rich text format,dont customize this begining line              
            tableRtf.Append(@"{\rtf1 ");
            //create 5 rows with 3 cells each
            for (int i = 0; i < 5; i++)
            {
                tableRtf.Append(@"\trowd");
                //A cell with width 1000.
                tableRtf.Append(@"\cellx1000");
                //Another cell with width 2000.end point is 3000 (which is 1000+2000).
                tableRtf.Append(@"\cellx3000");
                //Another cell with width 1000.end point is 4000 (which is 3000+1000)
                tableRtf.Append(@"\cellx4000");
                tableRtf.Append(@"\intbl \cell \row"); //create row
            }

            tableRtf.Append(@"\pard");
            tableRtf.Append(@"}");

            this.richTextBox1.Rtf = tableRtf.ToString();
        }

        private void btnDisplayTextFormatOfRich_Click(object sender, EventArgs e)
        {
            String mm = richTextBox1.Rtf;
            richTextBox2.Text = mm;
        }

        String addMoreSpace(String data , Font f, int pixelsOnLeft, Graphics g)
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




    }


}
