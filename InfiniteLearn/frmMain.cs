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

        CheckBox[] additional = new CheckBox[2];

        string level = "";

        string name, email, password, eduLevel;

        public static string displayText = "";

        public void frmMain_Load(object sender, EventArgs e)
        {
            additional[0] = chkQuick;
            additional[1] = chkSelf;

            name = frmRegister.name;
            email = frmRegister.email;
            password = frmRegister.password;
            eduLevel = frmRegister.eduLevel;

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
                lstCategory.Items.Add("Mobile Development");
                lstCategory.Items.Add("Database");
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
            grpAdditional.Enabled = false;
            btnEnroll.Enabled = false;
        }

        public void EnableAll()
        {
            grpLevel.Enabled = true;
            grpCategory.Enabled = true;
            grpAdditional.Enabled = true;
            btnEnroll.Enabled = true;
        }

        private void rdoBeginner_CheckedChanged(object sender, EventArgs e)
        {
            level = rdoBeginner.Text;
            lstCategory.SelectedItem = null;
        }

        private void rdoIntermediate_CheckedChanged(object sender, EventArgs e)
        {
            level = rdoIntermediate.Text;
            lstCategory.SelectedItem = null;
        }

        private void rdoAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            level = rdoAdvanced.Text;
            lstCategory.SelectedItem = null;
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailable.Items.Clear();
            if(lstCategory.SelectedItem != null)
            {
                if (lstCategory.SelectedItem.ToString() == "Programming")
                {
                    lstAvailable.Items.Add("C++ " + level + " Training");
                    lstAvailable.Items.Add("Python " + level + " Training");
                    lstAvailable.Items.Add("Scala " + level + " Training");
                    lstAvailable.Items.Add("Ruby " + level + " Training");
                    lstAvailable.Items.Add("Dart " + level + " Training");
                    lstAvailable.Items.Add("Java " + level + " Training");
                    lstAvailable.Items.Add("PHP " + level + " Training");
                    lstAvailable.Items.Add("C# " + level + " Training");
                    lstAvailable.Items.Add("R " + level + " Training");
                    lstAvailable.Items.Add("Groovy " + level + " Training");
                    lstAvailable.Sorted = true;
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
                    lstAvailable.Items.Add("Neural Networks " + level + " Training");
                    lstAvailable.Items.Add("Time Series Analysis " + level + " Training");
                    lstAvailable.Sorted = true;
                }
                else if (lstCategory.SelectedItem.ToString() == "Software")
                {
                    lstAvailable.Items.Add("Open Office " + level + " Training");
                    lstAvailable.Items.Add("Zoho " + level + " Training");
                    lstAvailable.Items.Add("Keynote " + level + " Training");
                    lstAvailable.Items.Add("Corel Draw " + level + " Training");
                    lstAvailable.Items.Add("Inkscape " + level + " Training");
                    lstAvailable.Items.Add("Photoshop " + level + " Training");
                    lstAvailable.Items.Add("Cubase " + level + " Training");
                    lstAvailable.Items.Add("Inventor " + level + " Training");
                    lstAvailable.Items.Add("Gimp " + level + " Training");
                    lstAvailable.Items.Add("Sketchup " + level + " Training");
                    lstAvailable.Sorted = true;
                }
                else if (lstCategory.SelectedItem.ToString() == "Mobile Development")
                {
                    lstAvailable.Items.Add("Andriod Programming " + level + " Training");
                    lstAvailable.Items.Add("Aurelia " + level + " Training");
                    lstAvailable.Items.Add("Cordova " + level + " Training");
                    lstAvailable.Items.Add("Flutter " + level + " Training");
                    lstAvailable.Items.Add("Google AMP " + level + " Training");
                    lstAvailable.Items.Add("Ionic " + level + " Training");
                    lstAvailable.Items.Add("Swift " + level + " Training");
                    lstAvailable.Items.Add("jQuery Mobile " + level + " Training");
                    lstAvailable.Items.Add("Kotlin " + level + " Training");
                    lstAvailable.Items.Add("Angular " + level + " Training");
                    lstAvailable.Sorted = true;
                }
                else if (lstCategory.SelectedItem.ToString() == "Database")
                {
                    lstAvailable.Items.Add("MySQL " + level + " Training");
                    lstAvailable.Items.Add("Amazon RDS " + level + " Training");
                    lstAvailable.Items.Add("Apache Derby " + level + " Training");
                    lstAvailable.Items.Add("ArangoDB " + level + " Training");
                    lstAvailable.Items.Add("DocumentDB " + level + " Training");
                    lstAvailable.Items.Add("DynamoDB " + level + " Training");
                    lstAvailable.Items.Add("MongoDB " + level + " Training");
                    lstAvailable.Items.Add("MariaDB " + level + " Training");
                    lstAvailable.Items.Add("DB2 " + level + " Training");
                    lstAvailable.Items.Add("SQLite " + level + " Training");
                    lstAvailable.Sorted = true;
                }
            }
            
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            int courseCost = 5000;
            int multCost = courseCost*lstAvailable.SelectedItems.Count;
            int discount = 0;
            double finalCost = 0;

            if(eduLevel=="Undergraduate Student")
            {
                discount = 40;
            }
            else if(eduLevel=="Graduate Student")
            {
                discount = 20;
            }

            string additionalMaterials = "";
            int addi = 0;

            for (int i = 0; i < additional.Length; i++)
            {
                if (additional[i].Checked)
                {
                    additionalMaterials += "\n" + additional[i].Text;
                    addi += 100;
                }
            }

            finalCost = multCost * (100 - discount) / 100;
            finalCost += addi;
            string msg = "Cost is " + finalCost.ToString() + " LKR. Want to Proceed?";

            displayText = "";
            displayText += "Dear " + name;
            displayText += "\n\nYou are now enrolled in following courses:";

            for(int i=0;i<lstAvailable.SelectedItems.Count;i++)
            {
                displayText += "\n" + lstAvailable.SelectedItems[i].ToString();
            }

            if(additionalMaterials!="")
            {
                displayText += "\n\nIncluded Additional Materials:" + additionalMaterials;
            }

            displayText += "\n\n" + finalCost.ToString() + " LKR has been charged.";

            DialogResult response = MessageBox.Show(msg, "Checkout", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (response == DialogResult.OK)
            {
                frmDisplay displayForm = new frmDisplay();
                displayForm.Show();
            }       
        }
    }
}
