using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Text.Json;
using System.IO;
using BenchmarkDotNet.Running;


[MaxIterationCount(16)]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
[MemoryDiagnoser]
public class Bench10
{
     [GlobalSetup]
    public void Setup()
    {string inputAnimalfile = "animals10.json";
string inputEnclosfile = "enclosure10.json";
string inputAnimalEnclosurefile = "enclosureAnimal10.json";

if (File.Exists(inputAnimalfile))
{
    Console.WriteLine("File exists");
    var json = File.ReadAllText(inputAnimalfile);
    animals = JsonSerializer.Deserialize<List<Animal>>(json).ToList();
}
if (File.Exists(inputEnclosfile))
{
    var json = File.ReadAllText(inputEnclosfile);
    enclosures = JsonSerializer.Deserialize<List<Enclosure>>(json).ToList();
}
if (File.Exists(inputAnimalEnclosurefile))
{
    var json = File.ReadAllText(inputAnimalEnclosurefile);
    enclosAnimals = JsonSerializer.Deserialize<List<EnclosureAnimal>>(json).ToList();
}}
public static List<Animal> animals ;
public static List<Enclosure> enclosures ;
public static List<EnclosureAnimal> enclosAnimals ;
  
[Benchmark]  
    public int WithAggregator() 
    {
       
            Aggregator aggregator = animals
           .Aggregate(new Aggregator(),(aggregate, val) => {
                               Aggregator newone =  new Aggregator();
                                newone.SizeMax = Math.Max(aggregate.SizeMax, val.Size);
                                newone.SizeMin = aggregate.SizeMin!=0 ?Math.Min(aggregate.SizeMin, val.Size):val.Size;
                                newone.WeightMax = Math.Max(aggregate.WeightMax, int.Parse(val.Weight));
                                newone.WeightMin = aggregate.WeightMin!=0?Math.Min(aggregate.WeightMin, int.Parse(val.Weight)): int.Parse(val.Weight);

                                return newone;
           });
           return aggregator.SizeMax+aggregator.SizeMin+aggregator.WeightMax+aggregator.WeightMin;       
    }
 
    [Benchmark]
    public int  FirtThrought() 
    {
        var plusGrand = animals.Max(a => a.Size);
        var plusPetit = animals.Min(a => a.Size);
        var plusLourd = animals.Max(a => int.Parse(a.Weight));
        var plusLeger = animals.Min(a => int.Parse(a.Weight));
    return plusGrand+plusPetit+plusLourd+plusLeger;
      
    }

   

}