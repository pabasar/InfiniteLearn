using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfiniteLearn
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            string name = frmRegister.name;
            string email = frmRegister.email;
            string password = frmRegister.password;
            string eduLevel = frmRegister.eduLevel;

            if(name=="" && email=="" && password=="" && eduLevel=="")
            {
                DisableAll();
            }
            else
            {
                btnLoginMain.Text = "Logout";
                btnRegisterMain.Enabled = false;
                EnableAll();

                rdoBeginner.Checked = true;
                grpUser.Text = "Welcome "+name;
            }
        }

        private void btnLoginMain_Click(object sender, EventArgs e)
        {
            if(btnLoginMain.Text == "Logout")
            {
                DisableAll();
                btnLoginMain.Text = "Login";
            }
            else
            {
                frmLogin logFormMain = new frmLogin();
                logFormMain.Show();
                Hide();
            }
            
        }

        private void btnRegisterMain_Click(object sender, EventArgs e)
        {
            frmRegister regFormMain = new frmRegister();
            regFormMain.Show();
            Hide();
        }

        public void DisableAll()
        {
            grpLevel.Enabled = false;
            grpCategory.Enabled = false;
            btnEnroll.Enabled = false;
        }

        public void EnableAll()
        {
            grpLevel.Enabled = true;
            grpCategory.Enabled = true;
            btnEnroll.Enabled = true;
        }

        private void rdoBeginner_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoIntermediate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAdvanced_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
