public class RentalAgency
{
    private List<Vehicle> Fleet = new List<Vehicle>();
    public decimal TotalRevenue { get; private set; } = 0;

    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
    }

    public void RentVehicle(Vehicle vehicle)
    {
        if (Fleet.Contains(vehicle))
        {
            Fleet.Remove(vehicle);
            TotalRevenue += vehicle.RentalPrice;
            Console.WriteLine($"{vehicle.Model} has been rented.");
        }
        else
        {
            Console.WriteLine($"{vehicle.Model} is not available for rent.");
        }
    }

    public void DisplayFleet()
    {
        Console.WriteLine("Available Vehicles for Rent:");
        foreach (var vehicle in Fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine("--------------------------------");
        }
    }
}
