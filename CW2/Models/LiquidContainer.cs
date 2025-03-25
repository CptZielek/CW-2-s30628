namespace CW2.Models;

public class LiquidContainer : Kontener, IIsHazardNotifier
{
    private bool IsHazardous { get; set; }
    
    public LiquidContainer(double mass, double height, double depth, double capacity, bool isHazardous) : base(mass, height, depth, capacity)
    {
        IsHazardous = isHazardous;
        Console.WriteLine("Utworzono L, numer " + Number);
        SerialNumber = "";
    }

    public override void Load(double load)
    {
        if (IsHazardous && load > Capacity * 0.5 || !IsHazardous && load > Capacity * 0.9) { Notify(); }
        else { base.Load(load); }
    }

    public void Notify()
    {
        Console.WriteLine("ALERT! HAZARD IN " + SerialNumber);
    }
}