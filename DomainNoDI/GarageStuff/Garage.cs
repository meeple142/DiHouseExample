namespace DomainNoDI.GarageStuff;

// Garage class
public class Garage : IGarage
{
    private ICar _car;
    private IToolbox _toolbox;
    private IBicycle _bicycle;

    public Garage(ICar car, IToolbox toolbox, IBicycle bicycle)
    {
        _car = car;
        _toolbox = toolbox;
        _bicycle = bicycle;
    }

    public void UseCar()
    {
        _car.StartEngine();
        _car.StopEngine();
    }

    public void UseToolbox()
    {
        _toolbox.Open();
        _toolbox.Close();
    }

    public void UseBicycle()
    {
        _bicycle.Ride();
        _bicycle.Park();
    }
}

