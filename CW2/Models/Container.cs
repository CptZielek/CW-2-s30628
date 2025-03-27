using CW2.Exceptions;

namespace CW2.Models;

public class Container
{
    public double Mean { get; set; }
    public double Mass { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    public double Capacity { get; set; }
    public string SerialNumber { get; set; }
    public string Type { get; set; }
    public static int Number = 1;
    
    public Container(double mass, double height, double depth, double capacity, string type)
    {
        Height = height;
        Depth = depth;
        Mass = mass;
        Capacity = capacity;
        Type = type;
        SerialNumber = "KON-"+type+"-"+Number++;
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

    public virtual void GetInfo()
    {
        Console.WriteLine(SerialNumber+"\nTyp: "+Type+"\nMasa własna: "+ Mass +"\nObciążenie: "+ Mean/Capacity*100+"%");
    }
}