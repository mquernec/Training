using BenchmarkDotNet.Running;
List<int> list = new List<int>();
for (int i = 0; i < 5; i++)
{
    list.Add(i);
}
var maQuery = list.Where(x => x % 2 == 0).Select(x => x * 2);
foreach (var item in maQuery)
{
    Console.WriteLine(item);
}
for (int i = 0; i < 5; i++)
{
    list.Add(i);
}
foreach (var item in maQuery)
{
    Console.WriteLine(item);
}
var summary = BenchmarkRunner.Run<Bench>();  
    Console.WriteLine(summary);
