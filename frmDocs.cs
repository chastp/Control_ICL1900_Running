using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_ICL1904
{
    public partial class frmDocs : Form
    {
        public frmDocs(string strTextBox)
        {
            InitializeComponent();
            txtmanual.Text = "file:///" + strTextBox;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDocs_Load(object sender, EventArgs e)
        {
            Uri uri = new Uri(txtmanual.Text.ToString());
            webBrowser1.AllowNavigation = false;
            webBrowser1.Navigate(uri);
        }
    }
}
