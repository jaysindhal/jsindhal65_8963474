﻿using System;

public class Motorcycle : Vehicle
{
    // Additional properties for Motorcycle
    public int EngineCapacity { get; set; }
    public string FuelType { get; set; }
    public bool HasFairing { get; set; }

    // Constructor
    public Motorcycle(string model, string manufacturer, int year, double rentalPrice,
                      int engineCapacity, string fuelType, bool hasFairing)
                      : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

    // Override DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails(); // Call base class method
        Console.WriteLine("Motorcycle Details:");
        Console.WriteLine($"Engine Capacity: {EngineCapacity} cc");
        Console.WriteLine($"Fuel Type: {FuelType}");
        Console.WriteLine($"Has Fairing: {(HasFairing ? "Yes" : "No")}");
    }
}
