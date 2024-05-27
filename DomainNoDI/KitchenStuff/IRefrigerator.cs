﻿namespace DomainNoDI.KitchenStuff;

// Interface for Refrigerator
public interface IRefrigerator
{
    void StoreFood();
    void AdjustTemperature(int temperature);
}
