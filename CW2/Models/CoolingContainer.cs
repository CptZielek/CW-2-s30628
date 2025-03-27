namespace CW2.Models;

public class CoolingContainer(
    double mass,
    double height,
    double depth,
    double capacity, 
    double temprature)
    : Container(mass, height, depth, capacity, "C")
{
    public Dictionary<string, double> CoolingDictionary { get; } = new Dictionary<string, double>()
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice cream", -18 },
        { "Frozen pizza", -30 },
    }; 
    public string? ProductType{ get; set; }
    public double Temprature { get; set; } = temprature;
    
    public void Load(double load, string productType)
    {
        if (CoolingDictionary[productType] != Temprature)
        {
            Console.WriteLine("Zła temperatura dla: "+productType);
        }
        else
        {
            ProductType = productType;
            base.Load(load);
        }
    }
}