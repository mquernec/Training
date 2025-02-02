# Objectifs

## 1. Créer différents types de projet :
- Bibliothèque
- Console
- MAUI
- AOT

## 2. Faire un build 
- Windows
- Linux
- Single file

## 3. Observer les contenus des répertoires Bin et Obj

# Pratique

## 1. Créer différents types de projet

```bash
dotnet new list
dotnet workload list  
dotnet new classlib -o 01_classlib
dotnet new console -o 02_classlib
dotnet new maui -o 03_maui
dotnet new console --aot -o 04_console_aot
dotnet new console --no-self-contained -o 05_NoSelfContained
dotnet new console --use-program-main -o 06_Main
```

Parcourir les fichiers csproj :

```xml
<OutputType>Exe</OutputType> <!-- format de sortie -->
<TargetFramework>net9.0</TargetFramework> <!-- version du framework à utiliser -->
<ImplicitUsings>enable</ImplicitUsings> <!-- utilisation implicite des using -->
<Nullable>enable</Nullable> <!-- gestion des valeurs nullables -->
```

Observer la structure du `Program.cs` : main implicite

## 2 & 3. Faire un build et observer les bin et obj

Dans les différents projets :

```bash
dotnet build
dotnet publish
dotnet publish --os linux --arch x64 /t:PublishContainer -c Release
dotnet build --os linux --arch x64 /t:PublishContainer -c Release
```

Dans `06_Main`, ajouter :

```xml
<PublishSingleFile>true</PublishSingleFile>
<PublishTrimmed>true</PublishTrimmed>
```

Puis exécuter :

```bash
dotnet build
dotnet publish
```