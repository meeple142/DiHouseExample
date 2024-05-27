namespace DomainWithDI.GarageStuff;

// Garage class
public class Garage
{
    private Car _car;
    private Toolbox _toolbox;
    private Bicycle _bicycle;

    public Garage()
    {
        _car = new Car();
        _toolbox = new Toolbox();
        _bicycle = new Bicycle();
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

