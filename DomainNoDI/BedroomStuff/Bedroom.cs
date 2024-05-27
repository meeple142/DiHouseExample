namespace DomainNoDI.BedroomStuff;

// Bedroom class
public class Bedroom : IBedroom
{
    private IBed _bed;
    private IWardrobe _wardrobe;
    private ILamp _lamp;

    public Bedroom(IBed bed, IWardrobe wardrobe, ILamp lamp)
    {
        _bed = bed;
        _wardrobe = wardrobe;
        _lamp = lamp;
    }

    public void UseBed()
    {
        _bed.MakeBed();
        _bed.Sleep();
    }

    public void UseWardrobe()
    {
        _wardrobe.Open();
        _wardrobe.Close();
    }

    public void UseLamp()
    {
        _lamp.TurnOn();
        _lamp.TurnOff();
    }
}