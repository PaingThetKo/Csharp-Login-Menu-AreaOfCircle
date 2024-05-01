using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfCircle
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doLogin();
            }
        }

        private void doLogin()
        {
            String sUsername = "Paing";
            String sPassword = "Paing";
            String sUname = txtUname.Text.ToString();
            String sPass = txtPass.Text.ToString();

            if ((String.Compare(sUsername,sUname)==0) && (String.Compare(sPassword,sPass)==0))
            {
                this.Hide();
                frmMenu frmmenu = new frmMenu();
                frmmenu.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            doLogin();
        }
    }
}
