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
    public partial class FrmGetAndDisplayAllTables : Form
    {
        String action = "shop/display-all-tables?shopId=";
        int shopId = 3;
        public FrmGetAndDisplayAllTables()
        {
            InitializeComponent();
        }

        private void btnGetTables_Click(object sender, EventArgs e)
        {
            getTables();
        }

        void getTables()
        {
            String data = Utils.getJsondataFromRestAPI(action + shopId, "Bearer " + DataFromServer.token, "get");
            richTextBox1.Text = data;
        }
    }
}
