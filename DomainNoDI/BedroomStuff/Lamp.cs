namespace DomainNoDI.BedroomStuff;

// Lamp class
public class Lamp : ILamp
{
    public void TurnOn()
    {
        Console.WriteLine("The lamp is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("The lamp is turned off.");
    }
}
