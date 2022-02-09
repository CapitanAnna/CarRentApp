using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentApp1
{
    public class CarRentDbContext : DbContext
    {
        public CarRentDbContext() : base("MyConnectionString")
        {

        }
    }
}
