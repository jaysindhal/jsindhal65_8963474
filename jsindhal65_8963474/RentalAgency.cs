using System;
using System.Collections.Generic;
using System.Linq;

public class RentalAgency
{
    private List<Vehicle> Fleet { get; set; }
    public double TotalRevenue { get; private set; }

    // Constructor
    public RentalAgency()
    {
        Fleet = new List<Vehicle>();
        TotalRevenue = 0;
    }

    // Method to add a vehicle to the fleet
    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
    }

    // Method to remove a vehicle from the fleet
    public void RemoveVehicle(Vehicle vehicle)
    {
        Fleet.Remove(vehicle);
    }

    // Method to rent a vehicle
    public void RentVehicle(Vehicle vehicle)
    {
        if (Fleet.Contains(vehicle))
        {
            Fleet.Remove(vehicle);
            Console.WriteLine($"Vehicle {vehicle.Model} has been rented.");
            TotalRevenue += vehicle.RentalPrice;
        }
        else
        {
            Console.WriteLine($"Vehicle {vehicle.Model} is not available for rent.");
        }
    }

    // Method to display all vehicles in the fleet
    public void DisplayFleet()
    {
        Console.WriteLine("Rental Agency Fleet:");
        foreach (var vehicle in Fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine();
        }
    }
}
