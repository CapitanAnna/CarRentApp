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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUserList.SelectedRows[0].Cells["id"].Value;
                //query db for record
                //var user = dbContext.Users.FirstOrDefault(x => x.id == id); 
                var hashPassword = Utils.DefaultHashPassword();
                //user.password=hashPassword
                //dbContext.SaveChanges();
                MessageBox.Show("Password has been resert");
            }
            catch (Exception)
            {
                MessageBox.Show("Try again");
            }
        }
    }
}
