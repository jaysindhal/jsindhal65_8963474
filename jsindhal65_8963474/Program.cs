using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of vehicles
        Car car1 = new Car("Accord", "Honda", 2022, 50.0, 5, "V6", "Automatic", false);
        Truck truck1 = new Truck("Tacoma", "Toyota", 2021, 70.0, 2, "Pickup", true);
        Motorcycle bike1 = new Motorcycle("Ninja", "Kawasaki", 2020, 30.0, 1000, "Gasoline", true);

        // Creating rental agency
        RentalAgency agency = new RentalAgency();

        // Adding vehicles to the agency's fleet
        agency.AddVehicle(car1);
        agency.AddVehicle(truck1);
        agency.AddVehicle(bike1);

        // Displaying fleet details
        agency.DisplayFleet();

        // Renting a vehicle
        Console.WriteLine("\nRenting a vehicle:");
        agency.RentVehicle(car1);

        // Displaying fleet after renting
        Console.WriteLine("\nUpdated fleet after renting:");
        agency.DisplayFleet();

        // Displaying total revenue
        Console.WriteLine($"\nTotal Revenue: ${agency.TotalRevenue}");
    }
}
