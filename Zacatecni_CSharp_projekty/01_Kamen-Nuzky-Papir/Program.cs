namespace _01_Kamen_Nuzky_Papir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte ve hře kámen, nůžky, papír!");
            Console.WriteLine(" ");
            Console.Write("Zadejte svůj výběr (kámen, nůžky, papír): ");
            string userChoice = Console.ReadLine().ToLower();
            string[] vyber = { "kámen", "nůžky", "papír" };
            Random random = new Random();
            string vyberPocitace = vyber[random.Next(vyber.Length)];

            Console.WriteLine($"Pocitac vybral: {vyberPocitace}");

        }
    }
}
