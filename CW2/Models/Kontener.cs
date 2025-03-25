namespace CW2.Models;

public class Kontener
{
    public double Mean { get; set; }
    public double Mass { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    public double Capacity { get; set; }
    public string SerialNumber { get; set; }
    public static int Number = 1;
    
    public Kontener(double mass, double height, double depth, double capacity)
    {
        Height = height;
        Depth = depth;
        Mass = mass;
        Capacity = capacity;
        Number++;
    }

    public virtual void Empty()
    {
        Mean = 0;
    }

    public virtual void Load(double load)
    {
        if (load > Capacity) throw new OverfillException();
        Mean = load;
    }
}