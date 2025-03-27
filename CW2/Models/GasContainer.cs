namespace CW2.Models;

public class GasContainer(
    double mass, 
    double height, 
    double depth, 
    double capacity,
    double pressure)
    : Container(mass, height, depth, capacity, "G"), IIsHazardNotifier
{
    public double Pressure { get; set; } = pressure;
    
    public override void Empty()
    {
        Mean = 0.05 * Mean;
    }

    public void Notify()
    {
        Console.WriteLine("UWAGA! Niebezpieczeństwo w kontenerze " + SerialNumber);
    }
}