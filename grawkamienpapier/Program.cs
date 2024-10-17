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
        switch (wybor_gracza)
        {
            case "k":
                {
                    wybor_gracza_int = 0;
                    break;
                }
            case "p":
                {
                    wybor_gracza_int = 1;
                    break;
                }
            case "n":
                {
                    wybor_gracza_int = 2;
                    break;
                }
            default:
                Console.WriteLine("Zła odp");
                break;
        }
    }
}
