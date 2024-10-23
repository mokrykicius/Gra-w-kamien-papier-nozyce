using System.Diagnostics;

class Gra
{
    static void Main(string[] args)
    {
        Gra:
        int pktkomputera = 0;
        int pktgracza = 0;

        Console.WriteLine("Witaj w grze kamień papier nożyce! Zmierz sie z naszym komputerem");
        Console.WriteLine("Do ilu pkt chcesz grać?");
            int wymaganapkt = int.Parse(Console.ReadLine());
        while (pktkomputera != wymaganapkt && pktgracza != wymaganapkt)
        {

            Random rnd = new Random();
            int wybor_komputera = rnd.Next(3);
            losowaniegracza:
            Console.WriteLine("Wybierz Kamień(k), papier(p), nożyce(n)");
            string wybor_gracza = Console.ReadLine();

            int wybor_gracza_int = 4;
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
                    goto losowaniegracza;
                    break;
            }

            if (wybor_gracza_int == wybor_komputera)
            {
                Console.WriteLine("Remis");
                Console.WriteLine($"Kpmputer: {pktkomputera} --- Gracz: {pktgracza}");
            }
            else if ((wybor_gracza_int == 0 && wybor_komputera == 1) || (wybor_gracza_int == 1 && wybor_komputera == 2) || (wybor_gracza_int == 2 && wybor_komputera == 0))
            {
                Console.WriteLine("Komputer wygrywa");
                Console.WriteLine($"Kpmputer: {pktkomputera} --- Gracz: {pktgracza}");
                pktkomputera++;
            }
            else
            {
                Console.WriteLine("Gracz wygrywa");
                Console.WriteLine($"Kpmputer: {pktkomputera} --- Gracz: {pktgracza}");
                pktgracza++;
            }
        }
        if (pktgracza == wymaganapkt)
        {
            Console.WriteLine("BEAOW!!!!! wygrales gre!!!!!!!!!");
        }
        else if (pktkomputera == wymaganapkt)
        {
            Console.WriteLine("Przegrales ;//");
        }
        Console.WriteLine("Czy chcesz zagrac ponownie? (t/n)");
        string odp = Console.ReadLine();
        if (odp == "t")
        {
            goto Gra;
        }
        else { }
    }
}


