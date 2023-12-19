namespace _5.Hubs;

public class CommandHub
{
    public CommandHub(int number, Dictionary<int, double> handleTime, Dictionary<int, int> costs, double aggregation,
        CollectHub hub1, CollectHub hub2, CollectHub hub3, CollectHub hub4)
    {
        Number = number;
        HandleTime = handleTime;
        Costs = costs;
        Aggregation = aggregation;
        double cef = 2 * (1 - hub1.Intensity * HandleTime[hub1.Number] / Aggregation +
                          hub2.Intensity * HandleTime[hub2.Number] / Aggregation +
                          hub3.Intensity * HandleTime[hub3.Number] / Aggregation +
                          hub4.Intensity * HandleTime[hub4.Number] / Aggregation);
        
        HandleTimeRes = hub1.Intensity * Math.Pow(HandleTime[hub1.Number], 2) / cef +
                        hub2.Intensity * Math.Pow(HandleTime[hub2.Number], 2) / cef +
                        hub3.Intensity * Math.Pow(HandleTime[hub3.Number], 2) / cef +
                        hub4.Intensity * Math.Pow(HandleTime[hub4.Number], 2) / cef;
        
        CostsRes = hub1.Intensity * Costs[hub1.Number] / Aggregation +
                   hub2.Intensity * Costs[hub2.Number] / Aggregation + 
                   hub3.Intensity * Costs[hub3.Number] / Aggregation +
                   hub4.Intensity * Costs[hub4.Number] / Aggregation;
    }

    public double HandleTimeRes { get; set; }

    public double CostsRes { get; set; }
    
    public double Aggregation { get; set; }
    
    public int Number { get; set; }
    
    public Dictionary<int, double> HandleTime { get; set; }
    
    public Dictionary<int, int> Costs { get; set; }

    public void AverageHandleTimeAndCosts()
    {
        Console.WriteLine(
            $"Average handle time for hub {Number} -> {Math.Round(HandleTimeRes, 2)}\n" +
            $"Average costs for hub {Number} -> {Math.Round(CostsRes, 2)}\n");
    }
}