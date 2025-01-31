# Objectifs
## 1 Creer differents types de projet :
    - Bibliotheque
    - Console
    - MAUI
    - AOT
   

## 2 Faire un build 
    - windows
    - linux
    - Single file
  
## 3 Observer les contenues des repertoires Bin et Obj

# Pratique

## 1 Creer differents types de projet
dotnet new list

dotnet workload list  

dotnet new classlib -o 01_classlib

dotnet new console -o 02_classlib

dotnet new maui -o 03_maui

dotnet new console --aot -o 04_console_aot

dotnet new console -o --no-self-contained  -o 05_NoSelfContained

dotnet new console --use-program-main -o 06_Main

parcourir les fichier csproj

    <OutputType>Exe</OutputType> => format de sortie

    <TargetFramework>net9.0</TargetFramework> => version du framework a utiliser

    <ImplicitUsings>enable</ImplicitUsings> => utilisation implicite des using

    <Nullable>enable</Nullable> => 

Observer la strucure du Program.cs => main implicite


## 2 & 3 Faire un build  et observer les bin et obj
dans les differents projet :
dotnet build
dotnet publish

dotnet publish --os linux --arch x64 /t:PublishContainer -c Release
dotnet build   --os linux --arch x64 /t:PublishContainer -c Release 

 dans 06_Main  ajouter 

    <PublishSingleFile>true</PublishSingleFile>
    <PublishTrimmed>true</PublishTrimmed>
dotnet build
dotnet publish