public class Animal
{
    public string Nom { get; set; }
    public Especes Espece { get; set; }
    public int Taille { get; set; }
    public int Poids { get; set; }

    public Animal()
    {
   
        Random rnd = new Random();
        Taille = rnd.Next(1, 100);
        Poids = rnd.Next(1, 100);
    }


    public void Manger()
    {
        Console.WriteLine("Je mange");
    }
    public void Dormir()
    {
        throw new NotImplementedException("je ne sais pas dormir");
    }
    public virtual void SeDeplacer()
    {
        Console.WriteLine("Je me déplace");
    }
    public void FaireDuBruit()
    {
        Console.WriteLine("Je fais du bruit");
    }
    public virtual void FairePlusDeBruit()
    {
        Console.WriteLine("Je fais du bruit");
    }


}