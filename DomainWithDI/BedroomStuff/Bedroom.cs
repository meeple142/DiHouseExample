namespace DomainWithDI.BedroomStuff;

// Bedroom class
public class Bedroom 
{
    private Bed _bed;
    private Wardrobe _wardrobe;
    private Lamp _lamp;

    public Bedroom()
    {
        _bed = new Bed();
        _wardrobe = new Wardrobe();
        _lamp = new Lamp();
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