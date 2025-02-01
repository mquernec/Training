using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net90)]
[MaxIterationCount(16)]
[MemoryDiagnoser]
public class Bench
{


    [Benchmark]
    public string Test() => "toto".ToUpper();

  [Benchmark]
    public void Contact() 
    {
        string nom = "DUPONT";
        string prenom = "Jean";
        string nomComplet = nom + " " + prenom;
    }

    [Benchmark]
    public void Interpolation() 
    {
        string nom = "DUPONT";
        string prenom = "Jean";
        string nomComplet = $"{nom} {prenom}";
    }

    [Benchmark]
    public void Stringbuilder() 
    {
        string nom = "DUPONT";
        string prenom = "Jean";
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append(nom);
        sb.Append(" ");
        sb.Append(prenom);
        string nomComplet = sb.ToString();
    }
   
}