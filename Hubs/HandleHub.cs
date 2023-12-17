namespace _5.Hubs;

public class HandleHub : HubBase
{
    public HandleHub(int number, Dictionary<int, int> handleTime, Dictionary<int, int> costs, double aggregation) 
        : base(number, handleTime, costs)
    {
        Aggregation = aggregation;
    }

    public void AddNewProblem(int number, int timeLeft, int port)
    {
        bool alreadyAdded = false;
        switch (port)
        {
            case 1:
            {
                if (OnProcessing2)
                {
                    
                }
                if (OnProcessing1)
                {
                    Time1 += 10;
                   
                }
                break;
            }
                
            case 2:
            {
                break;
            }
        }
    }

    public double Aggregation { get; set; }

    public int Time1 { get; set; }
    
    public int Time2 { get; set; }
    
    private bool OnProcessing1 => Time1 < 0;
    
    private bool OnProcessing2 => Time2 < 0;
}