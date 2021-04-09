using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProcessProject.OtherClass;
using ProcessProject.OtherForm;
using ProcessProject.DB_Access;

namespace ProcessProject.OtherForm
{
    public partial class LoginForm : Form
    {
        public bool accept = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void _Load()
        {
            StringSource ss = new StringSource();
            txtUserName.Text = ss.Remember.Split('\n')[0];
            txtPassword.Text = ss.Remember.Split('\n')[1];
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginAccess lg = new LoginAccess();
            if (lg.getLogin(txtUserName.Text, txtPassword.Text))
            {
                accept = true;
                this.Close();
            }
            else accept = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            accept = false;
            this.Close();
        }
    }
}
