namespace _5.Hubs;

public class CollectHub
{
    public CollectHub(int number, double handleTime, int costs, int intensity)
    {
        Intensity = intensity;
        Number = number;
        HandleTime = handleTime;
        Costs = costs;
    }
    
    public int Intensity { get; set; }

    public int Number { get; set; }

    public double HandleTime { get; set; }

    public int Costs { get; set; }

    public void AverageHandleTimeAndCosts()
    {
        Console.WriteLine(
            $"Average handle time for hub {Number} -> {Math.Round(Intensity * HandleTime / (1.0 / (HandleTime - Intensity)), 2)}\n" +
            $"Average costs for hub {Number} -> {Intensity * Costs}\n");
    }
}