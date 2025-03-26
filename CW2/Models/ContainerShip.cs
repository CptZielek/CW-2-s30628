using System.ComponentModel;

namespace CW2.Models;

public class ContainerShip(string name, double speed, int capacity, double mass)
{
    public string Name { get; set; } = name;
    public int Capacity { get; set; } = capacity;
    public double Speed { get; set; } = speed;
    public double Mass { get; set; } = mass;
    private List<Container> _containers = new List<Container>();

    public void AddContainer(Container container)
    {
        
    }
}