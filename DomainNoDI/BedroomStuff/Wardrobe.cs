namespace DomainNoDI.BedroomStuff;

// Wardrobe class
public class Wardrobe : IWardrobe
{
    public void Open()
    {
        Console.WriteLine("The wardrobe is open.");
    }

    public void Close()
    {
        Console.WriteLine("The wardrobe is closed.");
    }
}
