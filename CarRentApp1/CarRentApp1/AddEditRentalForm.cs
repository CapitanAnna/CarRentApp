using CarRentApp1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp1
{
    public partial class AddEditRentalForm : Form
    {
        private CarRentDbContext _carRentDbContext = new CarRentDbContext();
        private bool _isEditMode;
        private CarRentalRecord _carRentalRecord;
        public AddEditRentalForm(CarRentalRecord carRentalRecord)
        {
            InitializeComponent();
            _carRentalRecord = carRentalRecord;
            //change button name
            btnSave.Text = "Update";
            //cahange form name
            this.Text = "EditRentalForm";
            tbCustomerName.Text = _carRentalRecord.CustomerName;
            tbCost.Text = _carRentalRecord.Cost.ToString();
            dtpDateRented.Text = _carRentalRecord.DateRented.Value.ToString();
            dtpDateReturned.Text = _carRentalRecord.DateReturned.Value.ToString();
            cbTypesOfCars.SelectedValue= _carRentalRecord.TypesOfCars.ToString();
        }
        public AddEditRentalForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //tbCustomerName.BackColor = Color.Transparent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var customerName = tbCustomerName.Text;
                var cost = Convert.ToDecimal(tbCost.Text);
                var dateRented = dtpDateRented.Value;
                var dateReturned = dtpDateReturned.Value;
                var typeOfCarId = (int)cbTypesOfCars.SelectedValue;

                if (string.IsNullOrEmpty(customerName))
                {
                    MessageBox.Show("Fill form customer name");
                }
                if (cost<=0)
                {
                    MessageBox.Show("Fill form cost");
                }
                if (dateReturned<dateRented)
                {
                    MessageBox.Show("Can't do like this!");//меняем местами dateRented and dateReturned
                }

                var car = new CarRentalRecord() //создаем модель
                {
                    CustomerName = customerName,
                    Cost = cost,
                    DateRented = dateRented,
                    DateReturned = dateReturned,
                    TypesOfCarId = typeOfCarId
                };

                if (_carRentalRecord!=null)
                {
                    _carRentalRecord.CustomerName = customerName;
                    _carRentalRecord.Cost = cost;
                    _carRentalRecord.DateRented = dateRented;
                    _carRentalRecord.DateReturned = dateReturned;
                    _carRentalRecord.TypesOfCarId = typeOfCarId;

                    //update
                    _carRentDbContext.CarRentalRecords.AddOrUpdate(_carRentalRecord);
                    _carRentDbContext.SaveChanges();
                }
                else
                {
                    //insert
                    _carRentDbContext.CarRentalRecords.Add(car);
                    _carRentDbContext.SaveChanges();
                }
                

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void AddEditRentalForm_Load(object sender, EventArgs e)
        {
            var cars = _carRentDbContext.TypesOfCars
                .Select(x=> new { x.Id,Name=x.Make}).ToList();  //создаем анонимный объект
            cbTypesOfCars.DisplayMember = "Name";
            cbTypesOfCars.ValueMember = "Id";
            cbTypesOfCars.DataSource = cars;

        }

       
    }
}
