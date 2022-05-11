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

        string level = "";

        public void frmMain_Load(object sender, EventArgs e)
        {
            string name = frmRegister.name;
            string email = frmRegister.email;
            string password = frmRegister.password;
            string eduLevel = frmRegister.eduLevel;

            if(name=="" && email=="" && password=="" && eduLevel=="")
            {
                DisableAll();
                btnLoginMain.Enabled = false;
            }
            else
            {
                btnLoginMain.Text = "Logout";
                btnRegisterMain.Enabled = false;
                EnableAll();

                rdoBeginner.Checked = true;
                grpUser.Text = "Hello "+name;

                lstCategory.Items.Add("Programming");
                lstCategory.Items.Add("Data Science");
                lstCategory.Items.Add("Software");
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
            level = rdoBeginner.Text;
        }

        private void rdoIntermediate_CheckedChanged(object sender, EventArgs e)
        {
            level = rdoIntermediate.Text;
        }

        private void rdoAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            level = rdoAdvanced.Text;
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailable.Items.Clear();
            if(lstCategory.SelectedItem.ToString()== "Programming")
            {
                lstAvailable.Items.Add("C++ " + level + " Training");
                lstAvailable.Items.Add("Python " + level + " Training");
                lstAvailable.Items.Add("Scala " + level + " Training");
                lstAvailable.Items.Add("Ruby " + level + " Training");
                lstAvailable.Items.Add("Dart " + level + " Training");
                lstAvailable.Items.Add("Java " + level + " Training");
                lstAvailable.Items.Add("PHP " + level + " Training");
                lstAvailable.Items.Add("C# " + level + " Training");
                lstAvailable.Items.Add("Visual Basic " + level + " Training");
                lstAvailable.Items.Add("Groovy " + level + " Training");
            }
            else if (lstCategory.SelectedItem.ToString() == "Data Science")
            {
                lstAvailable.Items.Add("Machine Learning " + level + " Training");
                lstAvailable.Items.Add("Statistical Analysis " + level + " Training");
                lstAvailable.Items.Add("Data Engineering " + level + " Training");
                lstAvailable.Items.Add("Data Visualization " + level + " Training");
                lstAvailable.Items.Add("Data Mining " + level + " Training");
                lstAvailable.Items.Add("Pattern Recognition " + level + " Training");
                lstAvailable.Items.Add("Marketing Data Analysis " + level + " Training");
                lstAvailable.Items.Add("Intelligent Systems " + level + " Training");
                lstAvailable.Items.Add("Knowledge Based Systems " + level + " Training");
                lstAvailable.Items.Add("Artificial Intelligence " + level + " Training");
            }
            if (lstCategory.SelectedItem.ToString() == "Software")
            {
                lstAvailable.Items.Add("Microsoft Word " + level + " Training");
                lstAvailable.Items.Add("Microsoft Excel " + level + " Training");
                lstAvailable.Items.Add("Microsoft Powerpoint " + level + " Training");
                lstAvailable.Items.Add("Corel Draw " + level + " Training");
                lstAvailable.Items.Add("Windows Movie Maker " + level + " Training");
                lstAvailable.Items.Add("Photoshop " + level + " Training");
                lstAvailable.Items.Add("Cubase " + level + " Training");
                lstAvailable.Items.Add("Windows 11 " + level + " Training");
                lstAvailable.Items.Add("Ubuntu " + level + " Training");
                lstAvailable.Items.Add("Sketchup " + level + " Training");
            }
        }
    }
}
