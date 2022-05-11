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

        public static string name = "";
        public static string email = "";
        public static string password = "";
        public static string eduLevel = "";

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
            frmMain formMainReg = new frmMain();

            string errors = "";
            int dotc = 0;
            int atc = 0;
            string emailText = txtEmailReg.Text;
            string pass = txtPassReg.Text;

            if(txtPassReg.Text!=txtConfReg.Text)
            {
                errors += "\r\nPassword does not match!";
            }

            for(int i=0;i< emailText.Length; i++)
            {
                if(emailText[i]=='@')
                {
                    atc++;
                }
                if(emailText[i]=='.')
                {
                    dotc++;
                }
            }

            if (!(dotc > 0 && atc == 1))
            {
                errors += "\r\nInvalid Email!";
            }

            if(txtNameReg.Text=="" || txtEmailReg.Text=="" || txtPassReg.Text=="" || txtConfReg.Text=="")
            {
                errors += "\r\nFields cannot be empty!";
            }

            if(pass.Length<8)
            {
                errors += "\r\nPassword should have at least 8 characters!";
            }

            if(errors=="")
            {
                name = txtNameReg.Text;
                email = txtEmailReg.Text;
                password = txtPassReg.Text;
                eduLevel = cmbEduReg.SelectedItem.ToString();

                formMainReg.Show();
                Close();
            }
            else
            {
                MessageBox.Show(errors, "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtNameReg.Focus();

            cmbEduReg.Items.Add("Undergraduate Student");
            cmbEduReg.Items.Add("Graduate Student");
            cmbEduReg.Items.Add("Non Student");
        }
    }
}
