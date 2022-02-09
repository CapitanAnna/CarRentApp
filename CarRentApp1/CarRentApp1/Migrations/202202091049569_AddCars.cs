namespace CarRentApp1.Migrations
{
    using CarRentApp1.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    
    public partial class AddCars : DbMigration
    {
        public override void Up()
        {
            var dbContext = new CarRentDbContext();
            dbContext.TypesOfCars.Add(new TypesOfCar
            {
                Make = "Bugati",
                LicensePlateNumber = "df123",
                VIN = "456h",
                Year = 2020,
                CarRentalRecords = new List<CarRentalRecord>()
            }) ;
            dbContext.TypesOfCars.Add(new TypesOfCar
            {
                Make = "BMW",
                LicensePlateNumber = "gg456",
                VIN = "789kk",
                Year = 2021,
                CarRentalRecords = new List<CarRentalRecord>()
            });
            dbContext.TypesOfCars.Add(new TypesOfCar
            {
                Make = "Mercedes",
                LicensePlateNumber = "sd147",
                VIN = "423ll",
                Year = 2022,
                CarRentalRecords = new List<CarRentalRecord>()
            });
            dbContext.SaveChanges();
        }
        
        public override void Down()
        {
        }
    }
}
