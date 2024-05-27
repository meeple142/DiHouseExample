namespace DomainWithDI.GarageStuff;

// Toolbox class
public class Toolbox : IToolbox
{
    public void Open()
    {
        Console.WriteLine("The toolbox is open.");
    }

    public void Close()
    {
        Console.WriteLine("The toolbox is closed.");
    }
}

