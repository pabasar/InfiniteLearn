﻿using System;
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
    }
}