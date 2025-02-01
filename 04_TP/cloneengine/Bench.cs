using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net90)]
[MaxIterationCount(16)]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
[MemoryDiagnoser]

public class Bench
{


    [Benchmark]  

    public void Clone() 
    {
        Animal a = new Animal("toto", 12, "cat");
        Animal b = CloneEngine.Clone(a);
       
    }
 
    [Benchmark]
    public void Clone2() 
    {
        Animal a = new Animal("toto", 12, "cat");
        Animal b = CloneEngine.Clone2(a) as Animal;
      
    }

    [Benchmark]
    public void Clone3() 
    {
        Animal a = new Animal("toto", 12, "cat");
        Animal b = CloneEngine.Clone<Animal>(a);
      
    }

}