namespace DomainNoDI.KitchenStuff;

// Kitchen class
public class Kitchen
{
    private Refrigerator _refrigerator;
    private Oven _oven;
    private Dishwasher _dishwasher;

    public Kitchen()
    {
        _refrigerator = new Refrigerator();
        _oven = new Oven();
        _dishwasher = new Dishwasher();
    }

    public void UseRefrigerator()
    {
        _refrigerator.StoreFood();
        _refrigerator.AdjustTemperature(4);
    }

    public void UseOven()
    {
        _oven.Bake();
        _oven.SetTimer(30);
    }

    public void UseDishwasher()
    {
        _dishwasher.WashDishes();
        _dishwasher.DryDishes();
    }
}