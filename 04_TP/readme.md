# Projet de Clonage et de Gestion d'Animaux

## Installation des Packages

```bash
dotnet add package BenchmarkDotNet 
dotnet add package MSTest
dotnet add package MSTest.TestFramework
dotnet add package Faker.Net
```

## Clonage d'Animaux

Nous ajoutons une machine à cloner : elle reçoit un animal en entrée et produit un animal identique en sortie.

## Comportement des Animaux

Tous les animaux doivent produire un cri (string en sortie).

## Génération d'Animaux

Générer une liste d'animaux ; ils doivent tous crier.

Pour créer des objets aléatoires, utilisez [faker-cs](https://github.com/oriches/faker-cs).


## Gestion des Enclos

Nous ajoutons la notion d’enclos : il faut pouvoir ajouter ou enlever des animaux à l'enclos.

Le cri doit contenir l'espèce de l'animal.


## Cri des Animaux dans un Enclos

Nous générons une quantité aléatoire d'animaux aléatoires dans un enclos.

Tous les animaux d'un enclos doivent crier ensemble. Créez une méthode qui renvoie les cris concaténés.

Chaque animal doit avoir son cri spécifique (avec son nom dedans par exemple).
