public class Oiseau : Animal, IVolant
{
    public Oiseau() : base()
    {
        Espece = Especes.Oiseau;
    }

    public void Voler()
    {
        Console.WriteLine("L'oiseau vole.");
    }
}