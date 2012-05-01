using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _122908WebBrowser
{
    public partial class txtADDRESS : Form
    {
        public txtADDRESS()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            lblLOADING.Visible = true;
            webBROWSERWINDOW.Navigate(txtHTML.Text);

            txtHTML.Text = "";
            lblLOADING.Visible = false;
        }

        private void txtHTML_TextChanged(object sender, EventArgs e)
        {
            
            txtHTML.ForeColor = Color.Black;
        }

        private void txtADDRESS_Load(object sender, EventArgs e)
        {

        }


    }
}
