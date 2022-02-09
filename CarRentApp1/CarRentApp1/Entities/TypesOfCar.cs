using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentApp1.Entities
{
    public class TypesOfCar
    {
        public int Id { get; set; }
        public string Make { get; set; }//Brand
        public string VIN { get; set; }
        public string LicensePlateNumber { get; set; }
        public int? Year { get; set; }

        public ICollection<CarRentalRecord> CarRentalRecords;

        
    }
}
