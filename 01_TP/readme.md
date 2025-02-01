Creer un projet lib

Creer uns strucure “Animal”  pour stoker un nom, une espece une taille (cm) , un age ne anne et un poid(gramme) 
creer un animal  et afficher ses info sur la console

Ajoutes des contraintes : 
le nom doit faire max 25 characteres
l'espece ne peut pas changer apres la creation
l'espece appartient a la liste : "Oiseau", "Chat", "Chien","Poisson", "Ornithorinque"
Tableu de plage autorisée pour le poid et la taille par espece

On rajoute le dauphin
On a un nom par defaut contruit comme tel : espece-numero sequentielle
On peu fournir au constructeur une methode permettant de generer le nombre sequentielle

ajouter un faker pour genere des exemples
installer Faker.net
Faker.net
https://github.com/oriches/faker-cs


sing System.ComponentModel;
using System.ComponentModel.DataAnnotations;


    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
System.ComponentModel.DataAnnotations

https://docs.fluentvalidation.net/en/latest/