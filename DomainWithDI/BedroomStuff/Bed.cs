namespace DomainWithDI.BedroomStuff;

// Bed class
public class Bed : IBed
{
    public void MakeBed()
    {
        Console.WriteLine("The bed is made.");
    }

    public void Sleep()
    {
        Console.WriteLine("Someone is sleeping in the bed.");
    }
}
