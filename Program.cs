using System;

namespace VehicleRentalManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the rental agency
            RentalAgency rentalAgency = new RentalAgency();

            // Create instances of vehicles
            Car car = new Car("Model 3", "Tesla", 2020, 120.5m, 5, "Electric", "Automatic", false);
            Truck truck = new Truck("Silverado", "Chevrolet", 2018, 150.0m, 2000, "Pickup", true);
            Motorcycle motorcycle = new Motorcycle("Street 750", "Harley-Davidson", 2019, 85.0m, 750, "Petrol", false);

            // Add vehicles to the rental agency's fleet
            rentalAgency.AddVehicle(car);
            rentalAgency.AddVehicle(truck);
            rentalAgency.AddVehicle(motorcycle);

            Console.WriteLine("Initial Fleet:");
            rentalAgency.DisplayFleet();

            // Rent out a car
            Console.WriteLine("\nRenting out a car...");
            rentalAgency.RentVehicle(car);

            // Display the fleet after renting out a car
            Console.WriteLine("\nFleet after renting out a car:");
            rentalAgency.DisplayFleet();

            // Display total revenue
            Console.WriteLine($"Total Revenue: {rentalAgency.TotalRevenue:C2}");
        }
    }

    // Implementation of Vehicle, Car, Truck, Motorcycle, and RentalAgency classes goes here
}
