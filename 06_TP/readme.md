Pratique 06
ajouter un a chaque animal une methode "mange". la methode ecrit dans la console "nom de l'animal commence a manger", puis attend un nombre de seconde dependant de l'espece.
et ecrit dans la console "nom de l'animal a fini de manger"

faire manger tout les animaux d'un enclos en meme temps 
Task taskA = new Task( () => Console.WriteLine("Hello from taskA."));
      // Start the task.
      taskA.Start();

      // Output a message from the calling thread.
      Console.WriteLine("Hello from thread '{0}'.",
                        Thread.CurrentThread.Name);
      taskA.Wait();


        String[] files = Directory.GetFiles(args[0]);
      Parallel.For(0, files.Length,
                   index => { FileInfo fi = new FileInfo(files[index]);
                              long size = fi.Length;
                              Interlocked.Add(ref totalSize, size);
                   } );
https://learn.microsoft.com/fr-fr/dotnet/standard/parallel-programming/how-to-write-a-simple-parallel-foreach-loop
 source.AsParallel().WithDegreeOfParallelism(2)
progamation asynchrone .net
old scoold
Tasks
Task.run
Task.wait
task.result
WhenAll
WaitAll
 ContinueWith (promise)
async await
cancellation token
