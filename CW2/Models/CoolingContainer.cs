namespace CW2.Models;

public class CoolingContainer(
    double mass,
    double height,
    double depth,
    double capacity, 
    string productType, 
    double temprature)
    : Kontener(mass, height, depth, capacity, "C")
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
    public string ProductType { get; set; } = productType;
    public double Temprature { get; set; } = temprature;
}