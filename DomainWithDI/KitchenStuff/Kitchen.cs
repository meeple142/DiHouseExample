namespace DomainWithDI.KitchenStuff;

// Kitchen class
public class Kitchen : IKitchen
{
    private IRefrigerator _refrigerator;
    private IOven _oven;
    private IDishwasher _dishwasher;

    public Kitchen(IRefrigerator refrigerator, IOven oven, IDishwasher dishwasher)
    {
        _refrigerator = refrigerator;
        _oven = oven;
        _dishwasher = dishwasher;
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