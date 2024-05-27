namespace DomainNoDI.KitchenStuff;

// Oven class
public class Oven : IOven
{
    public void Bake()
    {
        Console.WriteLine("Baking in the oven.");
    }

    public void SetTimer(int minutes)
    {
        Console.WriteLine($"Oven timer set for {minutes} minutes.");
    }
}
