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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancelReg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkLoginReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin formLogReg = new frmLogin();
            formLogReg.Show();
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string errors = "";
            int emailValid = 0;

            if(txtPassReg.Text!=txtConfReg.Text)
            {
                errors += "Password does not match!";
            }

            for(int i=0;i<txtEmailReg.TextLength;i++)
            {
                if(txtEmailReg.Text[i]=='@')
                {
                    emailValid = 1;
                }
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            cmbEduReg.Items.Add("Undergraduate Student");
            cmbEduReg.Items.Add("Graduate Student");
        }
    }
}
