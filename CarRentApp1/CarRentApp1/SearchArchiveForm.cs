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
    public partial class SearchArchiveForm : Form
    {
        private CarRentDbContext _dbContext = new CarRentDbContext();
        public SearchArchiveForm()
        {
            InitializeComponent();
        }

        private void SearchArchiveForm_Load(object sender, EventArgs e)
        {
            
            //List<CarRentalRecord> carRentalRecord = new List<CarRentalRecord>();
            var carRentalRecord = _dbContext.CarRentalRecords
                .Select(x => new {

                x.CustomerName,
                x.Cost,
                x.DateRented,
                x.DateReturned,
                Car=x.TypesOfCars.Make //+ " " + x.TypesOfCars.Model,
                
                }).ToList();
            dgvCarRents.DataSource = carRentalRecord;

        }
    }
}
