using SwingShop_.Modelss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwingShop_
{
    public partial class FrmNewTableZone : Form
    {
        public FrmNewTableZone()
        {
            InitializeComponent();
        }

        private void btnGetListObjectZone_Click(object sender, EventArgs e)
        {
            getZoneTable();
           
            List<Modelss.TableZone> lsTableZone = DataFromServer.lsZone[0].shpTables;
           dataGridView1.DataSource = lsTableZone;
            int i = 0;
            
        }
        void getZoneTable()
        {
            String action = "shop/display-all-tables?shopId=";
            String shopId = "" + DataFromServer.shopIdStr;
            DataFromServer.lsZone = Utils.getListObjectDataFromServer<Zone>(action + shopId, DataFromServer.token, "get");
        }
    }
}
