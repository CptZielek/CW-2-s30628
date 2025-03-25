namespace CW2.Models;

public class CoolingContainer(
    double mass,
    double height,
    double depth,
    double capacity, 
    string productType, 
    double temprature)
    : Kontener(mass, height, depth, capacity)
{
    public string ProductType { get; set; } = productType;
    public double Temprature { get; set; } = temprature;
}