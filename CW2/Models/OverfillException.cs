namespace CW2.Models;

public class OverfillException : Exception
{
    public OverfillException()
    {
        Console.WriteLine("Overfill!!!");
    }
}