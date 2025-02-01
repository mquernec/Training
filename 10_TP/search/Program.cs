using System.Text.Json;
using System.IO;
using BenchmarkDotNet.Running;


var summary = BenchmarkRunner.Run<Bench10>();  
    Console.WriteLine(summary);

