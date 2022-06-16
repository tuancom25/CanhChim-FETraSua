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
    public partial class FrmNewZone : Form
    {
        public FrmNewZone()
        {
            InitializeComponent();
        }
        int id = 0;
        int Zoneid = 0;
        String Zonename = "";
        int tableId = 0;
        String tableName = "";
        String action1 = "shop-admin/new-zone";
        String action2 = "shop-admin/new-table";
        private void FrmNewZone_Load(object sender, EventArgs e)
        {
            cbxKhuVuc.DataSource = DataFromServer.lsZone;
            cbxKhuVuc.DisplayMember = "zoneName";
            cbxKhuVuc.ValueMember = "id";
            dgrZone.DataSource = DataFromServer.lsZone;
            if ( chkAllTables.Checked)
            {
                // Hiển thị tất cả các bàn của các khu vực . 
            }
            dgrTable.DataSource = DataFromServer.lsTableZoneAll;
            int i = 0;
            i++;
        }
     
        private void btnThemMoiZone_Click(object sender, EventArgs e)
        {
            if(txtTenKhuVuc.Text !=null)
            {
                ZonePost p = null;
                int shopId = Int32.Parse(DataFromServer.shopIdStr);
                if (rdoThemMoiZone.Checked) {
                    ZonePost_2 p2 = new ZonePost_2(shopId, txtTenKhuVuc.Text);
                    String data1 = Utils.postDataToServer3(action1, DataFromServer.token, p2);
                }
                else
                {
                    p = new ZonePost(Zoneid, shopId, txtTenKhuVuc.Text);
                }
                String data = Utils.postDataToServer3(action1, DataFromServer.token , p);
                int i = 0;
                i++;
                i++;
                i++;
                refreshData();
            }
        }

        void refreshData()
        {
             Utils.getZoneTables();
            
            cbxKhuVuc.DataSource = DataFromServer.lsZone;
            cbxKhuVuc.DisplayMember = "zoneName";
            cbxKhuVuc.ValueMember = "id";
            dgrZone.DataSource = DataFromServer.lsZone;
            dgrTable.DataSource = DataFromServer.lsTableZoneAll;
            int i=0;
            i++;
            i++;
            i++;
            dgrZone.Refresh();
            dgrTable.Refresh();            
        }
        private void dgrZone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoSuaZone.Checked)
            {  try
                {
                    int index = e.RowIndex;
                    DataGridViewRow r = dgrZone.Rows[index];
                    Object o = r.Cells[0].Value;
                    Object o2 = r.Cells[1].Value;
                    try
                    {
                        Zoneid = Int32.Parse(o.ToString());
                    }
                    catch (Exception x) { }
                    Zonename = o2.ToString();
                    txtTenKhuVuc.Text = Zonename;
                }catch ( Exception x) { }
            }else
            {

            }
        }
        int ZoneId_Post_;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoSuaTable.Checked)
            {
                int index = e.RowIndex;
                DataGridViewRow r = dgrTable.Rows[index];
                Object o = r.Cells[0].Value;
                Object o2 = r.Cells[1].Value;
                Object o3 = r.Cells[2].Value;

                 tableId = Int32.Parse(o.ToString());
                tableName = o2.ToString();
                txtTenBan.Text = tableName;
                try
                {
                    ZoneId_Post_ = Int32.Parse(o3.ToString()); // cbxKhuVuc.SelectedValue;
                } catch (Exception x) { }
            }
            else
            {

            }
        }

        private void btnThemMoiTable_Click(object sender, EventArgs e)
        {
            int seat = (int)txtNumberOfSeat.Value;
            int shopId = Int32.Parse(DataFromServer.shopIdStr);
            String data = "";
            if (rdoThemMoiTable.Checked)
            {
                Object o = cbxKhuVuc.SelectedValue;
                try
                {
                    ZoneId_Post_ = Int32.Parse( o.ToString());
                }catch (Exception x) { }

                  Table_Post_2 p = new Table_Post_2( ZoneId_Post_,shopId, seat, txtTenBan.Text);
            //    Table_Post p = new Table_Post( ZoneId_Post_, shopId, seat, txtTenBan.Text);
                data = Utils.postDataToServer3(action2, DataFromServer.token, p);
            }
            else
            {  
            Table_Post p = null;
                p = new Table_Post(tableId, ZoneId_Post_,shopId, seat, txtTenBan.Text);
                 data = Utils.postDataToServer3(action2, DataFromServer.token, p);
            }
            int i = 0;          
            refreshData();
            dgrTable.DataSource = DataFromServer.lsTableZoneAll;
            dgrTable.Refresh();
            i++;
            i++;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        List<Modelss.TableZone> lsTableZoneAll = null;
        void getListAllTables()
        {
            foreach (var z in DataFromServer.lsZone)
            {
                foreach (TableZone t in z.shpTables)
                {
                    lsTableZoneAll.Add(t);
                }
              //  getListAllTables()
            }
        }

        private void cbxKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = " value: " + cbxKhuVuc.SelectedValue.ToString();
            Object o = cbxKhuVuc.SelectedValue;
            try { ZoneId_Post_ = Int32.Parse( o.ToString()) ; 
            } catch (Exception x  ) { }
            Text += "--- ZoneId_Post_ : " + ZoneId_Post_ ;
        }

        private void rdoSuaZone_CheckedChanged(object sender, EventArgs e)
        {
            btnThemMoiZone.Text = "Sửa khu vực";
        }

        private void rdoSuaTable_CheckedChanged(object sender, EventArgs e)
        {
            btnThemMoiTable.Text = "Sửa bàn ";
        }

        private void rdoThemMoiZone_CheckedChanged(object sender, EventArgs e)
        {
            btnThemMoiZone.Text = "Thêm mới khu vực";
        }

        private void rdoThemMoiTable_CheckedChanged(object sender, EventArgs e)
        {
            btnThemMoiTable.Text = "Thêm mới bàn ";
        }
    }
}
