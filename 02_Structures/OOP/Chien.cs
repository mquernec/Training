public  class Chien:Animal,ICarnivore, IHerbivore,INageur  
{   
    public Chien()  
    {  
        Espece = Especes.Chien;  
    }  
    public void FaireDuBruit()  
    {  
        Console.WriteLine("Wouf");  
    }  
    public override void FairePlusDeBruit()  
    {  
        var oldColor = Console.ForegroundColor;  
        Console.ForegroundColor = ConsoleColor.Red;  
        Console.WriteLine($"WOUF !!! ");  
        Console.ForegroundColor = oldColor;  
    }

    public void MangerViande()
    {
        Console.WriteLine("Je mange de la viande");
    }

    public void MangerHerbe()
    {
        Console.WriteLine("Je mange de l'herbe");
    }

    public void Nager()
    {
        Console.WriteLine("Je me deplace en nageant");
    }

    public override void SeDeplacer()
    {  
        Console.WriteLine("Je me déplace en courant");  
        Nager();
    }

}