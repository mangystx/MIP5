namespace _5.Hubs;

public class CommandHub : HubBase
{
    public CommandHub(int number, Dictionary<int, int> handleTime, Dictionary<int, int> costs, double aggregation)
        : base(number, handleTime, costs)
    {
        Aggregation = aggregation;
    }

    public double Aggregation { get; set; }
}