## Objectif
Ajouter à chaque animal une méthode `mange`. La méthode doit :
1. Écrire dans la console "nom de l'animal commence à manger".
2. Attendre un nombre de secondes dépendant de l'espèce.
3. Écrire dans la console "nom de l'animal a fini de manger".

Faire manger tous les animaux d'un enclos en même temps.

## Exemple de Code

```csharp
Task taskA = new Task(() => Console.WriteLine("Hello from taskA."));
// Start the task.
taskA.Start();

// Output a message from the calling thread.
Console.WriteLine("Hello from thread '{0}'.", Thread.CurrentThread.Name);
taskA.Wait();
```



## Ressources Utiles
- [How to write a simple parallel foreach loop](https://learn.microsoft.com/fr-fr/dotnet/standard/parallel-programming/how-to-write-a-simple-parallel-foreach-loop)

