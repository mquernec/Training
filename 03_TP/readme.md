Creer projet TU
dotnet new mstest -o test
Creer projet benchmark
dotnet new console -o benchmark

https://github.com/dotnet/BenchmarkDotNet
dotnet add package BenchmarkDotNet 


SonarQube (demo)

Warning du compilateur

Guide line micrososft (demo)

https://learn.microsoft.com/fr-fr/visualstudio/profiling/profiling-with-benchmark-dotnet?view=vs-2022

https://dev.to/chindara/sonarqube-docker-net-core-code-analysis-44

https://learn.microsoft.com/fr-fr/visualstudio/code-quality/code-metrics-values?view=vs-2022

https://learn.microsoft.com/fr-fr/visualstudio/code-quality/roslyn-analyzers-overview?view=vs-2022


https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md

Warning du compilateur

Creer projet TU
dotnet new mstest -o test
Creer projet benchmark
dotnet new console -o benchmark

https://github.com/dotnet/BenchmarkDotNet
dotnet add package BenchmarkDotNet 
vreer un bench (ajouter les using)
modifier cf prod
modifie le bench pour diminuer nombre iteration

=> concatenation de strings

lancer
modifier le bench pour cible 2 framework
modifier le csproj pour supporter plusieurs framework
dotnet run -c release --framework net9.0

SonarQube (demo)

docker pull sonarqube
docker run --name Sonarqube --publish 9000:9000 sonarqube
dotnet tool install --global dotnet-sonarscanner




Guide line micrososft (demo)

https://learn.microsoft.com/fr-fr/visualstudio/profiling/profiling-with-benchmark-dotnet?view=vs-2022

https://dev.to/chindara/sonarqube-docker-net-core-code-analysis-44

https://learn.microsoft.com/fr-fr/visualstudio/code-quality/code-metrics-values?view=vs-2022

https://learn.microsoft.com/fr-fr/visualstudio/code-quality/roslyn-analyzers-overview?view=vs-2022


https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md

