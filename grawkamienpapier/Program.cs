class Gra
{
    static void Main(string[] args)
    {
        Random rnd = new Random(); 
        int wybor_komputera = rnd.Next(3);
        Console.WriteLine("Witaj w grze kamień papier nożyce! Zmierz sie z naszym komputerem");
        Console.WriteLine("Wybierz Kamień(k), papier(p), nożyce(n)");
        string wybor_gracza = Console.ReadLine();
        int wybor_gracza_int;
        if (wybor_gracza == "k")
        {
            wybor_gracza_int = 0;
        } 
        else if (wybor_gracza == "p")
        {
            wybor_gracza_int = 1;
        } 
        else if (wybor_gracza == "n")
        {
            wybor_gracza_int = 2;
        } 
        else
        {
            Console.WriteLine("Zły wybór");
        }
        

        
    }
}
