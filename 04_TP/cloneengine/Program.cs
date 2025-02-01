using BenchmarkDotNet.Running;

#if DEBUG

     Enclosure e = new Enclosure("enclosure");
        for (int i = 0; i < 100; i++)
        {
            Animal a = new Animal("toto", 12, "cat");
            e.AddAnimal(a);
        }   
      
       var eating=await e.EatAsync();
#else

var summary = BenchmarkRunner.Run<Bench>();  
    Console.WriteLine(summary);
#endif
