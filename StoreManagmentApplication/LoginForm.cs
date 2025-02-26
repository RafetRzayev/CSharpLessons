using StoreManagmentApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagmentApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = Storage.Users.Find(x => x.Username == txtUsername.Text && x.Password == txtPassword.Text);

            if (user == null)
            {
                lblErrorMessage.Text = "Username or password is not corect";
            }
            else
            {
                lblErrorMessage.Text = "";

                if (user.UserType == UserType.Admin)
                {
                    var adminForm = new AdminForm();
                    adminForm.Show();
                }
                else if(user.UserType == UserType.Client)
                {
                    var clientForm = new ClientFomr();
                    clientForm.Show();
                }
            }
        }
    }
}
