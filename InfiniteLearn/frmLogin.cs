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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelLog_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkRegLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister formRegLog = new frmRegister();
            formRegLog.Show();
            Close();
        }
    }
}
