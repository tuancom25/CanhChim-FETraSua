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
    public partial class FrmRegisterNewUser : Form
    {
        public FrmRegisterNewUser()
        {
            InitializeComponent();
        }

        private void FrmRegisterNewUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegister u = new UserRegister();
            u.citizenIdentity = txtCCCD.Text;// "123432123400";
            u.username = txtUsername.Text;
            u.fullName = txtFullname.Text;
            u.password = txtPass1.Text;
            u.password2 = txtPass2.Text;
            u.phoneNumber = txtPhone.Text;
            u.shopId = 3;
            List<int> roles = new List<int>();
            roles.Add(1); roles.Add(2); roles.Add(3); roles.Add(4);
            roles.Add(5); roles.Add(7); roles.Add(7);
            u.roleId = roles;
            //String data = Utils.getJsonFromObject(u);
            String response = Utils.postDataToServer2("shop-auth/register", DataFromServer.token, u);
            richTextBox1.Text = response;
        }
    }

    public class UserRegister
    {
        String username_, password_, password2_, fullName_, citizenIdentity_,
            phoneNumber_;
        int shopId_;
        int isOwner_ = 0;
        List<int> roleId_;// (multiple values) 

        public string username { get => username_; set => username_ = value; }
        public string password { get => password_; set => password_ = value; }
        public string password2 { get => password2_; set => password2_ = value; }
        public string fullName { get => fullName_; set => fullName_ = value; }
        public string citizenIdentity { get => citizenIdentity_; set => citizenIdentity_ = value; }
        public string phoneNumber { get => phoneNumber_; set => phoneNumber_ = value; }
        public int shopId { get => shopId_; set => shopId_ = value; }
        public List<int> roleId { get => roleId_; set => roleId_ = value; }
        public int isOwner { get => isOwner_; set => isOwner_ = value; }
        public bool validateUser()
        {
            return true; 
        }
    }
}
