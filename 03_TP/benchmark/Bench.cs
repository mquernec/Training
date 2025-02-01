using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net90)]
[MaxIterationCount(16)]
[MemoryDiagnoser]
public class Bench
{


    [Benchmark]
    public string Test() => "toto".ToUpper();

   
}