namespace DomainWithDI.KitchenStuff;

// Interface for Oven
public interface IOven
{
    void Bake();
    void SetTimer(int minutes);
}
