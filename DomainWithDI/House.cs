using DomainWithDI.BedroomStuff;
using DomainWithDI.GarageStuff;
using DomainWithDI.KitchenStuff;

namespace DomainWithDI;

public class House
{
    private IKitchen _kitchen;
    private IBedroom _bedroom;
    private IGarage _garage;

    public House(IKitchen kitchen, IBedroom bedroom, IGarage garage)
    {
        _kitchen = kitchen;
        _bedroom = bedroom;
        _garage = garage;
    }

    public void StartDay()
    {
        Console.WriteLine("Starting the day:");
        _bedroom.UseLamp();
        _kitchen.UseRefrigerator();
        _garage.UseCar();
    }

    public void EndDay()
    {
        Console.WriteLine("Ending the day:");
        _kitchen.UseOven();
        _garage.UseBicycle();
        _bedroom.UseBed();
    }
}
