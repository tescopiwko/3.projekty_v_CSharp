namespace _01_Kámen_nůžky_papír
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hracChceHrat = true;

            Console.WriteLine("Vítejte ve hře kámen, nůžky, papír!");

            while (hracChceHrat)
            {
                Console.WriteLine(" ");
                Console.Write("Zadejte svůj výběr (kámen, nůžky, papír): ");
                string vyberCloveka = Console.ReadLine().ToLower();
                string[] vyber = { "kámen", "nůžky", "papír" };
                Random random = new Random();
                string vyberPocitace = vyber[random.Next(vyber.Length)];

                if (vyberCloveka == vyberPocitace)
                {
                    Console.WriteLine($"Pocitac vybral: {vyberPocitace}\nRemíza");

                }
                else if ((vyberCloveka == "kámen" && vyberPocitace == "nůžky") ||
                       (vyberCloveka == "nůžky" && vyberPocitace == "papír") ||
                       (vyberCloveka == "papír" && vyberPocitace == "kámen"))
                {
                    Console.WriteLine($"Pocitac vybral: {vyberPocitace}\nVyhrál jsi!");

                }
                else if ((vyberCloveka == "kámen" && vyberPocitace == "papír") ||
                        (vyberCloveka == "nůžky" && vyberPocitace == "kámen") ||
                        (vyberCloveka == "papír" && vyberPocitace == "nůžky"))
                {
                    Console.WriteLine($"Pocitac vybral: {vyberPocitace}\nProhrál jsi!");

                }
                else
                    Console.WriteLine("Neplatný výběr. Zadejte kámen, nůžky nebo papír.");
                    

                // Hrat znovu?
                Console.Write("Chcete hrát znovu? (ano/ne): ");
                string odpoved = Console.ReadLine().ToLower();
                if (odpoved == "ano")
                {
                    // Console.WriteLine(new string('\n', 50));
                    hracChceHrat = true; Console.WriteLine();
                }
                else if (odpoved == "ne")
                {
                    hracChceHrat = false; Console.WriteLine("Díky za hraní!");
                }
                else
                {
                    hracChceHrat = true; Console.WriteLine("Neznámý příkaz");
                }

            }

        }
              
    }
}