public  class Chat :Animal
{
    public Chat()
    {
        Espece = Especes.Chat;
    }


    public void FaireDuBruit()
    {
        Console.WriteLine("Miaou");
    }

    public override void FairePlusDeBruit()
    {
        var oldColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"MIAOU !!! ");
        Console.ForegroundColor = oldColor;
    }
}
