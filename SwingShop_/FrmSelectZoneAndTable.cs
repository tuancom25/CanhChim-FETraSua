using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwingShop_.Modelss;
using System.Windows.Forms;

namespace SwingShop_
{
    public partial class FrmSelectZoneAndTable : Form
    {
        FrmSaleProduct fSale;
        public List<Zone> listZone;
        public List<TableZone> listTable;
        int FormWith;
        int FormHeight;
        int KhoangCach_GiuaCacTable = 20;
        int KhoangCachGiuaCacZone = 20;
        String tableNameSelected = "";
        String zoneName; String TableName; int TableId; int zoneId;
        public void setNameTableButtonSelected(String zoneName, String TableName, int TableId, int zoneId)
        {
            tableNameSelected = TableName;
            this.zoneId = zoneId; this.zoneName = zoneName; this.TableName = TableName;this.TableId = TableId;
            btnXacNhan.Text = "Xác nhận: " + zoneName + "/" + TableName;
            btnXacNhan.ForeColor = Color.Red;
            FrmSaleProduct.frmsale.setKhuBan(zoneName + "/" + TableName, zoneId, TableId);

        }

        public FrmSelectZoneAndTable()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            FormWith = this.Width - 50;
            FormHeight = this.Height - 40;
            DrawTableZone();   // Gọi để vẽ các đối tượng . 

        }
        public FrmSelectZoneAndTable( FrmSaleProduct fSale)
        {
            InitializeComponent();
            this.fSale = fSale;
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //  this.Close();
            this.Hide();
           // this.des
        }

        void DrawTableZone()
        { //
            int numberLineTableZone = 0;
            int ZoneTop = 80;
            int ZoneLeft = 20;
            
            int k = 0;
            listZone = SwingShop_.DataDumy.DataGetFromDumy.getListZoneDumy();
            int preGroupTop = 0;
            foreach ( Zone z in listZone)
            {
                // int tzLeft = 20;
                numberLineTableZone = 0; ;
                ZoneLeft = 20;
               // ZoneTop = 80 + k * 150;
                k++;
                int numberTableOfLine = 4;
                int numberTableOfLineIndex = 1;
                int countLineOfZone = 0;
                GroupBox g = new GroupBox();
                g.Text = "" + z.zoneName;
                g.Width = FormWith;
                g.Height = 150;
                g.Top = ZoneTop;
                g.Left = ZoneLeft;
             
                List<TableZone> tzs = z.shpTables;
                int i = 0;
                foreach( TableZone tz in tzs )
                {
                    // Button bt = new Button();
                    TableZoneButton btTable = new TableZoneButton(this);
                    btTable.Width = 100;
                    btTable.Height = 60;
                    btTable.TableId = tz.id;
                    btTable.TableName = tz.tableName;
                    btTable.Text = tz.tableName;
                    btTable.ZoneName = tz.ZoneName;
                    btTable.Click += BtTable_Click;                 
                   
                    btTable.Text = "" + tz.tableName;
                    btTable.Top = 30 + countLineOfZone * 75; ;
                      g.Controls.Add(btTable);
                   // Controls.Add(btTable);
                    btTable.Show();
                    btTable.ForeColor = Color.Black;
                    btTable.Left = ZoneLeft + 120 * i + 10;
                    i++;
                    numberTableOfLineIndex++;
                    // if(numberTableOfLineIndex >=numberTableOfLine )
                    if (i >= numberTableOfLine)
                    {
                        numberTableOfLineIndex = 1;
                        i = 0;
                        g.Height = 150 + countLineOfZone * 95 +30 ;
                        countLineOfZone++;
                       // ZoneTop += 60;
                    }
                }
                ZoneTop += g.Height +20 ;
                g.ForeColor = Color.Blue;
                this.Controls.Add(g);
                g.Show();
                int kk = ZoneTop + g.Height + 150 ;
                setHightForm(kk);
            }

        }
        void setHightForm(int h)
        {
            this.Height = h;
        }

        public void BtTable_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            TableZoneButton btTable = (TableZoneButton)sender;
            btTable.frmSelectZoneandTable.setNameTableButtonSelected(btTable.ZoneName, btTable.TableName, btTable.TableId,btTable.ZoneId);
           // FrmSaleProduct.order_donHang_Curent = btTable.order_DonHang;
           DataLiveCurent.order_DonHang_Curent = btTable.order_DonHang; 
        }

        private void FrmSelectZoneAndTable_Load(object sender, EventArgs e)
        {

        }

        private void FrmSelectZoneAndTable_Resize(object sender, EventArgs e)
        {

        }

        private void FrmSelectZoneAndTable_ResizeEnd(object sender, EventArgs e)
        {
            FormWith = this.Width;
            FormHeight = this.Height;
          //  DrawTableZone(); // Vẽ lại các đối tượng . 
        }

        private void rdoChonTheoViTriBan_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
