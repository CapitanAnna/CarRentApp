using CarRentApp1.Entities;
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
    public partial class MainWindowForm : Form
    {
        private LoginForm _login;
        public string roleName;
        public User user; // !public User user;

        public MainWindowForm()
        {
            InitializeComponent();
        }
        public MainWindowForm(LoginForm login, User user)
        {
            InitializeComponent();
            _login = login;
            this.user = user;
            roleName = "Admin";//get role from user
            //так мы показываем hash пароль
           // MessageBox.Show(this.user + " " + roleName);
        }
        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsersForm();
               // manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }

    }
}
