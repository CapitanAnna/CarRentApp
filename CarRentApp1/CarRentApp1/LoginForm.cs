using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //tbUsername.Text = Utils.HashPassword("1");//так мы видим hash пароля
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var dbContext = new CarRentDbContext();
            try
            {
                var name= tbUsername.Text;
                var password = tbPassword.Text;
                var hashPassword = Utils.HashPassword(password);
                //check for matching user name, password and active flag
                var userName = tbUsername.Text.Trim();
                var user = dbContext.Users.FirstOrDefault
                    (x => x.UserName == userName && x.Password == hashPassword && x.IsActive == true);
                if (user==null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var mainWindow = new MainWindowForm(this, user);
                    mainWindow.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error! please try again, in 5 min");
            }
            
        }

        

        private void tbPassword_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text)|| string.IsNullOrEmpty(tbPassword.Text))
            {
                //MessageBox.Show("Please fill form");
                label1.Text = "";
            }
            else
            {
                btnLogin.Enabled = true;
                btnLogin.Select();
            }
            
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(tbUsername.Text))
            //{
            //    label1.Text="Please fill username";
            //}
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                label1.Text = "Please fill username";
            }
        }
    }
}
