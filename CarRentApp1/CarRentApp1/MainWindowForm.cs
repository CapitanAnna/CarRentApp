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
        private CarRentDbContext _dbContext=new CarRentDbContext();

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

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddEditRentalForm"))
            {
                var addRentalForm = new AddEditRentalForm();
                addRentalForm.Text = "Add Rental Form";
                addRentalForm.Show();
            }
        }

        private void editRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = (int)dgvCarRentalRecords.SelectedRows[0].Cells["Id"].Value;

            if (index<0)
            {
                MessageBox.Show("Please, select an item from the grid");
            }
            else
            {
                var carRentalRecord = _dbContext.CarRentalRecords.FirstOrDefault(x=> x.Id==index);

                if (carRentalRecord!=null)
                {
                    if (!Utils.FormIsOpen("AddEditRentalForm"))
                    {
                        var addRentalForm = new AddEditRentalForm(carRentalRecord);
                        addRentalForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Record is not available");
                }
            }
            
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            ////Load CarRecordsGrid
            var carRecords = _dbContext.CarRentalRecords
                .Select(x => new { 
                 x.CustomerName,
                 x.Cost,
                 x.DateRented,
                 x.DateReturned,
                 x.Id,
                 Car=x.TypesOfCars.Make,
                 x.TypesOfCarId
                }).ToList();

            dgvCarRentalRecords.DataSource = carRecords;
            dgvCarRentalRecords.Columns["Id"].Visible = false;//hide column
            dgvCarRentalRecords.Columns["TypesOfCarId"].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MainWindowForm window = new MainWindowForm();
            window.Show();
            this.Hide();
        }
    }
}
