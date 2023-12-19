using _5.Hubs;

var collect1 = new CollectHub(1, 0.5, 20, 10);
var collect2 = new CollectHub(2, 0.8, 25, 7);
var collect3 = new CollectHub(3, 0.6, 18, 8);
var collect4 = new CollectHub(4, 1.2, 22, 6);
var collect5 = new CollectHub(5, 0.7, 30, 9);
var collect6 = new CollectHub(6, 1.5, 26, 5);
var collect7 = new CollectHub(7, 0.1, 24, 6);
var collect8 = new CollectHub(8, 0.4, 32, 10);

var handle9 = new HandleHub(9, new Dictionary<int, double>
{
    { 1, 0.4 },
    { 3, 0.8 },
}, new Dictionary<int, int>
{
    { 1, 28 },
    { 3, 18 },
}, 1.1, collect1, collect3);

var handle10 = new HandleHub(10, new Dictionary<int, double>
{
    { 2, 0.6 },
    { 5, 0.4 },
}, new Dictionary<int, int>
{
    { 2, 18 },
    { 5, 28 },
}, 1.3, collect2, collect5);

var handle11 = new HandleHub(11, new Dictionary<int, double>
{
    { 4, 0.5 },
    { 7, 0.5 },
}, new Dictionary<int, int>
{
    { 4, 24 },
    { 7, 30 },
}, 1.1, collect4, collect7);

var handle12 = new HandleHub(12, new Dictionary<int, double>
{
    { 6, 0.7 },
    { 8, 0.9 },
}, new Dictionary<int, int>
{
    { 6, 25 },
    { 8, 22 },
}, 1.2, collect6, collect8);

var command13 = new CommandHub(13, new Dictionary<int, double>
{
    { 1, 0.8 },
    { 2, 0.5 },
    { 3, 0.6 },
    { 4, 0.4 }
}, new Dictionary<int, int>
{
    { 1, 25 },
    { 2, 30 },
    { 3, 26 },
    { 4, 32 }
}, 3.4, collect1, collect2, collect3, collect4);

var command14 = new CommandHub(14, new Dictionary<int, double>
{
    { 5, 0.5 },
    { 6, 0.7 },
    { 7, 0.6 },
    { 8, 0.8 }
}, new Dictionary<int, int>
{
    { 5, 28 },
    { 6, 22 },
    { 7, 24 },
    { 8, 20}
}, 3.6, collect5, collect6, collect7, collect8);

collect1.AverageHandleTimeAndCosts();
collect2.AverageHandleTimeAndCosts();
collect3.AverageHandleTimeAndCosts();
collect4.AverageHandleTimeAndCosts();
collect5.AverageHandleTimeAndCosts();
collect6.AverageHandleTimeAndCosts();
collect7.AverageHandleTimeAndCosts();
collect8.AverageHandleTimeAndCosts();

handle9.AverageHandleTimeAndCosts();
handle10.AverageHandleTimeAndCosts();
handle11.AverageHandleTimeAndCosts();
handle12.AverageHandleTimeAndCosts();

command13.AverageHandleTimeAndCosts();
command14.AverageHandleTimeAndCosts();