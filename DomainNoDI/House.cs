using DomainNoDI.BedroomStuff;
using DomainNoDI.GarageStuff;
using DomainNoDI.KitchenStuff;

namespace DomainNoDI;

public class House
{
    private Kitchen _kitchen;
    private Bedroom _bedroom;
    private Garage _garage;

    public House()
    {
        _kitchen = new Kitchen();
        _bedroom = new Bedroom();
        _garage = new Garage();
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
