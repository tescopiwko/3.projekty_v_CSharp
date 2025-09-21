namespace _01_Kamen_Nuzky_Papir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hracChceHrat = true;

            Console.WriteLine("Vítejte ve hře kamen, nuzky, papir! (bez diakritiky)");

            while (hracChceHrat)
            {
                Console.WriteLine(" ");
                Console.Write("Zadejte svůj výběr (kamen, nuzky, papir): ");
                string vyberCloveka = Console.ReadLine().ToLower();
                string[] vyber = { "kamen", "nuzky", "papir" };
                Random random = new Random();
                string vyberPocitace = vyber[random.Next(vyber.Length)];

                Console.WriteLine(VyhodnoceniHry(vyberCloveka, vyberPocitace));

                // Hrat znovu?
                Console.Write("Chcete hrát znovu? (ano/ne): ");
                string odpoved = Console.ReadLine().ToLower();
                if (odpoved != "ano")
                {
                    hracChceHrat = false;
                    Console.WriteLine("Děkuji za hru!");
                }
                else
                {
                    hracChceHrat = true; Console.WriteLine();
                }

            }

        }

        static string VyhodnoceniHry(string vyberCloveka, string vyberPocitace)
        {
            if (vyberCloveka == vyberPocitace)
            {
                return ($"Pocitac vybral: {vyberPocitace}\nRemíza");

            }
            else if ((vyberCloveka == "kamen" && vyberPocitace == "nuzky") ||
                   (vyberCloveka == "nuzky" && vyberPocitace == "papir") ||
                   (vyberCloveka == "papir" && vyberPocitace == "kamen"))
            {
                return ($"Pocitac vybral: {vyberPocitace}\nVyhrál jsi!");

            }
            else if ((vyberCloveka == "kamen" && vyberPocitace == "papir") ||
                    (vyberCloveka == "nuzky" && vyberPocitace == "kamen") ||
                    (vyberCloveka == "papir" && vyberPocitace == "nuzky"))
            {
                return ($"Pocitac vybral: {vyberPocitace}\nProhrál jsi!");

            }
            else
                return ("Neplatný výběr. Zadejte kamen, nuzky nebo papir.");

        }              
    }
}