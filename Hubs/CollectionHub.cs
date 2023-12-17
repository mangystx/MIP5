namespace _5.Hubs;

public class CollectionHub
{
    public CollectionHub(int number, int handleTime, int costs, int intensity, HandleHub target, int targetPort)
    {
        Intensity = intensity;
        Number = number;
        HandleTime = handleTime;
        Costs = costs;
        Target = target;
        TargetPort = targetPort;
        _random = new Random();
        Time = 0;
    }

    private readonly Random _random;
    
    public int Intensity { get; set; }

    public int Number { get; set; }

    public int HandleTime { get; set; }

    public int Costs { get; set; }

    public HandleHub Target { get; set; }

    public int TargetPort { get; }

    private int _time;
    
    private int Time { 
        get => _time;
        set
        {
            _time += value;
            if (Time > 10) _time = 10;
        } }

    private bool OnProcessing => Time < 0;
    
    public void Start(int daysLeft)
    {
        bool alreadyAdded = false;
        if (OnProcessing)
        {
            Time += 10;
            alreadyAdded = true;
        }
        
        if (_random.Next(1, daysLeft) > Intensity)
        {
            Intensity--;
            if (!alreadyAdded)
            {
                Time += 10;
            }
            
            Time -= HandleTime;
            if (!OnProcessing)
            {
                Target.AddNewProblem(Number, Time, TargetPort);
            }
        }
    }
}