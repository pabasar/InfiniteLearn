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

        private void frmMain_Load(object sender, EventArgs e)
        {
            DisableAll();

            
        }

        private void btnLoginMain_Click(object sender, EventArgs e)
        {
            frmLogin logFormMain = new frmLogin();
            logFormMain.Show();
        }

        private void btnRegisterMain_Click(object sender, EventArgs e)
        {
            frmRegister regFormMain = new frmRegister();
            regFormMain.Show();
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
    }
}
