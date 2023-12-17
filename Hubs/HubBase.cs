namespace _5.Hubs;

public class HubBase
{
    public HubBase(int number, Dictionary<int, int> handleTime, Dictionary<int, int> costs)
    {
        Number = number;
        HandleTime = handleTime;
        Costs = costs;
    }

    public int Number { get; set; }
    
    public Dictionary<int, int> HandleTime { get; set; }
    
    public Dictionary<int, int> Costs { get; set; }
}