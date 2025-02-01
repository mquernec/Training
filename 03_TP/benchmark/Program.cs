using BenchmarkDotNet.Running;


var summary = BenchmarkRunner.Run<Bench>();  
    Console.WriteLine(summary);
