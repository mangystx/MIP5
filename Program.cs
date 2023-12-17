using _5.Hubs;

var command13 = new CommandHub(13, new Dictionary<int, int>
{
    { 1, 8 },
    { 2, 5 },
    { 3, 6 },
    { 4, 4 }
}, new Dictionary<int, int>
{
    { 1, 25 },
    { 2, 30 },
    { 3, 26 },
    { 4, 32 }
}, 3.4);

var command14 = new CommandHub(14, new Dictionary<int, int>
{
    { 5, 5 },
    { 6, 7 },
    { 7, 6 },
    { 8, 8 }
}, new Dictionary<int, int>
{
    { 5, 28 },
    { 6, 22 },
    { 7, 24 },
    { 8, 20}
}, 3.6);

var handle9 = new HandleHub(9, new Dictionary<int, int>
{
    { 1, 4 },
    { 3, 8 },
}, new Dictionary<int, int>
{
    { 1, 28 },
    { 3, 18 },
}, 1.1);

var handle10 = new HandleHub(10, new Dictionary<int, int>
{
    { 2, 6 },
    { 5, 4 },
}, new Dictionary<int, int>
{
    { 2, 18 },
    { 5, 28 },
}, 1.3);

var handle11 = new HandleHub(11, new Dictionary<int, int>
{
    { 4, 5 },
    { 7, 5 },
}, new Dictionary<int, int>
{
    { 4, 24 },
    { 7, 30 },
}, 1.1);

var handle12 = new HandleHub(12, new Dictionary<int, int>
{
    { 6, 7 },
    { 8, 9 },
}, new Dictionary<int, int>
{
    { 6, 25 },
    { 8, 22 },
}, 1.2);

var collect1 = new CollectionHub(1, 5, 20, 10, handle9, 1);
var collect2 = new CollectionHub(2, 8, 25, 7, handle10, 1);
var collect3 = new CollectionHub(3, 6, 18, 8, handle9, 2);
var collect4 = new CollectionHub(4, 12, 22, 6, handle11, 1);
var collect5 = new CollectionHub(5, 7, 30, 9, handle10, 2);
var collect6 = new CollectionHub(6, 15, 26, 5, handle12, 1);
var collect7 = new CollectionHub(7, 1, 24, 6, handle11, 2);
var collect8 = new CollectionHub(8, 4, 32, 10, handle12, 2);

void Test()
{
    for (int i = 22; i >= 1; i--)
    {
        collect1.Start(i);
    }
}