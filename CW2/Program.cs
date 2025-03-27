using CW2.Models;

namespace CW2;

class Program
{
    static void Main(string[] args)
    {
        var kontenerowiec = new ContainerShip("Orzeł", 40.0, 5, 5); // 5 kontenerów i max 5000 kg

        kontenerowiec.AddContainer(new LiquidContainer(100,3,2, 1000,false));
        
        kontenerowiec.AddContainer(new LiquidContainer(100,3,2, 1000,true));
        
        kontenerowiec.AddContainer(new GasContainer(100,3,2, 1000,1.0));
        
        kontenerowiec.AddContainer(new GasContainer(100,3,2, 1000,0.0));
        
        kontenerowiec.AddContainer(new CoolingContainer(100,3,2, 1000,-1.5));
        
        kontenerowiec.Info();
    }
}