# Projet de Test et Benchmarking

## Création de Projet de Tests Unitaires
```bash
dotnet new mstest -o test
```

## Création de Projet de Benchmark
```bash
dotnet new console -o benchmark
```

### Ajouter BenchmarkDotNet
[BenchmarkDotNet GitHub](https://github.com/dotnet/BenchmarkDotNet)
```bash
dotnet add package BenchmarkDotNet
```

## SonarQube (Démonstration)
### Installation et Exécution de SonarQube
```bash
docker pull sonarqube
docker run --name Sonarqube --publish 9000:9000 sonarqube
dotnet tool install --global dotnet-sonarscanner
```

## Ressources Utiles
- [Profiling avec BenchmarkDotNet](https://learn.microsoft.com/fr-fr/visualstudio/profiling/profiling-with-benchmark-dotnet?view=vs-2022)
- [Analyse de Code avec SonarQube et Docker](https://dev.to/chindara/sonarqube-docker-net-core-code-analysis-44)
- [Valeurs des Métriques de Code](https://learn.microsoft.com/fr-fr/visualstudio/code-quality/code-metrics-values?view=vs-2022)
- [Vue d'ensemble des Analyseurs Roslyn](https://learn.microsoft.com/fr-fr/visualstudio/code-quality/roslyn-analyzers-overview?view=vs-2022)
- [Guide de Style de Codage .NET](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md)

## Exemple de Benchmark
### Créer un Benchmark (ajouter les `using`)

```csharp
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
```

```csharp
using BenchmarkDotNet.Running;


var summary = BenchmarkRunner.Run<Bench>();  
    Console.WriteLine(summary);

```
### Modifier le Benchmark pour Diminuer le Nombre d'Itérations

```csharp
[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net90)]
[MaxIterationCount(16)]
[MemoryDiagnoser]
```
### Modifier le Benchmark pour Cibler Plusieurs Frameworks
```xml
  <TargetFrameworks>net7.0;net8.0;net9.0</TargetFrameworks>
```

### Lancer le Benchmark
```bash
dotnet run -c release --framework net9.0
```

### Exemple benchmark
concatenation de chaines


## Warnings du Compilateur
- Liste des warnings et comment les résoudre.

## Guide Line Microsoft (Démonstration)
- [Profiling avec BenchmarkDotNet](https://learn.microsoft.com/fr-fr/visualstudio/profiling/profiling-with-benchmark-dotnet?view=vs-2022)
- [Analyse de Code avec SonarQube et Docker](https://dev.to/chindara/sonarqube-docker-net-core-code-analysis-44)
- [Valeurs des Métriques de Code](https://learn.microsoft.com/fr-fr/visualstudio/code-quality/code-metrics-values?view=vs-2022)
- [Vue d'ensemble des Analyseurs Roslyn](https://learn.microsoft.com/fr-fr/visualstudio/code-quality/roslyn-analyzers-overview?view=vs-2022)
- [Guide de Style de Codage .NET](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md)

