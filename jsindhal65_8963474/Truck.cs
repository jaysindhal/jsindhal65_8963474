using System;

public class Truck : Vehicle
{
    // Additional properties for Truck
    public int Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    // Constructor
    public Truck(string model, string manufacturer, int year, double rentalPrice,
                 int capacity, string truckType, bool fourWheelDrive)
                 : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    // Override DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails(); // Call base class method
        Console.WriteLine("Truck Details:");
        Console.WriteLine($"Capacity: {Capacity} tons");
        Console.WriteLine($"Truck Type: {TruckType}");
        Console.WriteLine($"Four Wheel Drive: {(FourWheelDrive ? "Yes" : "No")}");
    }
}
