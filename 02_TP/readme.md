## Pratique 02

### Interpolation de Chaine
On reprend l'animal et on redéfinit le `ToString` avec une interpolation de chaîne. Si ce n'est pas déjà fait, créer une sous-classe.

### Enclos pour Type d'Animaux
Définir les enclos pour différents types d'animaux.

### Pattern Matching
Créer un analyseur d'animal pour :
- Analyser l'espèce
- Analyser le poids
- Analyser la taille

### Preprocessor Directives
Tracer les temps d'exécution de la méthode mais seulement en mode debug.

```csharp
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
Thread.Sleep(10000);
stopWatch.Stop();
// Get the elapsed time as a TimeSpan value.
TimeSpan ts = stopWatch.Elapsed;
Debug.WriteLine("Temps écoulé: " + ts.ToString());
```

Ajouter une condition pour le mode debug.

### Fonction de Trace
Créer une fonction de trace qui log le nom de la méthode courante.

[Documentation sur les attributs globaux en C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/attributes/global)
