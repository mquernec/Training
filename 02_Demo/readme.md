Creation 
dotnet new console -O demo02

class VoitureClass
{
    public string Immat{get;set;}
    public string Couleur{get;set;}
}

struct
VoitureStruct
{
    public string Immat{get;set;}
    public string Couleur{get;set;}
}

record
VoitureRecord
{
    public string Immat{get;set;}
    public string Couleur{get;set;}
}
 instancier chacun des type 2 fois avec les meme valeurs
 tester l'egalité

 creer un nouvelle objet en affectant un objet existant
 sur chaque nouvel objet changer l'immat.
 verifier l'immat de l'objet d origine

affectation, 
Struct ,record

creation d'une chaine.
j'affiche le premier element
j'affiche l'avant dernier element
j'affiche les caractere de 1 a 3
j'affiche les caracteres sauf le premier et le dernier
indexeurs ( ^ )

Creer class calculator
avec 2 propriete Add et Sub 
creer une instance, setter le 2 methodes

changer la methode add 

lambda 
action et func
Creer une lambda qui change la couleur de la voiture
sous forme de func
sous forme d'action
sur un struct 
sur un record

ajoute Puissance sur la classe voiture
switch sur puissance pour obtenir prix vignette (egalitié)
switch < et >
ajouter année production
switch sur puissance et anne

creer methode qui produit des listes event et des odd

ajouter des console .log
parcourir ces liste et afficher le nombre

transformer le event pour utiliser le yeld