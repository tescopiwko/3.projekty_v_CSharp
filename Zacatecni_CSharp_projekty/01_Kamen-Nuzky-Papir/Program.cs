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
                {
                    Console.WriteLine("Neplatný výběr. Zadejte kámen, nůžky nebo papír.");
                    continue;
                        
                }
                hracChceHrat = hratZnovu(hracChceHrat);
                if (hracChceHrat == false)
                    Console.Write("Děkuji za hru!");

            }
        }
        // Hrat znovu?
        static bool hratZnovu(bool hracChceHrat)
        {
            while (true)
            {
                Console.Write("Chcete hrát znovu? (ano/ne): ");
                string odpoved = Console.ReadLine().ToLower();
                if (odpoved == "ano")
                {
                    Console.Clear();
                    return true;
                }
                else if (odpoved == "ne")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Neplatná odpověď. Napište 'ano' nebo 'ne'.");
                }
            }
        }      
    }   
}