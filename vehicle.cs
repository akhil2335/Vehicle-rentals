public abstract class Vehicle
{
    public string Model { get; private set; }
    public string Manufacturer { get; private set; }
    public int Year { get; private set; }
    public decimal RentalPrice { get; set; }

    protected Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        RentalPrice = rentalPrice;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice}");
    }
}
