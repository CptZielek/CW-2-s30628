using System.Text;

namespace CW2.Models;

public class ContainerShip(string name, double maxSpeed, int maxCapacity, double maxMean)
{
    public string Name { get; set; } = name;
    public int MaxCapacity { get; set; } = maxCapacity;
    public double MaxSpeed { get; set; } = maxSpeed;
    public double MaxMean { get; set; } = maxMean; // tu w tonach
    private List<Container> _containers = [];

    public void AddContainer(Container c)
    {
        if (IsFull())
        {
            _containers.Add(c);
        }
        else
        {
            Console.WriteLine("Kontenerowiec jest pełen - nie można dodać ");
        }
    }

    public void RemoveContainer(string serialNumber)
    {
        _containers.RemoveAll(c => c.SerialNumber == serialNumber); // i tak wsm znajdzie tylko jeden
    }

    public void ReplaceContainer(Container newC, string oldSerialNumber)
    {
        if (IsFull())
        {
            Console.WriteLine("Kontenerowiec pełen - nie można zamienić kontenerów");
            return;
        }
        if (_containers.Any(c => c.SerialNumber == oldSerialNumber))
        {
            _containers.RemoveAll(c => c.SerialNumber == oldSerialNumber);
            _containers.Add(newC);
        }
        else
        {
            Console.WriteLine("Nie ma takiego kontenera");
        }
    }

    public bool IsFull()
    {
        return (_containers.Count < MaxCapacity || GetCurrentMean() < MaxMean * 1000); // tu w kg
    }

    public double GetCurrentMean()
    {
        return _containers.Count != 0 ? _containers.Sum(c => c.Mean) + _containers.Sum(c => c.Mass) : 0;
    }

    public void ContainerInfo(string serialNumber)
    {
        _containers.Find(c => c.SerialNumber == serialNumber)?.GetInfo();
    }

    public void Info()
    {
        Console.WriteLine(Name+"\nŁadunek:");
        foreach (var c in _containers)
        {
            Console.WriteLine("========");
            c.GetInfo();
            Console.WriteLine("========");
        }
    }
}