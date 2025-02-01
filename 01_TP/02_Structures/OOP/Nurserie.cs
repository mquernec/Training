public class Nurserie
{
    public void NourrirAnimal(ICarnivore animal)
    {
        animal.MangerViande();
    }

    public void NourrirAnimal(IHerbivore animal)
    {
        animal.MangerHerbe();
    }


    public Animal GenererAnimal()
    {
        Random random = new Random();
        int choix = random.Next(0, 4);
        switch (choix)
        {
            case 0:
                return new Chien();
            case 1:
                return new Chat();
            case 2:
                return new Poisson();
        }
              return new Oiseau();
    }
    public T GenererAnimal<T>() where T : Animal , new()
    {
      return  new T();
    }

    public void Inspecter(object chose)
    {
        if(chose is null)
        {
            Console.WriteLine("C'est un objet null");
            return ;
        }
        
        if (chose is Animal animal)
        {
            Console.WriteLine($"C'est un animal de l'espece {animal.Espece}");

         Console.WriteLine(AnalyseEspece( animal.Espece));
         Console.WriteLine(AnalysePoids(    animal.Poids ));
  Console.WriteLine(AnalysePoidsTaille(animal));

       
 }
        else
        {
            Console.WriteLine("Ce n'est pas un animal");
        }
    }


private string AnalyseEspece(Especes espece) =>
espece switch   {
       Especes.Chat => "C'est un chat",
       Especes.Chien => "C'est un chien",
       Especes.Poisson => "C'est un poisson",
       Especes.Oiseau => "C'est un oiseau",
       _ => "Je ne sais pas ce que c'est"
       };


       private string AnalysePoids(int poids) =>
       poids switch
    {
        (> 25) and (< 75) =>"poid normal",
        < 25 => "maigre ",
        > 75 => "gras",
        25 => "presque maigre",
        75 => "presque gras",
    };

     private string AnalysePoidsTaille(Animal animal) => animal switch
        {
            { Poids: > 75, Taille: > 75 } => "Beau bébé",
          { Poids: < 25, Taille: <25 } => "poids plume",
            _=> "rien a dire",
        };
}