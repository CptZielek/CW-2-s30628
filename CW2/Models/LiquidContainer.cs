namespace CW2.Models;

public class LiquidContainer(
    double mass, 
    double height, 
    double depth, 
    double capacity, 
    bool isHazardous)
    : Container(mass, height, depth, capacity, "L"), IIsHazardNotifier
{
    private bool IsHazardous { get; set; } = isHazardous;

    public override void Load(double load)
    {
        if (IsHazardous && load > Capacity * 0.5 || !IsHazardous && load > Capacity * 0.9)
        {
            Notify();
        }
        else
        {
            base.Load(load);
        }
    }

    public void Notify()
    {
        Console.WriteLine("ALERT! HAZARD IN " + SerialNumber);
    }
}