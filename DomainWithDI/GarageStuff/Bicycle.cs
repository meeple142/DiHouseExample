namespace DomainWithDI.GarageStuff;

// Bicycle class
public class Bicycle : IBicycle
{
    public void Ride()
    {
        Console.WriteLine("Riding the bicycle.");
    }

    public void Park()
    {
        Console.WriteLine("The bicycle is parked.");
    }
}

