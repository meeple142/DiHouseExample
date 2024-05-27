namespace DomainWithDI.KitchenStuff;

// Dishwasher class
public class Dishwasher : IDishwasher
{
    public void WashDishes()
    {
        Console.WriteLine("Dishes are being washed in the dishwasher.");
    }

    public void DryDishes()
    {
        Console.WriteLine("Dishes are being dried in the dishwasher.");
    }
}
