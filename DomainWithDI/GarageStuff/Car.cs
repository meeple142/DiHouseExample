namespace DomainWithDI.GarageStuff;

// Car class
public class Car : ICar
{
    public void StartEngine()
    {
        Console.WriteLine("The car engine is started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("The car engine is stopped.");
    }
}

