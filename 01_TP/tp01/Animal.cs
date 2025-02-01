using System.ComponentModel.DataAnnotations;
public class Animal
{
     [StringLength(10)]
    public string Nom { get; set; }
    public string Espece { get; set; }
    public int Age { get; set; }
    public int Taille { get; set; }
    public int Poids { get; set; }

    public Animal(string nom, string espece, int age)
    {
        Nom = nom;
        Espece = espece;
        Age = age;
    }
    public override string ToString()
    {
        return $"Nom: {Nom}, Espece: {Espece}, Age: {Age}";
    }
}