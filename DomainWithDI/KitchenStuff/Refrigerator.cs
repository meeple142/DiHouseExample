﻿namespace DomainWithDI.KitchenStuff;

// Refrigerator class
public class Refrigerator : IRefrigerator
{
    public void StoreFood()
    {
        Console.WriteLine("Food is being stored in the refrigerator.");
    }

    public void AdjustTemperature(int temperature)
    {
        Console.WriteLine($"Refrigerator temperature set to {temperature} degrees.");
    }
}
