using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwingShop_.Modelss;
namespace SwingShop_
{
    public partial class FrmPrintOrder_Test : Form
    {
        Graphics g = null;
        Font ff = null; 
        public FrmPrintOrder_Test()
        {
            InitializeComponent();
            g = grpZone.CreateGraphics();
            txtDataTextContent.Text = "Hóa đơn bán hàng";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // FontDialog fd = new FontDialog();
            //  Font my = fd.Font;
            g.FillRectangle(new SolidBrush(Color.White),0,0,grpZone.Width, grpZone.Height);
            foreach (OrderItemPrint o in DataFromServer.lsOrderItemPrints)
            {
                g.DrawString(o.dataToPrint, ConvertStringToFont(o.fontInStringFomat), new SolidBrush(Color.Black), o.left, o.top);

            }

        }
        
        String ConvertFontToString(Font f) {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
            // Saving Font object as a string
            string fontString = converter.ConvertToString(f);
            // Load an instance of Font from a string
            Font font = (Font)converter.ConvertFromString(fontString);
            Text = "độ dai fonString"+ fontString.Length;
            return fontString;
        }
        Font ConvertStringToFont( String s)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
            Font font = (Font)converter.ConvertFromString(s);
            return font;
        }

        private void FrmPrintOrder_Test_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void FrmPrintOrder_Test_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            Font my = fd.Font;
            ff = my;
        }

        private void button1_Click(object sender, EventArgs e)
        { //Thêm nội dung-  font chữ và tọa độ in . 
            // Font f = new Font("Tahoma", 12);
            if (txtDataTextContent.Text != null && txtDataTextContent.Text.Length > 1 && ff != null)
            {
                OrderItemPrint o = new OrderItemPrint(txtDataTextContent.Text,ConvertFontToString(ff),(int)txtPixelX.Value, (int)txtPixelY.Value);
                DataFromServer.lsOrderItemPrints.Add(o);
                listBox1.Items.Add(txtDataTextContent.Text+" ("+txtPixelX.Value.ToString()+", "+ txtPixelY.Value.ToString()+")");
            }
        }
    }
}
